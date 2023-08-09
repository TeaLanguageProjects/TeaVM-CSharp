using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaVM.Core
{
    public class Klass
    {
        // All local variables are stored in the local variables dictionary
        public Dictionary<string, TeaData> LocalVariables = new Dictionary<string, TeaData>();

        // All local constants are stored in the local constants dictionary
        public Dictionary<string, TeaData> LocalConstants = new Dictionary<string, TeaData>();

        // All data like class name, class type (normal class or interfaces),package name or byte code version are stored in the class meta data
        public Dictionary<string, TeaData> ClassMetaData = new Dictionary<string, TeaData>();

        // Required when the method is executed
        public List<TeaData> LocalStack = new List<TeaData>();

        // Save the connection object from the string identifier in the class to the specific constant table/variable table object
        public Dictionary<string, LocalLink> LocalLinks = new Dictionary<string, LocalLink>();

        // Save all class objects introduced from outside in the class
        public Dictionary<string, Klass> LocalImports = new Dictionary<string, Klass>();

        // All local functions are stored in the local functions dictionary
        public Dictionary<string, Klass> LocalFunctions = new Dictionary<string, Klass>();

        // All local classes are stored in the local classes dictionary
        public Dictionary<string, Klass> LocalClasses = new Dictionary<string, Klass>();

        // Save local data of the class (such as code in the class)
        public LocalData LocalData = new LocalData();
        










    }
}
