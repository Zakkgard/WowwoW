namespace Server
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Packet
    {
        public byte[] data;
        public int len;

        public Packet(byte[] d, int l)
        {
            byte[] newBuff = new byte[l];
            Buffer.BlockCopy(d, 0, newBuff, 0, l);
            data = newBuff;
            len = l;
        }
    }
}
