using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerData
{
    public static class CustomerDB
    {
        // text file named Customers.txt located in bin/Debug folder
        const string PATH = "Customers.txt";

        // read customers data from the file and build the list
        public static List<Customer> GetCustomers()
        {
            List<Customer> customerList = new List<Customer>(); // empty
            Customer c; // for reading
            string line; // line from the file
            string[] fields; // fields from the current line
            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate,
                                                FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream) // while there is still data
                    {
                        line = sr.ReadLine(); // read the next line from the file
                        fields = line.Split(','); // break the line at the commas
                        c = new Customer(); // create new customer
                        c.Account = Convert.ToInt32(fields[0]); // fill it with data
                        c.Name = (fields[1]);
                        c.CustType = (fields[2]);
                        c.Charge = Convert.ToDecimal(fields[3]);
                        customerList.Add(c); // add it to the list
                    }
                    sr.Close();
                } // inner using
            }// outer using

            return customerList;
        } // method

        // save product list to the file
        public static void SaveCustomers(List<Customer> customerList)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Customer c in customerList)
                    {
                        sw.WriteLine(c.ToFileLine());
                    }
                    sw.Close();
                }
            }
        }




    }
}
