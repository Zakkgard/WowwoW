using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace Server
{
    public class ClientHandler
    {
        public int m_State;
        private TcpClientBis ClientSocket;
        private NetworkStream networkStream;
        bool ContinueProcess = false;
        private byte[] bytes;       // Data buffer for incoming data.
        int length = 0;
        private StringBuilder sb = new StringBuilder(); // Received data string.
        public int m_Num;
        TcpIPSocketClient theClient;
        string handler;

        public ClientHandler(TcpClientBis _ClientSocket, int num, string handle)
        {
            handler = handle;
            m_Num = num;
            ClientSocket = _ClientSocket;
            //ClientSocket.ReceiveTimeout = 5000 ; // 100 miliseconds
            networkStream = ClientSocket.GetStream();
            bytes = new byte[ClientSocket.ReceiveBufferSize];
            ContinueProcess = true;
            m_State = 0;
            //System.Net.Sockets.Socket ip = ClientSocket.Sock;
            if (handle == "PlayerHandler")
            {
                this.Send(new byte[] { 0x0, 0x06, 0xec, 0x01, 0x71, 0x2c, 0x7e, 0x88 });
            }
        }

        public IPAddress IP
        {
            get { return ClientSocket.IP; }
        }
        public int Port
        {
            get { return ClientSocket.Port; }
        }
        public IPAddress SourceIP
        {
            get { return ClientSocket.SourceIP; }
        }
        public void Process()
        {
            try
            {
                if (networkStream.DataAvailable)
                {
                    //					Console.WriteLine("Client #{0} processing", m_Num );
                    int len = networkStream.Read(bytes, 0, (int)bytes.Length);
                    if (len > 0)
                    {
                        length += len;
                        //	Console.Write( "Data {0}, ", len );
                        //	HexViewer.View( bytes, 0, len );
                        //	Console.WriteLine("");		
                        ProcessDataReceived();
                    }
                }
                //	else
                //		ProcessDataReceived();
            }
            catch (IOException)
            {
                // All the data has arrived; put it in response.
                ProcessDataReceived();
                networkStream.Flush();
            }
            catch (SocketException)
            {
                networkStream.Close();
                ClientSocket.Close();
                ContinueProcess = false;
                Console.WriteLine("Conection is broken!");
            }


        }  // Process()  
        public static ConstructorInfo FindConstructor(string cls)
        {
            char[] sep = { '.' };
            string[] classname = cls.Split(sep);
            Module[] moduleArray;
            moduleArray = Assembly.GetAssembly(typeof(ClientHandler)).GetModules(false);
            Module myModule = moduleArray[0];
            Type[] tArray;
            tArray = myModule.FindTypes(Module.FilterTypeName, classname[classname.Length - 1]);

            ConstructorInfo[] m = tArray[0].GetConstructors();//GetMethods( BindingFlags.Public|BindingFlags.Instance|BindingFlags.DeclaredOnly

            foreach (ConstructorInfo method in m)
            {
                ParameterInfo[] param = method.GetParameters();
                if (param.Length == 0)
                    return method;
            }
            return null;
        }
        private void ProcessDataReceived()
        {
            if (theClient == null)//&& data.StartsWith( "new " ) )
            {
                ConstructorInfo ctr = FindConstructor(handler);
                theClient = (TcpIPSocketClient)ctr.Invoke(null);
                theClient.theClientHandler = this;
            }

            byte[] ret = theClient.ProcessDataReceived(bytes, this, length);
            if (ret != null)
                Send(ret);
            length = 0;
        }
        public void Close()
        {
            Console.WriteLine("Closing connection");
            networkStream.Close();
            ClientSocket.Close();
        }
        public void Send(string str)
        {
            try
            {
                if (str.Length <= 0)
                    return;
                StringBuilder response = new StringBuilder();
                response.Append(str);
                byte[] sendBytes = Encoding.ASCII.GetBytes(response.ToString());
                //	HexViewer.View( sendBytes, 0, sendBytes.Length );
                networkStream.Write(sendBytes, 0, sendBytes.Length);
            }
            catch (Exception)
            {
            }
        }
        public void Send(byte[] str)
        {
            try
            {
                networkStream.Write(str, 0, str.Length);
            }
            catch (Exception)
            {
                //	Console.WriteLine( "Connection broken with {0}", this.IP.Address.ToString() );
            }
        }
        public void Send(byte[] str, int length)
        {
            try
            {
                networkStream.Write(str, 0, length);
            }
            catch (Exception)
            {
                //Console.WriteLine( "Connection broken with {0}", this.IP.Address.ToString() );
            }
        }

        public NetworkStream NetStream
        {
            get { return networkStream; }
        }
        public bool Alive
        {
            get { return ContinueProcess; }
        }
    } 
}
