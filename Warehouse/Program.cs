using Microsoft.Win32.SafeHandles;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System;


namespace Warehouse
{
    internal class Program
    {
        public static string StrConn => @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Warehouse;Integrated Security=True;Connect Timeout=30;";
        private SqlConnection _conn;







        static void Main(string[] args)
        {
            var Program = new Program();

            int i = -1;
            while (i != 0)
            {
                Console.Clear();
                Console.WriteLine("Enter the comand \n1 - connect | 0 - exit\n");
                Console.Write("Comand: ");
                i = Int32.Parse(Console.ReadLine());

                if (i == 1)
                {
                    using (SqlConnection conn = new SqlConnection(StrConn))
                    {
                        conn.Open();

                        if (conn.State == System.Data.ConnectionState.Closed)
                        {
                            i = 0;
                            Console.WriteLine("Database wasn't opened!");

                        }
                        Console.WriteLine();
                        conn.Close();
                    }

                    Console.Clear();
                    Console.WriteLine("Database opened succsesful!\n");

                    int j = -1;
                    while (j != 0)
                    {
                        Console.WriteLine("Enter the comand \n1 - Display All Information About Products           | 2 - Display All Types Of Products              | 3 - Display All Manufactures");
                        Console.WriteLine("4 -  Display The Product With Maximum Quantity       | 5 -  Display The Product With Minimum Quntity  | 6 - Display The Product With Minimal Cost");
                        Console.WriteLine("7 -  Display The Product With Maximum Cost           | 8 -  Display Products Of Given Type            | 9 - Display Products Of Given Manufacturer");
                        Console.WriteLine("10 - Display The Product In Stock The Longest Of All | 11 - Display The Average Number Of Products For Each Type");
                        Console.WriteLine("12 - Insert New Information                          | 13 - Delete Information                        | 14 - Update Information");
                        Console.WriteLine("0 - Exit");

                        Console.Write("Comand: ");
                        j = Int32.Parse(Console.ReadLine());
                        //switch (j)
                        //{
                        //    case 1:
                        //        Program.DisplayOfAllInformation();
                        //        break;
                        //    case 2:
                        //        Program.DisplayOfAllNames();
                        //        break;
                        //    case 3:
                        //        Program.DisplayAllColors();
                        //        break;
                        //    case 4:
                        //        Program.DisplayTheMaximumCalorie();
                        //        break;
                        //    case 5:
                        //        Program.DisplayTheMinimumCalorie();
                        //        break;
                        //    case 6:
                        //        Program.DisplayTheAverageCalorie();
                        //        break;
                        //    case 7:
                        //        Program.DisplayNumberOfVegetables();
                        //        break;
                        //    case 8:
                        //        Program.DisplayNumberOfFruits();
                        //        break;
                        //    case 9:
                        //        Program.DisplayNumberOfGivenColor();
                        //        break;
                        //    case 10:
                        //        Program.DisplayNumbersOfEveryColor();
                        //        break;
                        //    case 11:
                        //        Program.DisplayWithCaloriesBelow();
                        //        break;
                        //    case 12:
                        //        Program.DisplayWithCaloriesHigher();
                        //        break;
                        //    case 13:
                        //        Program.DisplayAllYellowOrRedColor();
                        //        break;
                        //    case 14:
                        //        Program.DisplayWithcalorieContentInTheIndicatedRange();
                        //        break;

                        //    default:
                        //        j = 0;
                        //        break;
                        //}
                    }
                    i = -1;
                }
            }
        }
    }
}
