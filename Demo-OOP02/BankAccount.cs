using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP02
{

    #region Fields
    /*
    internal class BankAccount
    {


        private int _AccountNumber;
        private decimal _Balance;
        private string _Name;
        #endregion

        #region Encapsulation Using Getter , Setter 

        /*
            public decimal GetBalance() //Read
            {
                return _Balance;
            }
            public void setBalance(decimal balance) //write 
            {
                if (balance < 0)
                { Console.WriteLine("Cannot be Neg!");
                    return;
                }
                _Balance = balance;

            }
            public int GetAccountNumber() // Read only 
            {
                return _AccountNumber;
            }
            public void setName(string name) //write only
            {
                _Name = name; 
            }
      

    #endregion

    #region Encapsulation Using Property
    /*
   public string Name
    {
        get { return _Name; } //Read 

        set {
            if (string.IsNullOrWhiteSpace(value) )
          {
     Console.WriteLine("Cannot be Null and Cannot be whitespace");
                return;
          }
    _Name = value; 
    }

    }
    */
    #endregion

    #region Read and Write Property
    /*
    public int AccountNumber
    {
        get { return _AccountNumber; }
        set { _AccountNumber = value; }
    }
    */
    #endregion

    #region Read only 
    /*
    public decimal Balance
    {
        get { return _Balance; }
    }
    */
    #endregion

    #region Write Only
    /*
   public string Name
    {
       set { _Name = value; }
    }
    */

    #endregion

    #region Property With Private Setter
    // public int Pin { get; private set; }

    #endregion

    #region Computed Property
    /*
    public bool HasBalance
    {
        get { return _Balance == 0; }
    }
    */
    #endregion

    #region Init Property

    //    public int pin { get; init; }
    #endregion
//}


}
