using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MouseReader
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        [DllImport("User32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);
    }
}
