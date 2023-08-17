using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaVM.Core
{
    public class KlassAnnotation
    {
        public Klass SourceKlass = new Klass();
        public ConcurrentDictionary<long, string> LocalIndex = new ConcurrentDictionary<long, string>();
        public ConcurrentDictionary<long, TeaData> LocalVariables = new ConcurrentDictionary<long, TeaData>();

    }
}
