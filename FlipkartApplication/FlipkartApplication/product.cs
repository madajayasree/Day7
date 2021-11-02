using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipkartApplication
{
    class product
    {

        //fields
        int id;
        string name;
        string category;
        long price;

        //properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public long Price { get => price; set => price = value; }

        //override
        public override string ToString()
        {
            return String.Format("id is  {0}   name is: {1}  category is: {2}  price is: {3} ",id,name,category,price);
        }
    }
}
