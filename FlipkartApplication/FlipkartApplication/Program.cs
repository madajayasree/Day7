using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipkartApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            


            int obj_count;
            Console.WriteLine("Enter count:");
            obj_count = Convert.ToInt32(Console.ReadLine());
            user[] obj_users = new user[obj_count];
            for(int i=0; i < obj_count; i++)
            {
                obj_users[i] = new user();
                Console.WriteLine("Enter user details: ");

                Console.WriteLine("Enter email: ");
                obj_users[i].Email = Console.ReadLine();

                Console.WriteLine("Enter password: ");
                obj_users[i].Password = Console.ReadLine();

                Console.WriteLine("Enter mobileNumber: ");
                obj_users[i].MbNumber = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("Enter address: ");
                obj_users[i].Address = Console.ReadLine();

            }

            foreach(var item in obj_users)
            {
                Console.WriteLine(item);
            }

            int obj_pro_count;
            Console.WriteLine("Enter  products count:");
            obj_pro_count = Convert.ToInt32(Console.ReadLine());
            product[] obj_products = new product[obj_pro_count];

            
            for (int i = 0; i < obj_pro_count; i++)
            {
                Console.WriteLine("Enter products details: ");
                obj_products[i] = new product();
                Console.WriteLine("Enter user details: ");

                Console.WriteLine("Enter Id: ");
                obj_products[i].Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name: ");
                obj_products[i].Name = Console.ReadLine();

                Console.WriteLine("Enter Category: ");
                obj_products[i].Category = Console.ReadLine();

                Console.WriteLine("Enter Price: ");
                obj_products[i].Price = Convert.ToInt64(Console.ReadLine());

            }
            foreach (var item in obj_products)
            {
                Console.WriteLine(item);
            }


        }
    }
}
