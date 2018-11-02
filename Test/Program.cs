using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        
        static void vvodInn(out int inn) {

            inn = vvod("ВВведи 5 цифр", 5);
        }

        static int vvod(string a, int b) {
            Console.WriteLine(a);
        
            while (true) {
                try
                {
                    int y = int.Parse(Console.ReadLine());
                    
                    intValid(y, b);
                   
                    return y;
                }
                catch (Exception) { Console.WriteLine("Введи цифр");}
            }
            
        }

        static void intValid(int s, int v) {
            string k = Convert.ToString(s);
            int dlin = k.Length;
                    if (dlin < v)
                    {
                        Console.WriteLine("введено менее 5 симовлов");
                        throw new Exception();
                    }
        }
        


        static void Main(string[] args)
        {
            //nameFio(out string name, out string surname, out string middlename);
            vvodInn(out int a);
            //inN();
            //inn();
            Console.ReadKey();
        }
    }
    }
