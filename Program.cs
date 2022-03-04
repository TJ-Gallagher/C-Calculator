using System;
using System.Globalization;


namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 150; i++)
            {
                Console.WriteLine("Loading...");
            }
            Console.Clear();
            string rest = "";
            do{ 

            
            Console.WriteLine("Welcome to Calculator 1.0");
            Console.WriteLine("Commands: operations, run, end, forcolor, clear, backcolor, info");
            string command = Console.ReadLine();
            if (command == "run" || command == "Run")
            {
                math.Calc();
            }
            else if (command == "info" || command == "Info")
                {
                    Console.WriteLine("This is a Calculator project I made to practice c#, this is my first project. There are some things I may add in the future hense the name Calculator 1.0. Thanks for checking out my project feel free to let me know changes I should make. Like switch statments.");
                }
            else if (command == "operations" || command == "Operations")
            {
                Console.WriteLine("add to add, sub to subtract, div to divide, mul to multiply, max to find the greatest number, min to find the lowest number, sqr to find the square root, rnd to round, dou to square a number, rem to find the reminder of a divison equation");
            }
            else if (command == "clear" || command == "Clear")
            {
                    Console.WriteLine("Type Anything to Clear");
                    Console.ReadLine();
                    Console.Clear();
            }
            else if (command == "end" || command == "End")
            {
                    Console.WriteLine("Shuting Down...");
                    break;
            }
            else if (command == "BackColor" || command == "backcolor")
            {
                    Console.WriteLine("Write a color to switch the backround too: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Black");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Blue");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Cyan");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Dark Blue");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Dark Cyan");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Dark Gray");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Dark Green");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Dark Magenta");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Dark Red");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Dark Yellow");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Gray");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Green");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Magenta");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Red");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("White");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Yellow");

                    string clr1 = Console.ReadLine();

                    if (clr1 == "Black" || clr1 == "black")
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (clr1 == "Blue" || clr1 == "blue")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if (clr1 == "Cyan" || clr1 == "cyan")
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                    }
                    else if (clr1 == "Dark Blue" || clr1 == "dark blue")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }
                    else if (clr1 == "Dark Cyan" || clr1 == "dark cyan")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                    }
                    else if (clr1 == "Dark Gray" || clr1 == "dark gray")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                    }
                    else if (clr1 == "Dark Green" || clr1 == "dark green")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                    }
                    else if (clr1 == "Dark Magenta" || clr1 == "dark magenta")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    }
                    else if (clr1 == "Dark Red" || clr1 == "dark red")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    }
                    else if (clr1 == "Dark Yellow" || clr1 == "dark yellow")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (clr1 == "Gray" || clr1 == "gray")
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    else if (clr1 == "Green" || clr1 == "green")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (clr1 == "Magenta" || clr1 == "magenta")
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                    }
                    else if (clr1 == "Red" || clr1 == "red")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else if (clr1 == "White" || clr1 == "white")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else if (clr1 == "Yellow" || clr1 == "yellow")
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.WriteLine("Not valid color\n\n");
                    }
                }
            else if (command == "ForColor" || command == "forcolor")
            {
                    Console.WriteLine("Write a color to the foreground switch too: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Black");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Blue");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Cyan");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Dark Blue");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Dark Cyan");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Dark Gray");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Dark Green");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Dark Magenta");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Dark Red");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Dark Yellow");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Gray");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Green");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Magenta");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Red");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("White");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Yellow");

                    string clr  = Console.ReadLine();

                    if(clr == "Black" || clr == "black")
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else if (clr == "Blue" || clr == "blue")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (clr == "Cyan" || clr == "cyan")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (clr == "Dark Blue" || clr == "dark blue")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else if (clr == "Dark Cyan" || clr == "dark cyan")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                    }
                    else if (clr == "Dark Gray" || clr == "dark gray")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else if (clr == "Dark Green" || clr == "dark green")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else if (clr == "Dark Magenta" || clr == "dark magenta")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    }
                    else if (clr == "Dark Red" || clr == "dark red")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }
                    else if (clr == "Dark Yellow" || clr == "dark yellow")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    else if (clr == "Gray" || clr == "gray")
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if (clr == "Green" || clr == "green")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (clr == "Magenta" || clr == "magenta")
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else if (clr == "Red" || clr == "red")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (clr == "White" || clr == "white")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (clr == "Yellow" || clr == "yellow")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.WriteLine("Not valid color\n\n");
                    }
                    





                }
            else
            {
                   

            }
                Console.WriteLine("Type Restart to enter the console\n\n\n\n\n\n\n\n\n");
                rest = Console.ReadLine();
        } while (rest == "Restart" || rest == "restart") ;

        }
    }
    class math
    {
        public static void Calc()
        {
            string ch = "";
            Console.WriteLine("\n\n\nMath");
            Console.WriteLine(" __________\n");
            Console.WriteLine("| ________ |\n");
            Console.WriteLine("||12345678||\n");
            Console.WriteLine("|\"\"\"\"\"\"\"\"\"\"|\n");
            Console.WriteLine("|[^|#|C][-]|\n");
            Console.WriteLine("|[7|8|9][+]|\n");
            Console.WriteLine("|[4|5|6][x]|\n");
            Console.WriteLine("|[1|2|3][>]|\n");
            Console.WriteLine("|[.|O|$][=]|\n");
            Console.WriteLine("\"----------\"\n\n\n");
            do
            {
                Console.WriteLine("\nEnter First Number");
                string num1 = Console.ReadLine();
                Console.WriteLine("\nEnter A Operation!");
                string op1 = Console.ReadLine();
                if (op1 == "sqr" || op1 == "Sqr")
                {
                    float num3 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);


                    Console.WriteLine("\n");
                    Console.WriteLine(Math.Sqrt(num3));
                }
                else if (op1 == "rnd" || op1 == "Rnd")
                {
                    float num3 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);



                    Console.WriteLine(Math.Round(num3));
                }
                else if (op1 == "dou" || op1 == "Dou")
                {
                    float num3 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);


                    double num5 = num3 * num3;
                    Console.WriteLine(num5);
                }
                else
                {
                    Console.WriteLine("\nEnter Second Number");
                    string num2 = Console.ReadLine();
                    if (op1 == "add")
                    {
                        float num3 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num4 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);

                        double num5 = num3 + num4;
                        Console.WriteLine(num5);
                    }
                    else if (op1 == "sub")
                    {
                        float num3 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num4 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);

                        double num5 = num3 - num4;
                        Console.WriteLine(num5);

                    }
                    else if (op1 == "div")
                    {
                        float num3 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num4 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);

                        double num5 = num3 / num4;
                        Console.WriteLine(num5);
                    }
                    else if (op1 == "mul")
                    {
                        float num3 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num4 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);

                        double num5 = num3 * num4;
                        Console.WriteLine(num5);
                    }

                    else if (op1 == "max")
                    {
                        float num3 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num4 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);


                        Console.WriteLine(Math.Max(num3, num4));
                    }
                    else if (op1 == "min")
                    {
                        float num3 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num4 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);

                        Console.WriteLine(Math.Min(num3, num4));
                    }
                    else if (op1 == "rem")
                    {
                        float num3 = float.Parse(num2, CultureInfo.InvariantCulture.NumberFormat);
                        float num4 = float.Parse(num1, CultureInfo.InvariantCulture.NumberFormat);

                        double num5 = num3 % num4;
                        Console.WriteLine(num5);
                    }
                    else
                    {
                        Console.WriteLine("You Enterd A non Acceptable Operator\n\n");
                    }
                    

                    
                }
                Console.WriteLine("Do you want to repeat the Program");
                ch = Console.ReadLine();
                
            }
            while (ch == "yes" || ch == "Yes" || ch == "y" || ch == "Y");
        }
    }
}


