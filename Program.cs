using System;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached) {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
