using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaVM.Core
{
    public class LocalData
    {
        public byte[] ByteCodes = new Byte[]{};

        public byte[] ReadFirstBytes(int n)
        {
            byte[] bytes = new byte[n];
            for (int i = 0; i < n; i++)
            {
                bytes[i] = ByteCodes[i];
            }
            return bytes;
        }
        
        public byte[] ReadBytes(int startIndex, int count)
        {
            if (startIndex < 0 || startIndex >= ByteCodes.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Start index is out of range.");
            }

            int remainingBytes = ByteCodes.Length - startIndex;
            int bytesToRead = Math.Min(count, remainingBytes);

            byte[] bytes = new byte[bytesToRead];
            for (int i = 0; i < bytesToRead; i++)
            {
                bytes[i] = ByteCodes[startIndex + i];
            }
            return bytes;
        }

    }
}
