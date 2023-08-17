using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaVM.Core
{
    public class VMThread
    {
        public Klass ThreadKlass;
        public VM ThreadVM;
        public ByteCodesExecutor ByteCodesExecutor;
        public Thread Thread;

        public VMThread(Klass threadKlass, VM threadVm)
        {
            this.ThreadKlass = threadKlass;
            this.ThreadVM = threadVm;
            ByteCodesExecutor = new ByteCodesExecutor(threadKlass, threadVm);
            Thread = new Thread(ByteCodesExecutor.Execute);
        }


        public void Start()
        {
            Thread.Start();
        }
        
        public void RunSync()
        {
            ByteCodesExecutor.Execute();
        }

        public void Stop()
        {
            Thread.Abort();
        }

    }
}
