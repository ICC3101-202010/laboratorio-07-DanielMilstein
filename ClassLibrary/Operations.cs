using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Operations
    {
     


        public double Op(double Num1, double Num2, string kind)
        {
            if (kind == "+")
            {
                return Num1 + Num2;
            }

            else if (kind == "-")
            {
                return Num1 - Num2;
            }

            else if (kind == "*")
            {
                return Num1 * Num2;
            }

            else if (kind == "/")
            {
                if (Num2 != 0)
                {
                    return Num1 / Num2;
                }

                else
                {
                    return 0;
                }
                
            }
            else
            {
                return 0;
            }
        }

    }
}
