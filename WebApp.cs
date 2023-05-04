using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class WebApp
    {
        public WebApp() {
          
        
        }

        public int ObtenerMayor(int a,int b, int c)
        {
            
             if (a > b && a > c)
            {
           
                return a;
            }
            else
            {
                if (b > a && b > c)
                {
                   
                    return b;
                }
                else
                {
                    if (c > a && c > b)
                    {
                        
                        return c;
                    }
                }
            }

            return 0;
       
        }



    }
}
