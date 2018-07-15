using System;
using System.Runtime.InteropServices;

namespace staticLibWatchOSTest.staticLibWatchOSTestWatchExtension
{
    public class testCKLib1
    {
        [DllImport("__Internal")]
        public extern static int sum(int a, int b);
    }
}