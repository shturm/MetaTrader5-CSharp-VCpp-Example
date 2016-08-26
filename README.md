# MetaTrader 5 MQL Integration Example
Example of how to call C++ / C# functions from MetaTrader 5 MQL Expert Advisors, Indicators, etc



### SUPER IMPORTANT: Build both projects in x64 or MT5 won't see the exported functions !

## CSharp
1. Create regular **class library** (dll) with Visual Studio/MonoDevelop/Xamarin 
1. Include NuGet package **[UnmanagedExports](https://www.nuget.org/packages/UnmanagedExports)**
1. Attach **DllExport** attribute to every **public static** method you want to export
```
[DllExport("Add", CallingConvention = CallingConvention.StdCall)]
public static int Add(int left, int right)
{
    return left + right;
}
```

More examples (Section 4, working with arrays): https://www.mql5.com/en/articles/249

## Visual C++

1. Create Win32 project and from the wizard change project type from _Windows Application_ to _DLL_
1. Mark the functions you want to export: 
```
extern "C" __declspec(dllexport) 
int __stdcall MyFunc() { 
	return 42;
}
```
More examples (working with arrays): https://www.mql5.com/en/articles/18

### MQL5
- Copy your DLL files to *<terminal_path>/MQL5/Libraries*. You can also change output of your project to that path
- Import DLL files and describe functions
```
// VC++
#import "MQLIntegrationVCpp.dll"
   int GetTheAnswerOfEverything();
#import

// C#
#import "MQLIntegrationCs.dll"
   int Add(int left,int right);
   int Sub(int left,int right);
   float AddFloat(float left,float right);
   double AddDouble(double left,double right);
#import

int OnInit()
{  
  Print("############ Gateway initiated");
 
  Print("Hello C#: 2+3 = ",Add(2, 3)); // 5
  Print("Hello VC++: The answer is ", GetTheAnswerOfEverything()); // 42

  return(INIT_SUCCEEDED);
}
```