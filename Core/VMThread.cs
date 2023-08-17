using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaVM.Core
{
    public class VMThread
    {
        public Klass ThreadKlass = new Klass();

        public VMThread(Klass threadKlass)
        {
            this.ThreadKlass = threadKlass;
        }
    }
}
