namespace Server
{
    using System.Net;
    using System.Net.Sockets;

    public class TcpClientBis : TcpClient
    {
        public TcpClientBis(Socket socket)
        {
            this.Client = socket;
            this.NoDelay = true;
            this.ReceiveTimeout = 5000;
            this.SendTimeout = 5000;
            this.ReceiveBufferSize = 32768;
            this.SendBufferSize = 32768;
        }

        public IPAddress IP
        {
            get { return ((IPEndPoint)Client.RemoteEndPoint).Address; }
        }

        public int Port
        {
            get { return ((IPEndPoint)Client.RemoteEndPoint).Port; }
        }

        public IPAddress SourceIP
        {
            get { return ((IPEndPoint)Client.LocalEndPoint).Address; }
        }
    }
}
