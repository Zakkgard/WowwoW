namespace Server
{
    using System.Threading;

    public class ClientService
    {
        int numOfThread;

        private ClientConnectionPool ConnectionPool;
        private bool ContinueProcess = false;
        private Thread[] ThreadTask;

        public ClientService(ClientConnectionPool ConnectionPool, int nThread)
        {
            numOfThread = nThread;
            ThreadTask = new Thread[nThread];
            this.ConnectionPool = ConnectionPool;
        }

        public void Start()
        {
            ContinueProcess = true;
            // Start threads to handle Client Task
            for (int i = 0; i < ThreadTask.Length; i++)
            {
                ThreadTask[i] = new Thread(new ThreadStart(this.Process));
                ThreadTask[i].Start();
            }
        }

        private void Process()
        {
            while (ContinueProcess)
            {
                ClientHandler client = null;
                lock (ConnectionPool.SyncRoot)
                {
                    if (ConnectionPool.Count > 0)
                        client = ConnectionPool.Dequeue();
                }
                if (client != null)
                {
                    client.Process(); // Provoke client
                                      // if client still connect, schedulor later processingle it 
                    if (client.Alive)
                        ConnectionPool.Enqueue(client);
                    /*else
                        Console.WriteLine("dequeue client#{0}",client.m_Num );*/
                }

                Thread.Sleep(50);
            }
            //Console.WriteLine( "Client service ended" );
        }

        public void Stop()
        {
            ContinueProcess = false;
            for (int i = 0; i < ThreadTask.Length; i++)
            {
                if (ThreadTask[i] != null && ThreadTask[i].IsAlive)
                    ThreadTask[i].Join();
            }

            // Close all client connections
            while (ConnectionPool.Count > 0)
            {
                ClientHandler client = ConnectionPool.Dequeue();
                client.Close();
                //	Console.WriteLine("Client connection is closed!") ;
            }
        }
    }
}
