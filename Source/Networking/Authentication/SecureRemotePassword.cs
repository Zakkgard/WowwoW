using Server;
using System;
using System.IO;
using WowwoW.Net.Authentication;

namespace WowwoW.Networking.Authentication
{
    /// <summary>
    /// This is an implementation of the SRP algorithm documented here:
    /// 
    /// http://srp.stanford.edu/design.html
    /// </summary>
    /// 
    public class SecureRemotePassword
    {
        private const int MinPassLength = 3;
        private const int MaxPassLength = 20;

        private BigInteger salt;
        private BigInteger credentialsHash;
        private BigInteger publicEphemeralValueA;
        private BigInteger publicEphemeralValueB;
        private readonly BigInteger secretEphemeralValueA = RandomNumber();
        private BigInteger secretEphemeralValueB;
        private BigInteger sessionKey;
        private BigInteger verifier;

        public SecureRemotePassword(bool isServer, SRPParameters parameters)
        {
            this.Parameters = parameters;
            this.IsServer = isServer;
        }

        public SecureRemotePassword(bool isServer)
            : this(isServer, SRPParameters.Defaults)
        {
        }

        public SecureRemotePassword(string username, BigInteger credentials, bool isServer, SRPParameters parameters)
        {
            if (parameters.CaseSensitive == false)
            {
                username = username.ToUpper();
            }

            this.Parameters = parameters;

            this.IsServer = isServer;
            this.Username = username;
            this.Credentials = credentials;
        }

        public SecureRemotePassword(string username, BigInteger credentials, bool isServer)
            : this(username, credentials, isServer, SRPParameters.Defaults)
        {
        }

        /// <summary>
        /// Make an SRP for user authentication. You use something like this when your
        /// verifier and salt are stored in a database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="verifier"></param>
        /// <param name="salt"></param>
        /// <param name="parameters"></param>
        public SecureRemotePassword(string username, BigInteger verifier, BigInteger salt, SRPParameters parameters)
        {
            if (parameters.CaseSensitive == false)
            {
                username = username.ToUpper();
            }

            this.Parameters = parameters;
            this.IsServer = true;
            this.Username = username;
            this.Verifier = verifier;
            this.Salt = salt;
        }

        public SecureRemotePassword(string username, BigInteger verifier, BigInteger salt)
            : this(username, verifier, salt, SRPParameters.Defaults)
        {
        }

        public SRPParameters Parameters { get; set; }

        public bool IsServer { get; private set; }

        public string Username { get; set; }

        public BigInteger ClientSessionKeyProof
        {
            get
            {
                return
                    Hash(Hash(this.Modulus) ^ Hash(this.Generator), Hash(this.Username), this.Salt, this.PublicEphemeralValueA,
                         this.PublicEphemeralValueB, this.SessionKey);
            }
        }

        public BigInteger ServerSessionKeyProof
        {
            get { return Hash(this.PublicEphemeralValueA, this.ClientSessionKeyProof, this.SessionKey); }
        }

        public static BigInteger RandomNumber()
        {
            return RandomNumber(32);
        }

        public BigInteger Modulus
        {
            get
            {
                return this.Parameters.Modulus;
            }
        }

        public BigInteger Generator
        {
            get { return this.Parameters.Generator; }
        }

        /// <summary>
        /// 'k' in the spec. In SRP-6a k = H(N, g). Older versions have k = 3.
        /// </summary>
        public BigInteger Multiplier
        {
            get
            {
                return new BigInteger(3);

                // return Hash(Modulus, Generator) if SRP version == SRP-6a
            }
        }

        public BigInteger Credentials { get; set; }

        /// <summary>
        /// Salt for credentials hash. You can bind this to the users'
        /// account or use the automatically generated random salt.
        /// </summary>
        public BigInteger Salt
        {
            get
            {
                if (this.salt == null)
                {
                    if (this.IsServer == false)
                    {
                        throw new Exception("Unknown salt!");
                    }

                    this.salt = RandomNumber();
                }

                return this.salt;
            }

            set { this.salt = value; }
        }

        /// <summary>
        /// 'x' in the spec. Note that this is slightly different - the spec says
        /// x = H(s, p) whereas here x = H(s, H(I, p)), which is the implementation in the demo.
        /// </summary>
        public BigInteger CredentialsHash
        {
            get
            {
                if (this.credentialsHash == null)
                {
                    this.credentialsHash = Hash(this.Salt, this.Credentials);
                }

                return this.credentialsHash;
            }
        }

        /// <summary>
        /// 'A' in the spec. A = g^a, generated by client and sent to the server
        /// </summary>
        public BigInteger PublicEphemeralValueA
        {
            get
            {
                // Generated by the client and sent to the server
                if (this.IsServer == false && this.publicEphemeralValueA == null)
                {
                    this.publicEphemeralValueA = this.Generator.ModPow(this.publicEphemeralValueA, Modulus);
                }

                return this.publicEphemeralValueA;
            }
            set
            {
                if (this.IsServer == false)
                {
                    throw new Exception("Attempt by SRP client to set A. This is generated.");
                }

                this.publicEphemeralValueA = value;

                this.publicEphemeralValueA %= this.Modulus;

                if (this.publicEphemeralValueA < 0)
                {
                    this.publicEphemeralValueA += Modulus;
                }

                if (this.publicEphemeralValueA == 0)
                {
                    // Abort - we got hackers.
                    throw new InvalidDataException("A cannot be 0 mod N!");
                }
            }
        }

