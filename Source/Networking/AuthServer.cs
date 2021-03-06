namespace Server
{
    using System;
    using System.Collections;
    using System.Net;
    using System.Net.Sockets;

    public class AuthServer : IDisposable
    {
        string ip;
        int port;
        Socket listenSocket;
        public static ArrayList clients = new ArrayList();
        IPAddress address;
        AddressFamily addressFamily;
        public int totalSend = 0;
        public int totalReceive = 0;

        public void CloseServer()
        {
            listenSocket.Close();
        }

        public AuthServer(string i, int pt)
        {
            ip = i;
            port = pt;
            IPHostEntry lipa = Dns.GetHostEntry(IPAddress.Parse(i));
            IPEndPoint lep = new IPEndPoint(lipa.AddressList[3], port);
            addressFamily = lep.Address.AddressFamily;
            address = lep.Address;
            Start();
        }

        public bool Start()
        {
            try
            {
                listenSocket = new Socket(addressFamily, SocketType.Stream, ProtocolType.Tcp);
                listenSocket.Bind(new IPEndPoint(IPAddress.Any, port));
                Console.WriteLine("Listen on port {0}, IP {1}", port, address.ToString());
                listenSocket.Listen(1000);
                listenSocket.BeginAccept(new AsyncCallback(this.OnAccept), listenSocket);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failled to list on port {0}\n{1}", port, e.Message);
                listenSocket = null;
                return false;
            }
            return true;
        }

        public virtual void OnAccept(IAsyncResult result)
        {
            try
            {
                Socket newSocket = listenSocket.EndAccept(result);

                if (newSocket != null)
                {
                    ClientConnection newClient = new ClientConnection(newSocket, new RemoveClientDelegate(this.RemoveClient));
                    clients.Add(newClient);
                    newClient.Start();
                }
            }
            catch { }
            try
            {
                listenSocket.BeginAccept(new AsyncCallback(this.OnAccept), listenSocket);
            }
            catch
            {
                Dispose();
            }
        }

        public void RemoveClient(SockClient client)
        {
            clients.Remove(client);
        }

        public void Dispose()
        {
            while (clients.Count > 0)
            {
                var client = clients[0] as SockClient;
                if (client != null)
                {
                    client.Dispose();
                }
            }

            listenSocket.Shutdown(SocketShutdown.Both);

            if (listenSocket != null)
            {
                listenSocket.Close();
            }
        }
    }
}
