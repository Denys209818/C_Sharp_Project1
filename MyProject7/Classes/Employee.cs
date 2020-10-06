using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace MyProject7.Classes
{
    class Employee
    {
        public static HybridDictionary journal;
        private string name;
        private string surname;
        private string state;
        private short salary;
        private string idDocument;

        static Employee()
        {
            Employee.journal = new HybridDictionary();
            Console.WriteLine("Журнал створено!");
            Console.ReadKey();
        }

        public Employee(string name, string surname, string state, int salary, string idDocument)
        {
            char[] arr = new char[] { ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '!', ',', '?' };
            bool error = false;

            this.name = name;
            this.surname = surname;

           while (!error) 
        {
                Console.Clear();
                error = true;
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (this.name.Contains(arr[i]))
                    {
                        throw new NameException();
                    }
                }

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (this.surname.Contains(arr[i]))
                        {
                            throw new SurnameException();
                        }
                    }
                }
            catch (NameException ex)
            {
                    Console.WriteLine(ex.Message);
                    error = false;
                    Console.ReadKey();
                    Console.Clear();

                    Console.Write("Введіть нове ім'я - ");
                    this.name = Console.ReadLine();
            }
            catch (SurnameException ex)
            {
                    Console.WriteLine(ex.Message);
                    error = false;
                    Console.ReadKey();
                    Console.Clear();

                    Console.Write("Введіть нове прізвище - ");
                    this.surname = Console.ReadLine();
            }
        }
            
            this.state = state;
            error = false;
            while (!error) 
            {
                error = true;
                Console.Clear();
                try
                {
                    this.salary = (short)salary;
                } 
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message + "\nТисніть ентер");
                    Console.ReadKey();
                    Console.Clear();
                    error = false;
                    Console.Write("Введіть інше число");
                    short s = this.salary;
                    try
                    {
                        this.salary = short.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        this.salary = s;
                    }
                }
            }

            this.idDocument = idDocument;

            Employee.journal.Add(this.idDocument, this);
            Console.WriteLine($"особу {this.name} створено та добавлено до журналу!");
            Console.ReadKey();
        }

        public void ShowEmployeeData() 
        {
            Console.WriteLine("Employee Info");
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Surname: " + this.surname);
            Console.WriteLine("State: " + this.state);
            Console.WriteLine("Salary: " + this.salary);
            Console.WriteLine("Id Document: " + this.idDocument);
            Console.WriteLine("***\n\n");
        }

        public string Name 
        {
            get => this.name;
            set 
            {
                this.name = value;
            } 
        }

        public string Surname
        {
            get => this.surname;
            set
            {
                this.surname = value;
            }
        }

        public string State
        {
            get => this.state;
            set
            {
                this.state = value;
            }
        }

        public short Salary
        {
            get => this.salary;
            set
            {
                this.salary = value;
            }
        }

        public string Document
        {
            get => this.idDocument;
            set
            {
                this.idDocument = value;
            }
        }

        public static void ShowMyJournal() 
        {
            Console.Clear();
            Console.WriteLine("Вміст журналу працівників");
            foreach (var item in Employee.journal.Values) 
            {
                Console.WriteLine("\n***");
                if (item is Employee) 
                {
                ((Employee)item).ShowEmployeeData();
                }
                Console.WriteLine("***\n");

            }
        }

        public static void DeleteFromJournal() 
        {
            Employee.ShowMyJournal();
            string code = "";
            Console.WriteLine("Запам'ятайте індекс і нажміть любу клавішу");
            Console.ReadKey();
            code = Console.ReadLine();

            try
            {
                if (!Employee.journal.Contains(code))
                {
                    throw new Exception("Не існує особи!");
                }
                Employee.journal.Remove(code);
            } 
            catch (Exception ex) 
            {
                if (Employee.journal.Count == 0) 
                {
                    Console.WriteLine("Масив пустий!");
                    return;
                }
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }


    class NameException : ApplicationException
    {
        public override string Message => "Некоректний символ в імені!\n Тисніть ентер";
    }

    class SurnameException : ApplicationException
    {
        public override string Message => "Некоректний символ в прізвищі!\n Тисніть ентер";
    }
}
