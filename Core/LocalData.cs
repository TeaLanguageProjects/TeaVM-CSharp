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

        public byte[] ReadBytes(int n)
        {
            byte[] bytes = new byte[n];
            for (int i = 0; i < n; i++)
            {
                bytes[i] = ByteCodes[i];
            }
            return bytes;
        }

    }
}
