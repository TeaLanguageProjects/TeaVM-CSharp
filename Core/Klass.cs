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

        // All data like class byte code version are stored in the class meta data
        public ConcurrentDictionary<string, TeaData> ClassMetaData = new ConcurrentDictionary<string, TeaData>();

        // Required when the method is executed
        public ConcurrentStack<TeaData> LocalStack = new ConcurrentStack<TeaData>();

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
        
        // Class Type
        public KlassType Type = KlassType.CLASS;

        public KlassAccessModifier AccessModifier = KlassAccessModifier.PUBLIC;

        public ConcurrentBag<KlassNonAccessModifiers> NonAccessModifiers = new ConcurrentBag<KlassNonAccessModifiers>();

        public ConcurrentBag<Klass> Interfaces = new ConcurrentBag<Klass>();

        public Klass SuperClasses;// = new Klass();

        public ConcurrentBag<KlassAnnotation> Annotations = new ConcurrentBag<KlassAnnotation>();


        public string ClassName = "Main";
        
        public string PackageName = "Program";

        // Save local data of the class (such as code in the class)
        public LocalData LocalData = new LocalData();


        public Klass Clone()
        {
            Klass clone = new Klass();
            // clone all data in sources class to new class
            clone.LocalVariables = LocalVariables;
            clone.LocalConstants = LocalConstants;
            clone.ClassMetaData = ClassMetaData;
            clone.LocalStack = LocalStack;
            clone.LocalLinks = LocalLinks;
            clone.LocalImports = LocalImports;
            clone.LocalFunctions = LocalFunctions;
            clone.LocalClasses = LocalClasses;
            clone.LocalIndex = LocalIndex;
            clone.Type = Type;
            clone.AccessModifier = AccessModifier;
            clone.NonAccessModifiers = NonAccessModifiers;
            clone.Interfaces = Interfaces;
            clone.SuperClasses = SuperClasses;
            clone.Annotations = Annotations;
            clone.ClassName = ClassName;
            clone.PackageName = PackageName;
            clone.LocalData = LocalData;

            return clone;
        }   



        public bool IsStatic()
        {
            return NonAccessModifiers.Contains(KlassNonAccessModifiers.STATIC);
        }

        public bool IsFinal()
        {
            return NonAccessModifiers.Contains(KlassNonAccessModifiers.FINAL);
        }

        public bool IsAbstract()
        {
            return NonAccessModifiers.Contains(KlassNonAccessModifiers.ABSTRACT);
        }

        public bool IsInterface()
        {
            return Type == KlassType.INTERFACE;
        }

        public bool IsEnum()
        {
            return Type == KlassType.ENUM;
        }

        public bool IsAnnotation()
        {
            return Type == KlassType.ANNOTATION;
        }

        public bool IsPublic()
        {
            return AccessModifier == KlassAccessModifier.PUBLIC;
        }

        public bool IsPrivate()
        {
            return AccessModifier == KlassAccessModifier.PRIVATE;
        }

        public bool IsProtected()
        {
            return AccessModifier == KlassAccessModifier.PROTECTED;
        }

        public Dictionary<long, Klass> GetStaticFunctions()
        {
            Dictionary<long, Klass> staticFunctions = new Dictionary<long, Klass>();
            foreach (KeyValuePair<long, Klass> function in LocalFunctions)
            {
                if (function.Value.IsStatic())
                {
                    staticFunctions.Add(function.Key, function.Value);
                }
            }

            return staticFunctions;
        }

        public Dictionary<string, Klass> GetStaticFunctionsString()
        {
            Dictionary<long, Klass> staticFunctions = GetStaticFunctions();
            Dictionary<string, Klass> staticFunctionsString = new Dictionary<string, Klass>();
            foreach (KeyValuePair<long, Klass> function in staticFunctions)
            {
                staticFunctionsString.Add(LocalIndex[function.Key], function.Value);
            }
            return staticFunctionsString;

        }



        public TeaData GetLocalVariable(long index)
        {
            if (LocalVariables.ContainsKey(index))
            {
                return LocalVariables[index];
            }
            return null;
        }

        public TeaData GetLocalConstant(long index)
        {
            if (LocalConstants.ContainsKey(index))
            {
                return LocalConstants[index];
            }
            return null;
        }

        public TeaData GetLocalLink(long index)
        {
            if (LocalLinks.ContainsKey(index))
            {
                return LocalLinks[index].Data;
            }
            return null;
        }

        public Dictionary<long, TeaData> GetLocalVariables()
        {
            return LocalVariables.ToDictionary(entry => entry.Key, entry => entry.Value);
        }

        public Dictionary<long, TeaData> GetLocalConstants()
        {
            return LocalConstants.ToDictionary(entry => entry.Key, entry => entry.Value);
        }

        public Dictionary<string, TeaData> GetLocalVariablesString()
        {
            Dictionary<long, TeaData> localVariables = GetLocalVariables();
            Dictionary<string, TeaData> localVariablesString = new Dictionary<string, TeaData>();
            foreach (KeyValuePair<long, TeaData> variable in localVariables)
            {
                localVariablesString.Add(LocalIndex[variable.Key], variable.Value);
            }
            return localVariablesString;
            
        }

        public Dictionary<string, TeaData> GetLocalConstantsString()
        {
            Dictionary<long, TeaData> localConstants = GetLocalConstants();
            Dictionary<string, TeaData> localConstantsString = new Dictionary<string, TeaData>();
            foreach (KeyValuePair<long, TeaData> constant in localConstants)
            {
                localConstantsString.Add(LocalIndex[constant.Key], constant.Value);
            }
            return localConstantsString;
            
        }

        public Dictionary<long, TeaData> GetStaticVariables()
        {
            Dictionary<long, TeaData> staticVariables = new Dictionary<long, TeaData>();
            foreach (KeyValuePair<long, TeaData> variable in LocalVariables)
            {
                if (variable.Value.IsStatic())
                {
                    staticVariables.Add(variable.Key, variable.Value);
                }
            }

            return staticVariables;
        }

        public Dictionary<string, TeaData> GetStaticVariablesString()
        {
            Dictionary<long, TeaData> staticVariables = GetStaticVariables();
            Dictionary<string, TeaData> staticVariablesString = new Dictionary<string, TeaData>();
            foreach (KeyValuePair<long, TeaData> variable in staticVariables)
            {
                staticVariablesString.Add(LocalIndex[variable.Key], variable.Value);
            }
            return staticVariablesString;
            
        }





















    }
}
