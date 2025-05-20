using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFormProject
{
    public static class DataHandler
    {
        private const string FilePath = @"CustomerData.txt";
        public static void SaveData(List<Customer> customers)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (Customer customer in customers)
                    {
                        writer.WriteLine($"Customer,{customer.FirstName},{customer.LastName}");

                        foreach (Purchase purchase in customer.Purchases)
                        {
                            writer.WriteLine($"Purchase,{purchase.ProductName},{purchase.Price},{purchase.Quantity}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
            }
        }

        public static List<Customer> LoadData()
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                if (File.Exists(FilePath))
                {
                    using (StreamReader reader = new StreamReader(FilePath))
                    {
                        string line;
                        Customer currentCustomer = null;

                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');

                            if (parts.Length > 0)
                            {
                                if (parts[0] == "Customer" && parts.Length == 3)
                                {
                                    currentCustomer = new Customer
                                    {
                                        FirstName = parts[1],
                                        LastName = parts[2],
                                        Purchases = new List<Purchase>()
                                    };
                                    customers.Add(currentCustomer);
                                }
                                else if (parts[0] == "Purchase" && parts.Length == 4 && currentCustomer != null)
                                {
                                    currentCustomer.Purchases.Add(new Purchase(parts[1], double.Parse(parts[2]), int.Parse(parts[3])));
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
            }

            return customers;
        }
    }
}
