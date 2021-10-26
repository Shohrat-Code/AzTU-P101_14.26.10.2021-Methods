using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 3
            //const float pi = 3.14F;

            //Console.WriteLine("r");
            //int r = Convert.ToInt32(Console.ReadLine());
            //double l = 2 * pi * r;
            //double s = pi * Math.Pow(2, 3);
            //Console.WriteLine("l= " + l + " S= " + s);
            #endregion

            #region Task 5
            //Console.Write("Ededi daxil edin : ");
            //string num = Console.ReadLine();
            //Console.Write("Uzunlugu daxil edin : ");
            //int wid = Convert.ToInt32(Console.ReadLine());
            //int width = wid;

            //for (int i = 0; i < width; i++)
            //{
            //    for (int j = wid; j > 0; j--)
            //    {
            //        Console.Write(num);
            //    }
            //    Console.WriteLine();
            //    wid--;
            //}
            #endregion

            #region Task 6
            //string username = "murad", username_input;
            //string password = "hajiyev", password_input;
            //int wrong_try = 0;
            //do
            //{
            //    Console.Write("Enter username: ");
            //    username_input = Console.ReadLine();
            //    if(username_input == username)
            //    {
            //        wrong_try = 0;
            //        do
            //        {
            //            Console.Write("Enter password: ");
            //            password_input = Console.ReadLine();
            //            if (password_input == password)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                wrong_try++;
            //            }
            //        } while (wrong_try != 3);
            //        break;
            //    } else
            //    {
            //        wrong_try++;
            //    }
            //} while (wrong_try != 3);
            //if(wrong_try != 3)
            //{
            //    Console.Write("Success");
            //} 
            //else
            //{
            //    Console.Write("Failed");
            //}
            #endregion

            #region New Lesson
            //Power 3
            Console.Write("Enter the number: ");
            byte x = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter the power: ");
            byte y = Convert.ToByte(Console.ReadLine());

            int Result = Power(x, y);

            Console.WriteLine($"The {y} power of {x} is {Result}");

            Console.WriteLine("----------------------------");
            //Power 5
            Console.Write("Enter the number: ");
            byte Number = Convert.ToByte(Console.ReadLine());

            Console.Write("Enter the power: ");
            byte PowerValue = Convert.ToByte(Console.ReadLine());

            int Result2 = Power(Number);

            Console.WriteLine($"The {PowerValue} power of {Number} is {Result2}");
            int a = 15;
            #endregion
        }

        static int Power(byte number, byte power = 1)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
