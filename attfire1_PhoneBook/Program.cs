using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace attfire1_PhoneBook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ContactsContext>());
            //InsertContact();
            Application.Run(new Form1());
        }

        /*private static void InsertContact()
        {
            var num = new PhoneNumber
            {
                Number = "03 479 6141",
                Contact = new Contact
                {
                    FirstName = "Tom",
                    Surname = "Clark"
                }
            };

            using (var context = new ContactsContext())
            {
                context.PhoneNumbers.Add(num);
                context.SaveChanges();
            }
        }*/
    }
}
