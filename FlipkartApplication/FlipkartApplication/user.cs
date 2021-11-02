using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipkartApplication
{
    class user
    {
        string email;
        string password;
        long mbNumber;
        string address;

        

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public long MbNumber { get => mbNumber; set => mbNumber = value; }
        public string Address { get => address; set => address = value; }


       
        public override string ToString()
        {
            return String.Format("email {0}   password is: {1}  mobileNumber is: {2}  address is: {3} " , email,password,mbNumber,address);

        }



    }
}
