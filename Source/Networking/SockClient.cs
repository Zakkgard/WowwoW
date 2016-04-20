namespace Server
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;

    using HelperTools;

    public delegate void RemoveClientDelegate(SockClient client);

    public class SockClient : IDisposable
    {
        RemoveClientDelegate removeFromTheServerList;
        protected Socket clientSocket;
        private byte[] dataReceive = new byte[65536];
        private bool disposed = false;
        private MemoryStream ms = new MemoryStream();

        public bool Disposed
        {
            get { return disposed; }
        }

        public SockClient(Socket from, RemoveClientDelegate rftsl)
        {
            removeFromTheServerList = rftsl;
            clientSocket = from;
        }

        public void Start()
        {
            clientSocket.BeginReceive(dataReceive, 0, dataReceive.Length, 0, new AsyncCallback(this.OnReceiveData), this);
        }

        public virtual void OnReceiveData(IAsyncResult result)
        {
            try
            {
                if (disposed)
                {
                    return;
                }

                int len = clientSocket.EndReceive(result);
                if (len <= 0)
                {
                    Dispose();
                    return;
                }

                byte[] toSend = ProcessDataReceived(dataReceive, len);
                if (toSend != null)
                {
                    clientSocket.BeginSend(toSend, 0, toSend.Length, 0, new AsyncCallback(this.OnSended), this);
                }
                else
                {
                    clientSocket.BeginReceive(dataReceive, 0, dataReceive.Length, 0, new AsyncCallback(this.OnReceiveData), this);
                }
            }
            catch (Exception)
            {
                Dispose();
            }
        }

        public virtual byte[] ProcessDataReceived(byte[] data, int length)
        {
            return null;
        }

        public virtual void Send(byte[] toSendBuff, int offset, int len)
        {
            try
            {
                if (disposed)
                {
                    return;
                }

                byte[] newToSend = new byte[len];

                Buffer.BlockCopy(toSendBuff, offset, newToSend, 0, len);
                clientSocket.BeginSend(newToSend, 0, len, 0, new AsyncCallback(this.OnSended2), this);
            }
            catch (Exception)
            {
                Dispose();
            }
        }

        public virtual void Send(byte[] toSendBuff, int len)
        {
            try
            {
                if (disposed)
                {
                    return;
                }

                byte[] newToSend = new byte[len];
                Buffer.BlockCopy(toSendBuff, 0, newToSend, 0, len);
                clientSocket.BeginSend(newToSend, 0, len, 0, new AsyncCallback(this.OnSended2), this);
            }
            catch (Exception)
            {
                Dispose();
            }
        }

        public virtual void Send(char[] toSendBuff, int len)
        {
            try
            {
                if (disposed)
                {
                    return;
                }

                byte[] newToSend = new byte[len];
                Buffer.BlockCopy(toSendBuff, 0, newToSend, 0, len);
                clientSocket.BeginSend(newToSend, 0, len, 0, new AsyncCallback(this.OnSended2), this);
            }
            catch (Exception)
            {
                Dispose();
            }
        }

        public virtual void Send(string str)
        {
            try
            {
                if (disposed)
                {
                    return;
                }

                int len = 0;
                byte[] newToSend = new byte[str.Length];
                Converter.ToBytes(str, newToSend, ref len);
                clientSocket.BeginSend(newToSend, 0, len, 0, new AsyncCallback(this.OnSended2), this);
            }
            catch (Exception)
            {
                Dispose();
            }
        }

        public void OnSended(IAsyncResult ar)
        {
            try
            {
                if (disposed)
                {
                    return;
                }

                int len = clientSocket.EndSend(ar);
                clientSocket.BeginReceive((ar.AsyncState as SockClient).dataReceive, 0, (ar.AsyncState as SockClient).dataReceive.Length, 0, new AsyncCallback(this.OnReceiveData), ar.AsyncState);
            }
            catch
            {
                Dispose();
            }
        }

        public void OnSended2(IAsyncResult ar)
        {
            try
            {

                if (disposed)
                {
                    return;
                }

                int len = clientSocket.EndSend(ar);
            }
            catch (Exception)
            {
                Dispose();
            }
        }

        public void Dispose()
        {
            if (disposed)
                return;
            disposed = true;
            try
            {
                clientSocket.Shutdown(SocketShutdown.Both);
            }
            catch
            { }

            if (clientSocket != null)
                clientSocket.Close();
            clientSocket = null;
            if (removeFromTheServerList != null)
                removeFromTheServerList(this);
        }

        public IPAddress IP
        {
            get
            {
                try
                {
                    if (disposed)
                        return null;
                    return ((IPEndPoint)clientSocket.RemoteEndPoint).Address;
                }
                catch
                {
                    Dispose();
                }
                return null;
            }
        }
    }
}
