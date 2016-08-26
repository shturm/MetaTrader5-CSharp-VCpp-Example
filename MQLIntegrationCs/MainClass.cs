using System.Runtime.InteropServices;
using RGiesecke.DllExport; // https://www.nuget.org/packages/UnmanagedExports
// IMPORTANT - Build this project in x64 or it won't be imported in MT5 !

namespace MQLIntegrationCs
{
    public class MainClass
    {

        [DllExport("Add", CallingConvention = CallingConvention.StdCall)]
        public static int Add(int left, int right)
        {
            return left + right;
        }

        [DllExport("Sub", CallingConvention = CallingConvention.StdCall)]
        public static int Sub(int left, int right)
        {
            return left - right;
        }

        [DllExport("AddDouble", CallingConvention = CallingConvention.StdCall)]
        public static double AddDouble(double left, double right)
        {
            return left + right;
        }

        [DllExport("AddFloat", CallingConvention = CallingConvention.StdCall)]
        public static float AddFloat(float left, float right)
        {
            return left + right;
        }
    }
}