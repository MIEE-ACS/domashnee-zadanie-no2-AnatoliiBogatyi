using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите R: ");
            double R;

            try
            {
                R = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Wrong data!");
                Console.Write("\nВведите R: ");
                R = float.Parse(Console.ReadLine());
                Console.ReadKey();
            }


                if (R <= 0)
                {
                    Console.WriteLine("Введены неправельные данные!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\n\tТаблица значений y\n");
                    for (double x = -10; x <= 8; x += 0.2)
                    {

                        if (x < -10 || x > 8)
                        {
                            Console.WriteLine($"\ty({x:0.00}) - Функция не определена");
                        }
                        else if (Math.Round(x, 2) <= -8)
                        {
                            Console.WriteLine($"\ty({x:0.00}) = {segment1(x):0.000}");
                        }
                        else if (Math.Round(x, 2) <= -3)
                        {
                            Console.WriteLine($"\ty({x:0.00}) = {segment2(x):0.000}");
                        }
                        else if (Math.Round(x, 2) < 3)
                        {
                            if ((R < 3) && (Math.Abs(Math.Round(x, 2)) > R))
                            {
                                Console.WriteLine($"\ty({x:0.00}) - Функция не определена");
                            }
                            else
                            {
                                Console.WriteLine($"\ty({x:0.00}) = {segment3(x, R):0.000}");
                            }
                        }
                        else if (Math.Round(x, 2) < 5)
                        {
                            Console.WriteLine($"\ty({x:0.00}) = {segment4(x):0.000}");
                        }
                        else if (Math.Round(x, 2) == 5)
                        {
                            Console.WriteLine($"\ty({x:0.00}) = {segment4(x):0.000} и {segment5(x):0.000}");
                        }
                        else if (Math.Round(x, 2) <= 8)
                        {
                            Console.WriteLine($"\ty({x:0.00}) = {segment5(x):0.000}");
                        }
                        x = Math.Round(x, 2);

                    }
                    Console.ReadKey();
                }
                
            
        }

        static double segment1(double x)
        {
            return -3;
        }

        static double segment2(double x)
        {
            return  (3 * x + 9) / 5;
        }

        static double segment3(double x, double r)
        {
            return (-Math.Sqrt(Math.Abs(r * r - x * x)));
        }

        static double segment4(double x)
        {
            return x - 3;
        }
        static double segment5(double x)
        {
            return 3;
        }

    }
}
