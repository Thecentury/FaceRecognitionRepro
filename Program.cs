using System;

namespace FaceRecognitionRepro
{
    class Program
    {
        static void Main(string[] args)
        {
            // The next line throws an exception:
            
            // Unhandled exception. System.TypeInitializationException: The type initializer for 'DlibDotNet.NativeMethods' threw an exception.
            // ---> System.DllNotFoundException: Unable to load shared library 'DlibDotNetNativeDnn' or one of
            //     its dependencies.In order to help diagnose loading problems, consider setting the DYLD_PRINT_LIBRARIES
            //     environment variable:
            // dlopen(libDlibDotNetNativeDnn, 1): image not found
            using (var detector = DlibDotNet.Dlib.GetFrontalFaceDetector())
            {
            }

            Console.WriteLine("Hello World!");
        }
    }
}