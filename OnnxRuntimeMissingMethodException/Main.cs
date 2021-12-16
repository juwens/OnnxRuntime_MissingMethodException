using System;
using LibraryUsingOnnxRuntime;
using ObjCRuntime;
using UIKit;

namespace OnnxRuntimeMissingMethodException
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            var a = new System.Memory<float>();
            var b = new Microsoft.ML.OnnxRuntime.Tensors.DenseTensor<float>(1);
            var c = new System.Memory<Microsoft.ML.OnnxRuntime.Tensors.DenseTensor<float>>();
            var d = b.Buffer;

            Console.WriteLine(typeof(System.Memory<>).AssemblyQualifiedName);

            Class1.PrintMemoryVersion();
            Class1.TestDenseTensor();

            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, typeof(AppDelegate));
        }
    }
}
