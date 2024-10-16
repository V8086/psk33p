using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psk33p
{
    internal class Psk33pCoder
    {
        public static byte[] Encode(byte[] bytes, string key)
        {
            uint venc;
            byte[] res = new byte[bytes.Length];
            for (uint i = 0; i < bytes.Length; ++i)
            {
                venc = (uint)((bytes[i] - i) ^ bytes.Length);
                res[i] = (byte)(venc ^ key[(int)(i % key.Length)]); 
            }

            return res;
        }

        public static byte[] Decode(byte[] bytes, string key)
        {
            uint vnoenc;
            byte[] res = new byte[bytes.Length];
            for (uint i = 0; i < bytes.Length; ++i)
            {
                vnoenc = (uint)(bytes[i] ^ key[(int)(i % key.Length)]);
                res[i] = (byte)((vnoenc ^ bytes.Length) + i);
            }

            return res;
        }
    }
}
