using TeaVM.Core;

namespace TeaVM.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Klass klass = new Klass();
            VM vm  = new VM();
            VMThread thread = new VMThread(klass, vm);
            TeaData data = new TeaData();
            data.Type = TeaTypes.BYTE;
            data.Data = new byte[] { 0x01 };
            klass.LocalStack.Push(data);
            klass.LocalStack.Push(data);
            klass.LocalData.ByteCodes = new byte[]
            {
                0x10,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x02
            };
            DebugOutputTool.PrintKlass(klass);
            thread.RunSync();
            
            DebugOutputTool.PrintKlass(klass);
        }
    }
}