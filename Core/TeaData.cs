using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaVM.Core
{
    public class TeaData
    {
        public TeaTypes Type = TeaTypes.NULL;
        public byte[] Data = { };
        public bool IsList = false;
        public byte[,] ListData = { };

        public Klass SourceKlass = null;

        public KlassAccessModifier AccessModifier = KlassAccessModifier.PUBLIC;
        public ConcurrentBag<KlassNonAccessModifiers> NonAccessModifiers = new ConcurrentBag<KlassNonAccessModifiers>();
        public ConcurrentBag<KlassAnnotation> Annotations = new ConcurrentBag<KlassAnnotation>();

        public TeaData()
        {

        }

        public TeaData Clone()
        {
            TeaData data = new TeaData();
            data.Type = Type;
            data.Data = Data;
            data.IsList = IsList;
            data.ListData = ListData;
            data.SourceKlass = SourceKlass;

            data.AccessModifier = AccessModifier;
            data.NonAccessModifiers = NonAccessModifiers;
            data.Annotations = Annotations;

            return data;
        }

        public static TeaData NewNormalData()
        {
            TeaData data = new TeaData();
            data.Type  = TeaTypes.NULL;
            data.Data  = new byte[] { };
            data.IsList = false;
            data.ListData = new byte[,] { };
            data.SourceKlass = null;

            data.AccessModifier = KlassAccessModifier.PUBLIC;
            data.NonAccessModifiers = new ConcurrentBag<KlassNonAccessModifiers>();
            data.Annotations = new ConcurrentBag<KlassAnnotation>();

            return data;
            
        }

        public static TeaData NewListData()
        {
            TeaData data = new TeaData();
            data.Type = TeaTypes.NULL;
            data.Data = new byte[] { };
            data.IsList = true;
            data.ListData = new byte[,] { };
            data.SourceKlass = null;

            data.AccessModifier = KlassAccessModifier.PUBLIC;
            data.NonAccessModifiers = new ConcurrentBag<KlassNonAccessModifiers>();
            data.Annotations = new ConcurrentBag<KlassAnnotation>();

            return data;
        }

        public bool IsStatic()
        {
            return NonAccessModifiers.Contains(KlassNonAccessModifiers.STATIC);
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

        public bool IsFinal()
        {
            return NonAccessModifiers.Contains(KlassNonAccessModifiers.FINAL);
        }

        public bool HasSourceKlass()
        {
            return this.SourceKlass != null;
        }



        public Byte DataToByte()
        {
            return Data[0];
        }

        public short DataToShort()
        {
            return BitConverter.ToInt16(Data, 0);
        }

        public int DataToInt()
        {
            return BitConverter.ToInt32(Data, 0);
        }

        public long DataToLong()
        {
            return BitConverter.ToInt64(Data, 0);
        }

        public float DataToFloat()
        {
            return BitConverter.ToSingle(Data, 0);
        }

        public double DataToDouble()
        {
            return BitConverter.ToDouble(Data, 0);
        }

        public char DataToChar()
        {
            return BitConverter.ToChar(Data, 0);
        }

        public void ByteToData(byte data)
        {
            this.Data = new byte[] { data };
        }

        public void ShortToData(short data)
        {
            this.Data = BitConverter.GetBytes(data);
        }

        public void IntToData(int data)
        {
            this.Data = BitConverter.GetBytes(data);
        }

        public void LongToData(long data)
        {
            this.Data = BitConverter.GetBytes(data);
        }

        public void FloatToData(float data)
        {
            this.Data = BitConverter.GetBytes(data);
        }

        public void DoubleToData(double data)
        {
            this.Data = BitConverter.GetBytes(data);
        }
        
        public void CharToData(char data)
        {
            this.Data = BitConverter.GetBytes(data);
        }




    }
}
