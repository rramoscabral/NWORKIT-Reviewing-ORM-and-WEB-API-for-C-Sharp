using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lab03_exec01
{
    public class LetsDebug
    {

        public void ForDemo()
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            for (int i = 1; i < intArray.Length; i++) {
                intArray[i] += intArray[i - 1];
                //TO-DO
            }
        }

        


    }
}
