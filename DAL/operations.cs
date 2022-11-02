using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DAL
{
    public class operations
    {
        customerdbEntities context = new customerdbEntities();
        userinfo c = new userinfo();

        public bool ValidateUser(string email, string password)
        {

            bool result = false;


            if (c.email == "abc@123" && c.password == "abc")
            {
                result = true;
            }

            return result;
        }

        public void insert( custloginfo c)
         {
             context.custloginfoes.Add(c);
             context.SaveChanges();
         }
        
       


        }

    }

    

