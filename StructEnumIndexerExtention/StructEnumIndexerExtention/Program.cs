using System;
using System.Net.Mail;

namespace StructEnumIndexerExtention
{
    class Program
    {
        public enum Weekday { Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday};
        public enum Error { NotFound=404,Server=500,Ok=200 }
        static void Main(string[] args)
        {
            #region Homework
            //Person aga = new Person("Aga", "gg", 25);
            //Person orkhan = new Person("Orkhan", "gg", 19);
            //Person tebriz = new Person("Tebriz", "ff", 22);


            //Person[] arr = { aga, orkhan, tebriz };

            //Array.Sort(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int n = 0; n < arr.Length; n++)
            //    {
            //        if (i != n && arr[i] < arr[n])
            //        {
            //            Person temp = arr[i];
            //            arr[i] = arr[n];
            //            arr[n] = temp;
            //        }
            //    }
            //}

            //foreach (Person item in arr)
            //{
            //    Console.WriteLine(item.Name+"-"+item.Age);
            //}
            #endregion

            #region Struct - value
            //Area area1 = new Area(10,100,1);
            //area1.X = 10;
            //area1.Y = 100;
            //Area area2;
            //area2.Z = 10;
            #endregion

            #region Enum
            //int day = 2;
            //switch (day)
            //{
            //    case (int)Weekday.Monday:
            //        Console.WriteLine("Monday");
            //        break;
            //    case (int)Weekday.Tuesday:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case (int)Weekday.Wednesday:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    default:
            //        Console.WriteLine("other weekday");
            //        break;
            //}
            //foreach (var item in Enum.GetValues(typeof(Weekday)))
            //{
            //    Console.WriteLine((int)item);
            //}
            #endregion

            #region Indexer
            //Book b1 = new Book("Sefiller",50);
            //Book b2 = new Book("Xemse", 150);

            //Library library = new Library("Libraff");
            //library[0] = b1;
            //library[101] = b2;
            //Console.WriteLine(library[0]);

            //string word = "Ferid";
            //Console.WriteLine(word[0]);
            #endregion

            #region Extention
            string email = "ferid@";
            Console.WriteLine(email.IsMail());

            int a = 5;
            Console.WriteLine(a.GetPower(2));

            int[] arr = { 1, 2, 3, 4 };

            arr.AddItem(5);

            foreach (var item in arr.AddItem(5))
            {
                Console.WriteLine(item);
            }
            #endregion


        }

        
    }

    #region Indexer
    class Library
    {
        public string Name { get; set; }
        private Book[] books;
        public Library(string name)
        {
            Name = name;
            books = new Book[100];
        }

        public Book this[int index]
        {
            get
            {
                try
                {
                    return books[index];
                }
                catch (Exception)
                {
                    return books[0];
                }
            }
            set
            {
                try
                {
                    books[index] = value;
                }
                catch (Exception)
                {
                    Console.WriteLine($"{index}-ci index movcud deyil");
                }
            }
        }
    }
    class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Book(string name,double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name+"-"+Price+" manat";
        }
    }
    #endregion

    #region Struct - value
    //interface ITest
    //{

    //}
    //struct Area: ITest
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //    public int Z;
    //    //parametrless ctor can't override!!!
    //    //in ctor must be set all property,field and can't be parametrless
    //    public Area(int x,int y,int z)
    //    {
    //        X = x;
    //        Y = y;
    //        Z = z;
    //    }
    //}
    #endregion

    #region Homework
    //class Person :IComparable
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public int Age { get; set; }

    //    public Person()
    //    {

    //    }
    //    public Person(string name, string surname, int age)
    //    {
    //        Name = name;
    //        Surname = surname;
    //        Age = age;
    //    }

    //    public static bool operator > (Person google, Person facebook)
    //    {
    //        return google.Age > facebook.Age; 
    //    }

    //    public static bool operator < (Person p1, Person p2)
    //    {
    //        return p1.Age < p2.Age;
    //    }

    //    public int CompareTo(object obj)
    //    {
    //        return Age.CompareTo(((Person)obj).Age);
    //    }
    //}
    #endregion
}
