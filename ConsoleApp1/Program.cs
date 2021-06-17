using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] username = { "rj", "jr", "dr"};
            string[] password = { "123", "111", "222" };

            Console.WriteLine("_________________________________________________=W E L C O M E=______________________________________________________");


            Console.Write("Username : ");
            string accntusername = Console.ReadLine();

            Console.Write("Password : ");
            string accntpassword = Console.ReadLine();

            bool isfound = false;

            for (int i = 0; i < username.Length; i++)
            {
                if (accntusername.Equals(username[i]) && accntpassword.Equals(password[i]))
                {

                    Console.WriteLine("");

                    isfound = true;
                    Console.WriteLine("Welcome, " + username[i]);
                    break;
                }

            }

            if (!isfound) Console.WriteLine("Account not Found");

            Console.WriteLine("");

            string name, location, education;

            Console.Write("name       : ");
            name = Console.ReadLine();

            Console.Write("Location   : ");
            location = Console.ReadLine();

            Console.Write("Education  : ");
            education = Console.ReadLine();

            Console.Write("Date Graduated");

            Console.WriteLine("");

            Console.Write("Month :");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Day :");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Year :");
            int year = Convert.ToInt32(Console.ReadLine());

            string monthWord;

            switch (month)
            {
                case 1:
                    monthWord = "january";
                    break;
                case 2:
                    monthWord = "february";
                    break;
                case 3:
                    monthWord = "march";
                    break;
                case 4:
                    monthWord = "april";
                    break;
                case 5:
                    monthWord = "may";
                    break;
                case 6:
                    monthWord = "june";
                    break;
                case 7:
                    monthWord = "july";
                    break;
                case 8:
                    monthWord = "august";
                    break;
                case 9:
                    monthWord = "september";
                    break;
                case 10:
                    monthWord = "november";
                    break;
                case 11:
                    monthWord = "december";
                    break;
                case 12:
                    monthWord = "march";
                    break;
                default:
                    monthWord = "";
                    Console.WriteLine("Invalid Month Input");
                    break;
            }

            Console.WriteLine();

            if (day <= 31)
            {
                Console.WriteLine();

                Console.WriteLine("Hi my name is " + name);
                Console.ReadKey();
                Console.WriteLine("I'am from " + location);
                Console.ReadKey();
                Console.WriteLine("I study in " + education);
                Console.ReadKey();
                Console.WriteLine("I graduated year ");


                if (monthWord != "") Console.WriteLine(monthWord + " " + day + ", " + year);
            }
            else Console.WriteLine("Invalid Day, Day is only up to 31");



            Console.WriteLine("Choose A or B or C to see Average ");
            char grade = (char)Console.Read();


            Console.WriteLine("Grade : ");


            switch (grade)



            {

                    case 'A':
                        Console.WriteLine("Outstanding");
                        break;
                    case 'B':
                        Console.WriteLine("Excellent");
                        break;
                    case 'C':
                        Console.WriteLine("Satisfactory");
                        break;
                    default:
                        Console.WriteLine("Invalid Grade");
                        break;
                }

            








            }
    }
}
