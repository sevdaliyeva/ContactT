using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactT
{
    public class FilterContact
    {
        List<Contact> contacts =new List<Contact>();
        public Contact DisplayByNumber(string number) { 
            return contacts.Where(c => number == number).FirstOrDefault();
        }
        public void AddNumber(Contact contact) { 
            contacts.Add(contact);
        }
        public List<Contact> FilterByName(string name) { return contacts.Where(c => c.name == name).ToList(); }
        public void ViewAllContact()
        {
           
            if (contacts != null && contacts.Count != 0)
            {
                foreach (Contact item in contacts)
                {
                    Console.WriteLine(item.ToString());
                }

            }


        }
    
        }

    }

