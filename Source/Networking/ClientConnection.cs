namespace Server
{
    using HelperTools;

    using System;
    using System.Linq;
    using System.Net.Sockets;
    using System.Security.Cryptography;
    using System.Text;

    using WowwoW.Networking.Authentication;

    public class ClientConnection : SockClient
    {
        private SRP6 SRP;
        private static RandomNumberGenerator randomGenerator = new RNGCryptoServiceProvider();
        private ushort[] supportedBuilds = new ushort[] { 5875, 6005, 6141 };
        private string usernameStr;

        public ClientConnection(Socket sock, RemoveClientDelegate rcd)
            : base(sock, rcd)
        {
        }
        
        static Random rand = new Random();
        Account myAccount;
        private ushort build;
        private byte[] salt = new byte[32];
        

        public override byte[] ProcessDataReceived(byte[] data, int length)
        {
            //SecureRemotePassword.Test();

            Console.WriteLine("Received: " + Enum.ToObject(typeof(AuthenticationCodes), data[0]).ToString());

            switch (data[0])
            {
                case (byte)AuthenticationCodes.CMD_AUTH_LOGON_CHALLENGE:
                    build = BitConverter.ToUInt16(data, 11);
                    byte usernameLength = data[33];
                    usernameStr = Encoding.UTF8.GetString(data, 34, usernameLength);

                    if (!supportedBuilds.Contains(build))
                    {
                        // the client build is not supported, return WOW_FAIL_VERSION_INVALID
                        return new byte[]
                        {
                            (byte)AuthenticationCodes.CMD_AUTH_LOGON_CHALLENGE,
                            0x00,
                            (byte)AuthenticationResults.WOW_FAIL_VERSION_INVALID
                        };
                    }

                    myAccount = World.allAccounts.FindByUserName(usernameStr);
                    
                    if (myAccount == null)
                    {
                        Console.WriteLine("Sent: WOW_FAIL_SUSPENDED");
                        return new byte[] { (byte)AuthenticationResults.WOW_FAIL_INCORRECT_PASSWORD };
                    }

                    if (myAccount.SelectedChar != null)
                    {
                        return new byte[] { 1, 0x6 };
                    }

                    var identityHash = SRP6.GenerateCredentialsHash(usernameStr, myAccount.Password);
                    SRP = new SRP6(usernameStr, identityHash);
                    
                    byte[] packet = new byte[119];
                    packet[0] = 0;
                    packet[1] = 0;
                    packet[2] = 0;
                    //Buffer.BlockCopy(SRP.PublicEphemeralB.GetBytes(), 0, packet, 3, 32);
                    Array.Copy(SRP.PublicEphemeralB.GetBytes(), 0, packet, 3, 32);
                    packet[35] = 1;
                    //Buffer.BlockCopy(SRP.Generator.GetBytes(), 0, packet, 36, 1);
                    packet[36] = 7;
                    packet[37] = 32;
                    //Buffer.BlockCopy(SRP.Modulus.GetBytes(), 0, packet, 38, 32);
                    //Buffer.BlockCopy(SRP.Salt.GetBytes(), 0, packet, 70, 32);
                    //Buffer.BlockCopy(SRP.Unknown.GetBytes(), 0, packet, 102, 16);
                    Array.Copy(SRP.Modulus.GetBytes(), 0, packet, 38, 32);
                    Array.Copy(SRP.Salt.GetBytes(), 0, packet, 70, 32);
                    Array.Copy(SRP.Unknown.GetBytes(), 0, packet, 102, 16);
                    return packet;

                case (byte)AuthenticationCodes.CMD_AUTH_LOGON_PROOF:

                    if (!supportedBuilds.Contains(build))
                    {
                        // the client build is not supported, return WOW_FAIL_VERSION_INVALID
                        return new byte[]
                        {
                            (byte)AuthenticationCodes.CMD_AUTH_LOGON_CHALLENGE,
                            0x00,
                            (byte)AuthenticationResults.WOW_FAIL_VERSION_INVALID
                        };
                    }

                    //uint8 cmd;
                    //uint8 A[32];
                    //uint8 M1[20];
                    //uint8 crc_hash[20];
                    //uint8 number_of_keys;
                    //uint8 securityFlags;

                    BigInteger A = new BigInteger(data.Skip(1).Take(32).ToArray());

                    //check if A equals zero and abort
                    //if (A == 0)
                    //{

                    //}
                    
                    BigInteger proof = new BigInteger(data.Skip(33).Take(20).ToArray());
                    SRP.PublicEphemeralA = A;
                    
                    byte[] packetProof = new byte[32];
                    packetProof[0] = 1;
                    packetProof[1] = 0;
                    Array.Copy(SRP.ServerSessionKeyProof.GetBytes(), 0, packetProof, 2, 20);

                    return packetProof;
                case 0x02://	Reconnect challenge
                    {
                        //	Console.WriteLine( "Reconnect challenge" );

                        //byte[] packRecoChallenge = new byte[34];
                        //packRecoChallenge[0] = 0x02;
                        //packRecoChallenge[1] = 0x00;
                        //for (t = 0; t < 16; t++)
                        //    packRecoChallenge[18 + t] = 0;
                        //return packRecoChallenge;
                        break;
                    }
                case 0x03://	Reconnect proof
                          //	Console.WriteLine( "Reconnect proof" );
                    return new byte[] { 0x03, 0x00 };
                case 0x04://	Update server
                          //	Console.WriteLine( "Update server" );
                    break;
                case 0x10://	Realm List					
                          //	Console.WriteLine( "Realm lList request" );
                    string ip = World.ServerIP;
                    /*	if ( base.theClientHandler.IP.ToString().StartsWith( "192.168.0" ) )
                        {
                            ip = "192.168.0.2";
                        }
                        else*/
                    if (IP.ToString() == "127.0.0.1")
                    {
                        ip = "127.0.0.1";
                    }
                    byte[] retData = new byte[25 + ip.Length + World.ServerName.Length + World.ServerPort.ToString().Length];
                    /*
                    byte []retData = new byte[ ]{   0x10, 45, 
                                              0x00, 0x00, 0x00, 0x00, 
                                              0x00, 
                                              0x01, 0x00, 0x00, 0x00, 
                                              0x00, 0x00, 
                                              (byte)'D', (byte)'r', (byte)' ', (byte)'N', (byte)'e',
                                              (byte)'x', (byte)'u', (byte)'s', 
                                              0x00, (byte)'1', (byte)'9', (byte)'2', (byte)'.', 
                                              (byte)'1', (byte)'6', (byte)'8', (byte)'.', 
                                              (byte)'0', (byte)'.', 
                                              (byte)'2', 
                                              0x3a, 0x38, 0x30, 0x38, 0x35, 
                                              0x00, 0x00, 0x00, 0x00, 
                                              0x00, 0x00, 
                                              0x01, 0x00, 
                                              0x02, 0x00 };*/
                    int offset = 0;
                    Converter.ToBytes((byte)0x10, retData, ref offset);
                    Converter.ToBytes((byte)43, retData, ref offset);
                    Converter.ToBytes(1/*World.allConnectedChars.Count*/, retData, ref offset);
                    Converter.ToBytes((byte)0, retData, ref offset);
                    Converter.ToBytes(1, retData, ref offset);
                    Converter.ToBytes((short)0, retData, ref offset);
                    Converter.ToBytes(World.ServerName, retData, ref offset);
                    Converter.ToBytes((byte)0, retData, ref offset);
                    Converter.ToBytes(ip, retData, ref offset);
                    Converter.ToBytes((byte)':', retData, ref offset);
                    Converter.ToBytes(World.ServerPort.ToString(), retData, ref offset);
                    Converter.ToBytes((byte)0, retData, ref offset);
                    Converter.ToBytes(0, retData, ref offset);
                    //	Converter.ToBytes( (short)0, retData, ref offset );//	cr erreir
                    //Converter.ToBytes( (short)1, retData, ref offset );
                    //Converter.ToBytes( (short)2, retData, ref offset );

                    Converter.ToBytes((short)World.allConnectedChars.Count, retData, ref offset);
                    Converter.ToBytes((byte)0, retData, ref offset);
                    Converter.ToBytes((short)1, retData, ref offset);
                    int atlen = 1;
                    offset -= 3;
                    Converter.ToBytes(offset, retData, ref atlen);
                    Console.WriteLine("Connected player(s) {0}", World.allConnectedChars.Count);
                    /*	if ( World.allConnectedChars.Count < 3 )*/
                    //Thread.Sleep( 500 );
                    return retData;

                default:
                    Console.WriteLine("Received unknown: " + Enum.ToObject(typeof(AuthenticationCodes), data[0]).ToString());
                    break;

            }

            return new byte[] { 0, 0, 0, 0 };
        }

    }
}
/*
 * 
 * 0x01 = Failure
0x02 = Cancelled
0x03 = Disconnect
0x04 = Failed to connect
0x05 = (connect)
0x06 = Wrong client version
0x07 = Connecting to server...
0x08 = Negotiating security
0x09 = Security negotiation complete
0x0a = Security negotiation failed
0x0b = Authenticating
0x0c = Authentication successful (login complete...)
0x0d = Authentication failed
0x0e = Login Unavailable - Please contact Customer Support
0x0f = Server is not valid
0x10 = System unavailable - Please try again later
0x11 = System error
0x12 = Billing system error
0x13 = Account billing has expired
0x14 = Wrong client version
0x15 = Unknown account
0x16 = Incorrect password
0x17 = Session expired
0x18 = Server shutting down
0x19 = Already logged in
0x1a = Invalid login server
0x1b = Position in Queue: 0
0x1c = This account has been banned for violating the Terms of Use Agreement
0x1d = This character is still logged on
0x1e = Your World of Warcraft subscription has expired
0x1f = This session has timed out
0x20 = This account has been temporarily suspended for violating the Terms of Use Agreement
0x21 = Retrieving realm list
0x22 = realm list retrieved
0x23 = Unable to connect to realm list server
0x24 = Invalid realm list
0x25 = The game server you have chosen is currently down
0x26 = Creating account
0x27 = Account created
0x28 = Character creation failed
0x29 = Retreiving characterlist
0x2a = Characterlist retreived
0x2b = Error retreiving characterlist
0x2c = Creating character
0x2d = Creating character --> and go's to charlist
0x2e = Error creating character
0x2f = Character creation failed
0x30 = Name unavailable
0x31 = Creation of that class / race is currently disabled
0x32 = All of your characters on a PVP realm must be on teh same team
0x33 = You already have the maximum number of characters allowed in this realm
0x34 = You already have the maximum number of characters allowed on this account
0x35 = Deleting character
0x36 = Character deleted
0x37 = Character deletion failed
0x38 = Entering World of Warcraft
0x39 = Login Succesfull
0x40 = World server is down
0x41 = A character with that name already exists
0x42 = No instance servers available
0x43 = Login Failed
0x44 = Login for that class, race or character is currently disabled
0x45 = Enter a name for your character
0x46 = Names must be atleast 2 characters
0x47 = Names must be nomore then 12 characters
0x48 = Names can only contain letters
0x49 = Names must contain only one language
0x50 = That name contains profanity
0x51 = That name is unavailable
0x52 = You cannot use an apostroph as the first or last character of you
0x53 = You can have only one apostroph
0x54 = You cannor use the same letter three times consecutively
0x55 = Invalid character name
0x56 = <empty window>
0x57 and up = numbers starting with (75)
*/
