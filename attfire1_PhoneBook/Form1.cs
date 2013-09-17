using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.Entity.Validation;

namespace attfire1_PhoneBook
{
    public partial class Form1 : Form
    {
        string Id;
        public Form1()
        {
            InitializeComponent();
        }

        private void submitData_btn_Click(object sender, EventArgs e)
        {
            var contact = new Contact
            {
                FirstName = firstName_textBox.Text, 
                Surname = lastName_textBox.Text
            };

            contact.PhoneNumbers.Add(
                new PhoneNumber
                {
                    Number = phoneNumber_textBox.Text
                });

            using (var context = new ContactsContext())
            {
                try
                {
                    context.Contacts.Add(contact);

                    try
                    {
                        context.SaveChanges();
                    }
                    catch(DbEntityValidationException ex)
                    {
                        MessageBox.Show("Please make sure all fields are filled!", "");
                        Console.WriteLine(ex);
                    }
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("All fields must be filled!", "");
                    Console.WriteLine(ex);
                }


                context.Database.Connection.Close();
            }
        }

        private void retrieveContactsBtn_Click(object sender, EventArgs e)
        {
            using (var context = new ContactsContext())
            {
                try
                {
                    displayContactsListBox.Items.Clear();
                    foreach (var c in context.Contacts.Include("PhoneNumbers").ToList())
                    {
                        displayContactsListBox.Items.Add(c);
                    }
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("Please add some contacts first!", "");
                    Console.WriteLine(ex);
                }

                context.Database.Connection.Close();
            }
        }

        private void getSelectedListBoxItem()
        {
            var contactDetails = displayContactsListBox.GetItemText(displayContactsListBox.SelectedItem);

            string[] contactInfo = contactDetails.Split(' ');

            try
            {
                Id = contactInfo[0];
                firstName_textBox.AppendText(contactInfo[1]);
                lastName_textBox.AppendText(contactInfo[2]);
                phoneNumber_textBox.AppendText(contactInfo[3]);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Please load some contacts, then select one from the list box first!", "");
                Console.WriteLine(ex);
            }
        }

        private void loadListItem_Click(object sender, EventArgs e)
        {
            clearFormFields();
            getSelectedListBoxItem();
        }

        private void updateContact_Click(object sender, EventArgs e)
        {
            using (var context = new ContactsContext())
            {
                
                try
                {

                var contact = context.Contacts.Find(int.Parse(Id));

                foreach (var c in context.Contacts.Include("PhoneNumbers").ToList())
                {
                    if (c.Id == int.Parse(Id))
                    {

                            contact.FirstName = firstName_textBox.Text;
                            contact.Surname = lastName_textBox.Text;
                            contact.PhoneNumbers[0].Number = phoneNumber_textBox.Text;

                            MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);

                            context.SaveChanges();
                            clearFormFields();
                        }
                    }
                }

                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("All fields must be filled!", "");
                    Console.WriteLine(ex);
                }
                context.Database.Connection.Close();
            } 
        }

        private void deleteContact_Click(object sender, EventArgs e)
        {
            using (var context = new ContactsContext())
            {

                try
                {
                    var contact = context.Contacts.Find(int.Parse(Id));
                    context.Contacts.Remove(contact);
                    context.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    MessageBox.Show("Please make sure contact has been selected from the list box first!", "");
                    Console.WriteLine(ex);
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("Please make sure contact has been selected from the list box first!", "");
                    Console.WriteLine(ex);
                }
                
                context.Database.Connection.Close();
            }
        }

        private void clearFormFields()
        {
            firstName_textBox.Text = "";
            lastName_textBox.Text = "";
            phoneNumber_textBox.Text = "";
        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            clearFormFields();
        }
    }
}
