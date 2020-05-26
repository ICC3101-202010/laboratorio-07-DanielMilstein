using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Operations
    {
        private float Num1;
        private float Num2;
        


        public float Op(string kind)
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
