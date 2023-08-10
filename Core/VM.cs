﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaVM.Core
{
    public class VM
    {
        public ConcurrentDictionary<long, TeaData> VMConstant = new ConcurrentDictionary<long, TeaData>();

        public List<TeaData> VMStack = new List<TeaData>();

        public ConcurrentDictionary<long, VMThread> VMThreads = new ConcurrentDictionary<long, VMThread>();

        public ConcurrentDictionary<long, Klass> VMObjects = new ConcurrentDictionary<long, Klass>();

        public ConcurrentDictionary<long, string> VMIndex = new ConcurrentDictionary<long, string>();


    }
}
