// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography.X509Certificates;


namespace ContactT
{
    internal class Program
    {
        private static FilterContact con = new FilterContact();
        static string Path= @"C:\Users\hp\source\repos\ContactT\ContactT\ToDoOutput.txt";

         static async Task Main (string[] args)
        {
            #region Contact
            //    seedDatabase();
            //    Console.WriteLine("Look at Menu below and choose operation :");
            //    Console.WriteLine("1-Display by Number:");
            //    Console.WriteLine("2-Add contat :");
            //    Console.WriteLine("3-Find by Name :");
            //    Console.WriteLine("4-View all contacts :");
            //    int a = int.Parse(Console.ReadLine());
            //    switch (a)
            //    {
            //        case 1:
            //            Console.WriteLine("please add number:");
            //            string b = Console.ReadLine();
            //            Console.WriteLine(con.DisplayByNumber(b).ToString());
            //            break;
            //        case 2:
            //            CreateContact();

            //            break;
            //        case 3:
            //            Console.WriteLine("pls add  name :");
            //            string name = Console.ReadLine();
            //            SearchByName(name);
            //            break;
            //        default:
            //            break;
            //        case 4:
            //            Console.WriteLine("All Contact");
            //            con.ViewAllContact();
            //            break;
            //    }

            //}


            //private static void seedDatabase()
            //{
            //    var cont = new Contact("Ruslan", "444-44-44");
            //    var cont1 = new Contact("Ruslan", "555-44-44");
            //    var cont2 = new Contact("Jale", "222-44-44");
            //    var cont3 = new Contact("Fidan", "444-11-44");

            //    con.AddNumber(cont);
            //    con.AddNumber(cont1);
            //    con.AddNumber(cont2);
            //    con.AddNumber(cont3);
            //}
            //private static void SearchByName(string name)
            //{
            //    List<Contact> con1 = con.FilterByName(name);
            //    foreach (Contact item in con1)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //}


            //public static Contact CreateContact()
            //{
            //    Console.WriteLine("Name of the contact: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Number of the contact:");
            //    string number = Console.ReadLine();
            //    Contact contact = new Contact(name, number);
            //    con.AddNumber(contact);
            //    Console.WriteLine(con.DisplayByNumber(contact.number).ToString());
            //    return contact;
            #endregion


            #region UrlFile.Path
            //Console.WriteLine("Please enter the url you want");
            //string url=Console.ReadLine();
            //var awaiter = await GetAsync(url);
            // if(awaiter != null)
            //{
            //    await File.WriteAllTextAsync(Path, awaiter.ToString());
            //}
            //Console.WriteLine("Press X to Exit");
            //Console.ReadKey();
            #endregion
            #region Student
            //Student student = new Student(1,"Fidan","IT","Ehmedova",18);
            //Student student1 = new Student(2, "Jale", "IT", "Qasimzade", 19);
            //Student student2= new Student(3, "Gunay", "IT", "Asgarkhanli", 19);
            //Student student3 = new Student(4, "Samire", "IT", "Babayeva", 24);
            //List<Student> stu = new List<Student>();
            //stu.Add(student1);
            //stu.Add(student2);
            //stu.Add(student3);
            //stu.Add(student);
            //foreach(Student i in stu)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Deposit
            //Console.WriteLine("Enter amount:");
            //decimal amount=Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Enter year:");
            //int year=Convert.ToInt32(Console.ReadLine());
            //int interestPersecent = 6;
            //decimal firstYear = year * ((amount * interestPersecent) / 100) + amount;
            //Console.WriteLine(firstYear);
            #endregion
           

            
            Console.WriteLine("Enter your username:");
            string usernamee=Console.ReadLine();
            Console.WriteLine("Enter your password");
            string passwordd=Console.ReadLine();
            
                if (usernamee =="SevdaAliyeva" && passwordd == "Sevda123")
                {
                    Console.WriteLine("Successfully logged");
                }
                else
                {
                    Console.WriteLine("Forgot password?");
                if (Console.ReadLine() == "yes")
                {
                    Console.WriteLine("Change your password");
                }

            }

            }


        }

        #region UrlFile.Path2
        //public static async Task <string> GetAsync(string url)
        //{
        //    using var client = new HttpClient();
        //    var stringResult = await client.GetStringAsync(url);
        //    return stringResult;

        //}
        #endregion

    }
}
