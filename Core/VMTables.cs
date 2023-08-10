using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaVM.Core
{
    public enum VMTables
    {
        // These are tables that store class local data
        LocalVariables, LocalConstants, ClassMetaData, LocalStack, LocalLinks, LocalImport, LocalFunctions, LocalClasses, LocalData, LocalIndex,

        // These are tables of virtual machine data
        VMConstant, VMStack, VMThreads, VMObjects, VMIndex
    }
}
