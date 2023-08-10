using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaVM.Core
{
    public class Klass
    {
        // All local variables are stored in the local variables dictionary
        public ConcurrentDictionary<long, TeaData> LocalVariables = new ConcurrentDictionary<long, TeaData>();

        // All local constants are stored in the local constants dictionary
        public ConcurrentDictionary<long, TeaData> LocalConstants = new ConcurrentDictionary<long, TeaData>();

        // All data like class name, class type (normal class or interfaces),package name or byte code version are stored in the class meta data
        public ConcurrentDictionary<string, TeaData> ClassMetaData = new ConcurrentDictionary<string, TeaData>();

        // Required when the method is executed
        public List<TeaData> LocalStack = new List<TeaData>();

        // Save the connection object from the string identifier in the class to the specific constant table/variable table object
        public ConcurrentDictionary<long, LocalLink> LocalLinks = new ConcurrentDictionary<long, LocalLink>();

        // Save all class objects introduced from outside in the class
        public ConcurrentDictionary<long, Klass> LocalImports = new ConcurrentDictionary<long, Klass>();

        // All local functions are stored in the local functions dictionary
        public ConcurrentDictionary<long, Klass> LocalFunctions = new ConcurrentDictionary<long, Klass>();

        // All local classes are stored in the local classes dictionary
        public ConcurrentDictionary<long, Klass> LocalClasses = new ConcurrentDictionary<long, Klass>();

        // Conversion Table for Storing String Symbols in Code to Number IDs in Memory
        public ConcurrentDictionary<long, string> LocalIndex = new ConcurrentDictionary<long, string>();

        // Save local data of the class (such as code in the class)
        public LocalData LocalData = new LocalData();
        










    }
}
