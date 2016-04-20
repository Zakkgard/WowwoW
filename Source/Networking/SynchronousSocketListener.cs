using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public class SynchronousSocketListener
    {
        private int portNum = 10116;
        int numOfThread;
        string handler;
        bool stop = false;
        public ClientService ClientTask;

        public SynchronousSocketListener(int nThread, int port, string handle)
        {
            handler = handle;
            numOfThread = nThread;
            portNum = port;
        }

        public void Stop()
        {
            stop = true;
            ClientTask.Stop();
        }

        public void StartListening()
        {


            // Client Connections Pool
            ClientConnectionPool ConnectionPool = new ClientConnectionPool();

            // Client Task to handle client requests
            ClientTask = new ClientService(ConnectionPool, numOfThread);

            ClientTask.Start();


            TcpListener listener = null;
            listener = new TcpListener(IPAddress.Any, portNum);
            try
            {
                listener.Start();

                int ClientNbr = 0;

                // Start listening for connections.
                Console.WriteLine("Port {0} waiting for a connection...", portNum);
                while (!stop)
                {
                    //		Thread.Sleep(50);
                    //System.Net.Sockets.Socket socket = listener.AcceptSocket();
                    //			TcpClient tcpHandler = listener.AcceptTcpClient();
                    //TcpClientBis t2 = (TcpClientBis)Convert.ChangeType( tcpHandler, typeof(TcpClientBis));
                    TcpClientBis tcpHandler = new TcpClientBis(listener.AcceptSocket());// socket ); 

                    if (tcpHandler != null)
                    {

                        if (tcpHandler.ReceiveBufferSize == 0)
                        {
                            Console.WriteLine("Socket error !");
                            tcpHandler.Close();
                        }
                        //				Console.WriteLine("Client#{0} accepted on port {1}", ++ClientNbr, portNum ) ;
                        ++ClientNbr;
                        // An incoming connection needs to be processed.
                        ConnectionPool.Enqueue(new ClientHandler(tcpHandler, ClientNbr - 1, handler));

                        // --TestingCycle ;
                    }
                    else
                        break;
                }
                listener.Stop();

                // Stop client requests handling
                ClientTask.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
