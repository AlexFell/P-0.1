using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПРОГ.ЛАБ._0_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int I = 0;
            int CH = 0;
            string S;
            double L = 0, a = 0, b = 0, l = 0, r = 0;
            double PI = 3.14;
            Console.WriteLine("ВСЕ ЗНАЧЕНИЯ ВВОДЯТСЯ В МИЛЛИМЕТРАХ");
            Console.WriteLine("Введите длину бруска");
            for ( int i = 0; L <= 0; ++i )
            {
                S = Console.ReadLine();
                char[] mass = S.ToCharArray();
                I = 0;
                CH = 0;
                for (int j = 0; j < mass.Length; ++j)
                {
                    char c = mass[j];
                    if (c == '.' || c == ',' || c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    {
                        if ((c == '.' || c == ',') && (j == 0 || j == mass.Length - 1))
                        {
                            I = 1;
                            break;
                        }
                        else if (c == '.' || c == ',')
                        {
                            CH += 1;
                        }
                    }
                    else
                    {
                        I = 1;
                        break;
                    }
                    
                }
                
                if (I == 1 || CH >= 2)
                {
                    Console.WriteLine("Введите значение заного, то что вы ввели не является числом!");
                }
                else
                {
                    S = S.Replace('.', ',');
                    L = Convert.ToDouble(S);
                    if (L <= 0)
                    {
                        i = 0;
                        Console.WriteLine("Длина бруска должна быть больше 0");
                        Console.WriteLine("Введите значение заного");
                    }
                }
            }
            
            Console.WriteLine("Введите ширину бруска");
            for ( int i = 0; a <= 0; ++i )
            {
                S = Console.ReadLine();
                char[] mass = S.ToCharArray();
                I = 0;
                CH = 0;
                for (int j = 0; j < mass.Length; ++j)
                {
                    char c = mass[j];
                    if (c == '.' || c == ',' || c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    {
                        if ((c == '.' || c == ',') && (j == 0 || j == mass.Length - 1))
                        {
                            I = 1;
                            break;
                        }
                        else if (c == '.' || c == ',')
                        {
                            CH += 1;
                        }
                    }
                    else
                    {
                        I = 1;
                        break;
                    }
                }

                if (I == 1 || CH >= 2)
                {
                    Console.WriteLine("Введите значение заного, то что вы ввели не является числом!");
                }
                else
                {
                    S = S.Replace('.', ',');
                    a = Convert.ToDouble(S);
                    if (a <= 0)
                    {
                        i = 0;
                        Console.WriteLine("Ширина бруска должна быть больше 0");
                        Console.WriteLine("Введите значение заного");
                    }
                }
            }
            
            Console.WriteLine("Введите высоту бруска");
            for ( int i = 0; b <= 0; ++i )
            {
                S = Console.ReadLine();
                char[] mass = S.ToCharArray();
                I = 0;
                CH = 0;
                for (int j = 0; j < mass.Length; ++j)
                {
                    char c = mass[j];
                    if (c == '.' || c == ',' || c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    {
                        if ((c == '.' || c == ',') && (j == 0 || j == mass.Length - 1))
                        {
                            I = 1;
                            break;
                        }
                        else if (c == '.' || c == ',')
                        {
                            CH += 1;
                        }
                    }
                    else
                    {
                        I = 1;
                        break;
                    }
                }

                if (I == 1 || CH >= 2)
                {
                    Console.WriteLine("Введите значение заного, то что вы ввели не является числом!");
                }
                else
                {
                    S = S.Replace('.', ',');
                    b = Convert.ToDouble(S);
                    if (b <= 0)
                    {
                        i = 0;
                        Console.WriteLine("Высота бруска должна быть больше 0");
                        Console.WriteLine("Введите значение заного");
                    }
                } 
            }
            
            Console.WriteLine("Введите длину цилиндра");
            for ( int i = 0; l <= 0 || l > L; ++i )
            {
                S = Console.ReadLine();
                char[] mass = S.ToCharArray();
                I = 0;
                CH = 0;
                for (int j = 0; j < mass.Length; ++j)
                {
                    char c = mass[j];
                    if (c == '.' || c == ',' || c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    {
                        if ((c == '.' || c == ',') && (j == 0 || j == mass.Length - 1))
                        {
                            I = 1;
                            break;
                        }
                        else if (c == '.' || c == ',')
                        {
                            CH += 1;
                        }
                    }
                    else
                    {
                        I = 1;
                        break;
                    }
                }

                if (I == 1 || CH >= 2)
                {
                    Console.WriteLine("Введите значение заного, то что вы ввели не является числом!");
                }
                else
                {
                    S = S.Replace('.', ',');
                    l = Convert.ToDouble(S);
                    if (l <= 0 || l > L)
                    {
                        i = 0;
                        Console.WriteLine("Длина цилиндра не должна превышать длины бруска и должна быть больше 0");
                        Console.WriteLine("Введите значение заного");
                    }
                }
            }
            
            Console.WriteLine("Введите радиус цилиндра");
            for (int i = 0; r <= 0 || r > a / 2 || r > b / 2; ++i)
            {
                S = Console.ReadLine();
                char[] mass = S.ToCharArray();
                I = 0;
                CH = 0;
                for (int j = 0; j < mass.Length; ++j)
                {
                    char c = mass[j];
                    if (c == '.' || c == ',' || c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    {
                        if ((c == '.' || c == ',') && (j == 0 || j == mass.Length - 1))
                        {
                            I = 1;
                            break;
                        }
                        else if (c == '.' || c == ',')
                        {
                            CH += 1;
                        }
                    }
                    else
                    {
                        I = 1;
                        break;
                    }
                }

                if (I == 1 || CH >= 2)
                {
                    Console.WriteLine("Введите значение заного, то что вы ввели не является числом!");
                }
                else
                {
                    S = S.Replace('.', ',');
                    r = Convert.ToDouble(S);
                    if (r <= 0 || r > a / 2 || r > b / 2)
                    {
                        i = 0;
                        Console.WriteLine("Радиус цилиндра должен быть больше 0 и не превышать ширину и высоту бруска более чем в 2 раза");
                        Console.WriteLine("Введите значение заного");
                    }
                }
            }

            double Vb = L * a * b;
            Console.WriteLine("Объём бруска: " + Vb);
            double Vc = PI * l * r * r;
            Console.WriteLine("Объём цилиндра: " + Vc);
            double PR = (100 * Vc) / Vb;
            Console.WriteLine(PR + "% материала ушло в отходы");
            
            Console.ReadKey();
        }
    }
}