        /// <summary>
        /// 'B' in the spec. B = kv + g^b, generated by the server and sent to the client
        /// </summary>
        public BigInteger PublicEphemeralValueB
        {
            get
            {
                // This guy is generated by the server and sent to the client
                if (this.IsServer && this.publicEphemeralValueB == null)
                {
                    this.publicEphemeralValueB = RandomNumber();
                    this.publicEphemeralValueB = this.Multiplier * this.Verifier + this.Generator.ModPow(this.publicEphemeralValueB, this.Modulus);
                    this.publicEphemeralValueB %= this.Modulus;

                    if (this.publicEphemeralValueB < 0)
                    {
                        this.publicEphemeralValueB += this.Modulus;
                    }
                }

                return this.publicEphemeralValueB;
            }
            set
            {
                if (this.IsServer)
                {
                    throw new Exception("Attempt by SRP server to set B. This is generated.");
                }

                this.publicEphemeralValueB = value;
                this.publicEphemeralValueB %= this.Modulus;
                if (this.publicEphemeralValueB < 0)
                    this.publicEphemeralValueB += this.Modulus;

                if (this.publicEphemeralValueB == 0)
                {
                    // Abort - we got hackers.
                    throw new InvalidDataException("B cannot be 0 mod N!");
                }
            }
        }

        /// <summary>
        /// u in the spec. Generated by both server and client.
        /// </summary>
        public BigInteger ScramblingParameter
        {
            get { return Hash(this.PublicEphemeralValueA, this.PublicEphemeralValueB); }
        }

        /// <summary>
        /// This is the session key used for encryption later.
        /// 'K' in the spec. Note that this is different to 'k' (Multiplier)
        /// </summary>
        public BigInteger SessionKeyRaw
        {
            get
            {
                if (this.sessionKey == null)
                {
                    BigInteger S;
                    if (this.IsServer)
                    {
                        if (this.publicEphemeralValueA == null)
                            return null;

                        // S = (Av^u) ^ b (mod N)
                        S = this.Verifier.ModPow(ScramblingParameter, this.Modulus);
                        S = (S * PublicEphemeralValueA) % this.Modulus;
                        S = S.ModPow(this.secretEphemeralValueB, this.Modulus);
                    }
                    else
                    {
                        // S = (B - kg^x) ^ (a + ux) (mod N)
                        S = this.PublicEphemeralValueB - (this.Multiplier * this.Generator.ModPow(this.CredentialsHash, this.Modulus));
                        S = S.ModPow(this.secretEphemeralValueA + this.ScramblingParameter * this.CredentialsHash, this.Modulus);

                        // If S flips negative above the mod function preserves its sign.
                        // We want it positive.
                        if (S < 0)
                            S += this.Modulus;
                    }

                    this.sessionKey = S;
                }

                return this.sessionKey;
            }
        }

        /// <summary>
        /// V in the spec.
        /// v = g^x (mod N)
        /// 
        /// This only makes sense for servers.
        /// </summary>
        public BigInteger Verifier
        {
            get
            {
                if (this.verifier == null)
                {
                    this.verifier = this.Generator.ModPow(this.CredentialsHash, this.Modulus);
                }

                if (this.verifier < 0)
                {
                    this.verifier += this.Modulus;
                }

                return this.verifier;
            }

            set { this.verifier = value; }
        }

        public BigInteger SessionKey
        {
            get
            {
                byte[] data = SessionKeyRaw.GetBytes(32);

                // This is a strange beast.
                var temp = new byte[16];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = data[2 * i];
                }

                byte[] hash1 = Hash(temp).GetBytes(20);

                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = data[2 * i + 1];
                }

                byte[] hash2 = Hash(temp).GetBytes(20);

                // its an interleaving of the two hashes..
                data = new byte[40];

                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = i % 2 == 0 ? hash1[i / 2] : hash2[i / 2];
                }

                return new BigInteger(data);
            }
        }

        public static BigInteger Hash(params HashUtilities.HashDataBroker[] brokers)
        {
            return HashUtilities.HashToBigInteger(SRPParameters.Hash, brokers);
        }

        /// <summary>
        /// Generate a random number of a specified size
        /// </summary>
        /// <param name="size">Maximum size in bytes of the random number</param>
        /// <returns></returns>
        public static BigInteger RandomNumber(uint size)
        {
            var buffer = new byte[size];

            SRPParameters.RandomGenerator.GetBytes(buffer);

            // Must make sure the most significant byte is not zero
            if (buffer[0] == 0)
                buffer[0] = 1;

            return new BigInteger(buffer);
        }

        public bool IsClientProofValid(BigInteger clientProof)
        {
            return this.ClientSessionKeyProof == clientProof;
        }

        public bool IsServerProofValid(BigInteger serverProof)
        {
            return this.ServerSessionKeyProof == serverProof;
        }
    }
}
