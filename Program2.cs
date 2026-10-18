using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.slayt_uygulamaları_2.uygulama
{
    internal class Program
    { 
      static void Main(string[] args)
        {
            List<string> liste = new List<string> { "05323334455" };
            Console.WriteLine( NumaravarMi(liste, "05323334455"));
        }
 
    static bool NumaravarMi(List<string> liste, string aranan)
        {
            foreach(string numara in liste)
            {
                if numara == aranan) 
                {
                    return true;
                }
            }
            return false;
        }  
    }
}
