using System;
using System.Collections.Generic;
using System.Text;

namespace KickCashDrawer
{
    class program
    {
        

        static void Main(string[] args)
        {
            int  Interval = 1000;
            try
            {
                if  (args[0] == "-k")
                {
                    if (args.Length > 1)  
                        Int32.TryParse(args[1], out Interval);
                    PosDrawer CashDrawer = new PosDrawer();
                    CashDrawer.CashDrawer();
                    CashDrawer.OpenCashDrawer(Interval);
                }
            }

            catch
            {
                Console.WriteLine("Error Invalid Parameter");
            }
        }

    }


}

