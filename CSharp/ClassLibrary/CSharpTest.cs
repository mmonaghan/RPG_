using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CSharpTest
    {
        public float MyPublicFloatVar = 50000.0f;

        public void PrintFloatVar()
        {
            Console.WriteLine("MyPublicFloatVar = {0:F}", MyPublicFloatVar);
            Console.WriteLine("Hi this is C# :D");
        }

        private void IncrementFloatVar(float value)
        {
            MyPublicFloatVar += value;
        }
    }
}
