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

        /// Модуль 2. Частина 1

        void DisplayOfAllProducts()
        {
            Console.Clear();
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                var query = "SELECT * FROM Products";
                var cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Type"]} {reader["Quantity"]} {reader["PrimeCost"]} {reader["DateOfDelivery"]}");
                    }

                }

                conn.Close();
                Console.ReadLine();
                Console.Clear();
            }
        }

        void DisplayOfAllTypes()
        {
            Console.Clear();
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                var query = "SELECT DISTINCT Products.Type FROM Products";
                var cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Type"]}");
                    }

                }

                conn.Close();
                Console.ReadLine();
                Console.Clear();
            }
        }

        void DisplayOfAllManufactures()
        {
            Console.Clear();
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                var query = "SELECT * FROM Manufacturers";
                var cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]} {reader["Name"]}");
                    }

                }

                conn.Close();
                Console.ReadLine();
                Console.Clear();
            }
        }

        void DisplayProductWithMaximumQuantity()
        {
            Console.Clear();
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                var query = "SELECT TOP 1  * FROM Products ORDER BY Products.Quantity DESC";
                var cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Type"]} {reader["Quantity"]} {reader["PrimeCost"]} {reader["DateOfDelivery"]}");
                    }

                }

                conn.Close();
                Console.ReadLine();
                Console.Clear();
            }
        }

        void DisplayProductWithMinimymQuantity()
        {
            Console.Clear();
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                var query = "SELECT TOP 1  * FROM Products ORDER BY Products.Quantity";
                var cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Type"]} {reader["Quantity"]} {reader["PrimeCost"]} {reader["DateOfDelivery"]}");
                    }

                }

                conn.Close();
                Console.ReadLine();
                Console.Clear();
            }
        }

        void DisplayProductWithMaximumCost()
        {
            Console.Clear();
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                var query = "SELECT TOP 1  * FROM Products ORDER BY Products.PrimeCost DESC";
                var cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Type"]} {reader["Quantity"]} {reader["PrimeCost"]} {reader["DateOfDelivery"]}");
                    }

                }

                conn.Close();
                Console.ReadLine();
                Console.Clear();
            }
        }

        void DisplayProductWithMinimumCost()
        {
            Console.Clear();
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                var query = "SELECT TOP 1  * FROM Products ORDER BY Products.PrimeCost";
                var cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Type"]} {reader["Quantity"]} {reader["PrimeCost"]} {reader["DateOfDelivery"]}");
                    }

                }

                conn.Close();
                Console.ReadLine();
                Console.Clear();
            }
        }

        void DisplayProductsOfGivenType()
        {
            Console.Clear();

            string str;
            Console.Write("Enter the type: ");
            str = Console.ReadLine();

            Console.WriteLine();


            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                var query = "SELECT * FROM Products WHERE Products.Type = @str";
                var cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@str", str);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Type"]} {reader["Quantity"]} {reader["PrimeCost"]} {reader["DateOfDelivery"]}");
                    }

                }

                conn.Close();
                Console.ReadLine();
                Console.Clear();
            }
        }

        void DisplayProductsOfGivenManufacturer()
        {
            Console.Clear();

            int i;
            Console.Write("Enter the Manufacturer id: ");
            i =int.Parse(Console.ReadLine());

            Console.WriteLine();


            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                var query = "SELECT Products.Name, Products.Type, Products.Quantity, Products.PrimeCost, Products.DateOfDelivery FROM Products, Manufacturers WHERE Products.IdManufaterer = @i";
                var cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@i", i);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Type"]} {reader["Quantity"]} {reader["PrimeCost"]} {reader["DateOfDelivery"]}");
                    }

                }

                conn.Close();
                Console.ReadLine();
                Console.Clear();
            }
        }

        void DisplayTheProductInStockTheLongestOfAll()
        {
            Console.Clear();
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                var query = "SELECT TOP 1  * FROM Products ORDER BY Products.DateOfDelivery ";
                var cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Id"]} {reader["Name"]} {reader["Type"]} {reader["Quantity"]} {reader["PrimeCost"]} {reader["DateOfDelivery"]}");
                    }

                }

                conn.Close();
                Console.ReadLine();
                Console.Clear();
            }
        }

        void DisplayTheAverageNumberOfProductsForEachType()
        {
            Console.Clear();
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                var query = "SELECT Products.Type, AVG(Products.Quantity) AS 'AverageQuantity' FROM Products GROUP BY Products.Type;";
                var cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["Type"]} {reader["AverageQuantity"]}");
                    }

                }

                conn.Close();
                Console.ReadLine();
                Console.Clear();
            }
        }

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
                        /// Модуль 2.Частина 1
                        Console.WriteLine("Enter the comand \n1 - Display All Information About Products           | 2 - Display All Types Of Products              | 3 - Display All Manufactures");
                        Console.WriteLine("4 -  Display The Product With Maximum Quantity       | 5 -  Display The Product With Minimum Quntity  | 6 - Display The Product With Minimal Cost");
                        Console.WriteLine("7 -  Display The Product With Maximum Cost           | 8 -  Display Products Of Given Type            | 9 - Display Products Of Given Manufacturer");
                        Console.WriteLine("10 - Display The Product In Stock The Longest Of All | 11 - Display The Average Number Of Products For Each Type");
                        /// Модуль 2.Частина 2
                        Console.WriteLine("12 - Insert New Information                          | 13 - Delete Information                        | 14 - Update Information");
                        Console.WriteLine("0 - Exit");

                        Console.Write("Comand: ");
                        j = Int32.Parse(Console.ReadLine());
                        switch (j)
                        {
                            case 1: 
                                Program.DisplayOfAllProducts();
                                break;
                            case 2:
                                Program.DisplayOfAllTypes();
                                break;
                            case 3:
                                Program.DisplayOfAllManufactures();
                                break;
                            case 4:
                                Program.DisplayProductWithMaximumQuantity();
                                break;
                            case 5:
                                Program.DisplayProductWithMinimymQuantity();
                                break;
                            case 6:
                                Program.DisplayProductWithMinimumCost();      
                                break;
                            case 7:
                                Program.DisplayProductWithMaximumCost();
                                break;
                            case 8:
                                Program.DisplayProductsOfGivenType();
                                break;
                            case 9:
                                Program.DisplayProductsOfGivenManufacturer();
                                break;
                            case 10:
                                Program.DisplayTheProductInStockTheLongestOfAll();
                                break;
                            case 11:
                                Program.DisplayTheAverageNumberOfProductsForEachType();
                                break;
                            default:
                                j = 0;
                                break;
                        }
                    }
                    i = -1;
                }
            }                                                                                                                                                                                                                                                                                                                                                                                                                                        
        }
    }
}
