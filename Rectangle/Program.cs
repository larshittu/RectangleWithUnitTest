using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static int length = 0;
        static int width = 0;
        static int height = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value for Rectangle Shape size.");

            Console.WriteLine("Enter Length size:");
            var lengthAsString = Console.ReadLine();
            while (!InputValidation(lengthAsString))//Validating rectangle lenght input
            {
                lengthAsString = Console.ReadLine();
            }
            length = Convert.ToInt32(lengthAsString);

            Console.WriteLine("Enter Width size:");
            var widthAsString = Console.ReadLine();
            while (!InputValidation(widthAsString))//Validating rectangle width input
            {
                widthAsString = Console.ReadLine();
            }
            width = Convert.ToInt32(widthAsString);

            Console.WriteLine("Enter Height size:");
            var heightAsString = Console.ReadLine();
            while (!InputValidation(heightAsString))//Validating rectangle height input
            {
                heightAsString = Console.ReadLine();
            }
            height = Convert.ToInt32(heightAsString);

            Rectangle rectangle = new Rectangle(length, width, height);//Setting constructor rectangle values

            while (true)
            {
                UserRequest();
                var actionString = Console.ReadLine();
                while (!InputValidation(actionString))//Validating user action input
                {
                    actionString = Console.ReadLine();
                }
                int action = Convert.ToInt32(actionString);
                UserResult(action);
            }
        }

        //User Result Method
        private static void UserResult(int action)
        {
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Rectangle.GetLength();
                        Console.WriteLine($"The Rectangle lenght is {result} \n\n");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter new length size:");
                        string stringlength = Console.ReadLine();
                        while (!InputValidation(stringlength))
                        {
                            stringlength = Console.ReadLine();
                        }
                        length = Convert.ToInt32(stringlength);
                        result = Rectangle.SetLength(length);
                        Console.WriteLine($"The new Rectangle lenght is {result} \n\n");
                        break;
                    }
                case 3:
                    {
                        result = Rectangle.GetWidth();
                        Console.WriteLine($"The Rectangle width is {result} \n\n");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter new width size:");
                        string stringwidth = Console.ReadLine();
                        while (!InputValidation(stringwidth))
                        {
                            stringwidth = Console.ReadLine();
                        }
                        width = Convert.ToInt32(stringwidth);
                        result = Rectangle.SetWidth(width);
                        Console.WriteLine($"The new Rectangle width is {result} \n\n");
                        break;
                    }
                case 5:
                    {
                        result = Rectangle.GetHeight();
                        Console.WriteLine($"The Rectangle height is {result} \n\n");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Enter new height size:");
                        string stringheight = Console.ReadLine();
                        while (!InputValidation(stringheight))
                        {
                            stringheight = Console.ReadLine();
                        }
                        height = Convert.ToInt32(stringheight);
                        result = Rectangle.SetHeight(height);
                        Console.WriteLine($"The new Rectangle height is {result} \n\n");
                        break;
                    }
                case 7:
                    {
                        result = Rectangle.GetVolume();
                        Console.WriteLine($"The Rectangle Volume is {result} \n\n");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Thank you!!!");
                        Environment.Exit(0);
                        break;
                    }
                default:
                    Console.WriteLine("Invalid or Wrong action!! try again with list items.\n\n");
                    break;

            }
        }

        //User requestion question Method
        public static void UserRequest()
        {
            Console.WriteLine("Please select an option to work on. \n");

            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Height");
            Console.WriteLine("6. Change Rectangle Height");
            Console.WriteLine("7. Get Rectangle Volume");
            Console.WriteLine("8. Exit \n");
        }

        public static bool InputValidation(string userInput)//User input validation Method
        {
            try
            {
                var inputValue = Convert.ToInt32(userInput);
                if (inputValue < 1)
                {
                    Console.WriteLine("Invalid User input value, try again:");
                    userInput = Console.ReadLine();

                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid user input value:");
                return false;
            }
        }
    }
}
