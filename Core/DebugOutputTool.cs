﻿namespace TeaVM.Core;

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
            //Console.WriteLine($"- Type = {variable.Type} ,Data = {variable.Data.ToString()}");
            Console.WriteLine($"- {variable.Type} => {variable.Data.ToString()} => {string.Join("", variable.Data.Select(b => b.ToString()))}");
        }
        
        Console.WriteLine("Local Index:");
        foreach (var variable in klass.LocalIndex)
        {
            Console.WriteLine($"- {variable.Key}: {variable.Value}");
        }
        
        Console.WriteLine("Local Variables:");
        foreach (var variable in klass.LocalVariables)
        {
            //Console.WriteLine($"- {variable.Key}: {variable.Value.Type}");
            Console.WriteLine($"- {variable.Key}: {variable.Value.Type} => {variable.Value.Data.ToString()} => {string.Join("", variable.Value.Data.Select(b => b.ToString()))}");
        }
        
        Console.WriteLine("Local Constants:");
        foreach (var variable in klass.LocalConstants)
        {
            //Console.WriteLine($"- {variable.Key}: {variable.Value.Data.ToString()}");
            Console.WriteLine($"- {variable.Key}: {variable.Value.Type} => {variable.Value.Data.ToString()} => {string.Join("", variable.Value.Data.Select(b => b.ToString()))}");
        }
        
        
    }

    public static void PrintVM(VM vm)
    {
        Console.WriteLine($"===========================================");
        Console.WriteLine("VM Index:");
        foreach (var variable in vm.VMIndex)
        {
            Console.WriteLine($"- {variable.Key}: {variable.Value}");
        }
        Console.WriteLine("VM Stack:");
        foreach (var variable in vm.VMStack)
        {
            Console.WriteLine($"- {variable.Type} => {variable.Data.ToString()} => {string.Join("", variable.Data.Select(b => b.ToString()))}");
        }
        Console.WriteLine("VM Constants:");
        foreach (var variable in vm.VMConstant)
        {
            Console.WriteLine($"- {variable.Key}: {variable.Value.Type} => {variable.Value.Data.ToString()} => {string.Join("", variable.Value.Data.Select(b => b.ToString()))}");
        }
        
        Console.WriteLine("VM Objects:");
        foreach (var variable in vm.VMObjects)
        {
            Console.WriteLine($"- {variable.Key}: {variable.Value.Type} => {variable.Value.AccessModifier} => {variable.Value.PackageName} - {variable.Value.ClassName}");
        }
        
        Console.WriteLine("VM Static Objects:");
        foreach (var variable in vm.VMStaticObjects)
        {
            Console.WriteLine($"- {variable.Key}: {variable.Value.Type} => {variable.Value.AccessModifier} => {variable.Value.PackageName} - {variable.Value.ClassName}");
        }
        
        
        
    }


}