using TeaVM.Core;

namespace TeaVM.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Klass klass = new Klass();
            klass.NonAccessModifiers.Add(KlassNonAccessModifiers.STATIC);
            VM vm  = new VM();
            VMThread thread = new VMThread(klass, vm);
            TeaData data = new TeaData();
            data.Type = TeaTypes.BYTE;
            data.Data = new byte[] { 0x01 };
            TeaData vmdata = new TeaData();
            vmdata.Type = TeaTypes.INT;
            vmdata.Data = new byte[] { 0x02 };
            vm.VMStack.Push(vmdata);
            vm.VMStack.Push(vmdata);
            vm.VMStack.Push(vmdata);
            klass.LocalStack.Push(data);
            klass.LocalStack.Push(data);
            klass.LocalStack.Push(data);
            vm.VMObjects.TryAdd(0x01, klass);
            klass.LocalData.ByteCodes = new byte[]
            {
                0x10,
                0x00,
                0x01,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                
                0x10,
                0x00,
                0x02,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                
                0x26,
                0x00,
                0x03,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                
                0x27,
                0x00,
                0x04,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
            };
            DebugOutputTool.PrintKlass(klass);
            thread.RunSync();
            
            DebugOutputTool.PrintKlass(klass);
            DebugOutputTool.PrintVM(vm);
        }
    }
}