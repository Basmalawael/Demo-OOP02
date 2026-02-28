namespace Demo_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex :bank account 

            /* 
            BankAccount ba1 = new BankAccount();

            ba1.setBalance(-20);
          
            Console.WriteLine(ba1.GetBalance()); 
            //-----------------------------------------
            ba1.setBalance(2000);
          
            Console.WriteLine(ba1.GetBalance());
            //-----------------------------------------
           
            ba1.setName("lali");
        
            Console.WriteLine(ba1.GetAccountNumber());  
            */
            #endregion

            #region Encapsulation Using Property

            /*
            BankAccount ba1 = new BankAccount();
            //------------------
            ba1.Name = " ";
            Console.WriteLine(ba1.Name);
            //---------------------
            Console.WriteLine();
            //----------------------
            ba1.Name = "Hana";
            Console.WriteLine(ba1.Name);
            */
            #endregion

            #region Read and Write Property


            //    BankAccount account = new BankAccount();

            #region Read and Write Property

            // account.AccountNumber = 1; //set
            // Console.WriteLine(account.AccountNumber); //get
            #endregion

            #region Read Only

            //  Console.WriteLine(account.Balance);
            #endregion

            #endregion

            #region Auto_implement Prop


            //  public int MyProperty { get; set; }
            //---------------------------------------------

            // private int age;

            // public int Age
            //{
            //    get { return age; }
            //    set { age = value; }
            //
            // }

            #endregion

            #region Property With Private Setter

            //  account.Pin = "123"; // Error


            //   Console.WriteLine(account.Pin);   

            #endregion

            #region Computed Property

            // Console.WriteLine(account.HasBalance);
            #endregion

            #region Init Property

            //    BankAccount bank = new BankAccount() { pin = 2345 }; //set

            //    Console.WriteLine(bank.pin); // get
            #endregion

            #region  EX 1:index
            /*
            ToDoList list = new ToDoList(4);

            list[0] = "Index";
            list[1] = "Test";

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            */
            #endregion

            #region Ex 2: index
            /*
            library lib = new library("library 1");
            lib.AddBook(new Book("123-456-7789" , "C sharp"));
            lib.AddBook(new Book("678-98-87556",   "C++ "));

            Console.WriteLine(lib[0].Title);
            Console.WriteLine();

            Console.WriteLine(lib["123-456-7789"].Title); //C#
            Console.WriteLine(lib.BookCount); //2
            */
            #endregion

            #region static KeyWord
            /*
            Student s1 = new Student("Nada");
        Console.WriteLine($"After Creating Nada : TotalStudent= {Student.TotalStudent}");
            */
            #endregion

            #region Static Method
            //    Student.increment ();
            //    Student.Decrement ();

            #endregion

          


        }
    }
}
