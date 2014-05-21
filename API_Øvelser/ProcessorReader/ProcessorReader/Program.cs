using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorReader
{
    class Program
    {
        //Dword = uint
        //Word = ushort
        private struct SysInfo
        {
            ushort ProcessorArchitecture;
            ushort Reserved;
        }

        private static SysInfo m_Info;

        static void Main(string[] args)
        {
            GetSystemInfo(out m_Info);

            Console.WriteLine(m_Info.);
            Console.WriteLine();

            Console.ReadKey();
        }

        [DllImport("Kernel32.dll")]
        private static extern void GetSystemInfo(out SysInfo systemInfo);
    }
}
