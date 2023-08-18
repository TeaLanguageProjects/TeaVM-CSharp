namespace TeaVM.Core;

public class DebugOutputTool
{
    public static void PrintKlass(Klass klass)
    {
        Console.WriteLine($"===========================================");
        Console.WriteLine($"Class Name: {klass.ClassName}");
        Console.WriteLine($"Package Name: {klass.PackageName}");
        Console.WriteLine($"Type: {klass.Type}");
        Console.WriteLine($"Access Modifier: {klass.AccessModifier}");
        
        Console.WriteLine("Non-Access Modifiers:");
        foreach (var modifier in klass.NonAccessModifiers)
        {
            Console.WriteLine($"- {modifier}");
        }
        
        Console.WriteLine("Interfaces:");
        foreach (var iface in klass.Interfaces)
        {
            Console.WriteLine($"- {iface.ClassName}");
        }
        
        if (klass.SuperClasses != null)
        {
            Console.WriteLine($"Super Class: {klass.SuperClasses.ClassName}");
        }
        
        Console.WriteLine("Annotations:");
        foreach (var annotation in klass.Annotations)
        {
            Console.WriteLine($"- {annotation}");
        }
        
        Console.WriteLine("Local Stack:");
        foreach (var variable in klass.LocalStack)
        {
            Console.WriteLine($"- Type = {variable.Type} ,Data = {variable.Data.ToString()}");
        }
        
        Console.WriteLine("Local Variables:");
        foreach (var variable in klass.LocalVariables)
        {
            Console.WriteLine($"- {variable.Key}: {variable.Value}");
        }
        
        Console.WriteLine("Local Constants:");
        foreach (var variable in klass.LocalConstants)
        {
            Console.WriteLine($"- {variable.Key}: {variable.Value.Data.ToString()}");
        }
        
        
    }
}