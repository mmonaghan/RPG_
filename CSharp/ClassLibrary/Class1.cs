using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static string PrintNativeText(string text);

        public void PrintText()
        {
            PrintNativeText("This is some text from C# via embedded Mono");

            PrintNativeText("I just wasted 4 hours of my life on this bullshit T_T");
        }
    }
}
