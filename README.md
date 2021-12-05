# FaceRecognitionRepro

A small .NET 5 console application that reproduces a failure on macOS 10.15.7 with the following exception:
```
Unhandled exception. System.TypeInitializationException: 
The type initializer for 'DlibDotNet.NativeMethods' threw an exception.
 ---> System.DllNotFoundException: Unable to load shared library 'DlibDotNetNativeDnn' or one of its dependencies. 
 In order to help diagnose loading problems, consider setting the DYLD_PRINT_LIBRARIES environment variable: 
 dlopen(libDlibDotNetNativeDnn, 1): image not found
```
