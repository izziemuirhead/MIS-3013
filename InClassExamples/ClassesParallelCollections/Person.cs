using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParallelCollections
{
    public class Person
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string DOB { get; set; }
        public string favoriteFoods { get; set; }

        public double acctBal { get; set; }


        //THIS IS ESSENTIALLY WHAT THE GET/SET IS DOING

       // public void setAcctBal(double val)
       // {
       //
       //    acctBal = 800;
       //
       // }

        // public double getAcctBal()
        // {
        //
        //   return acctBal;
        // }


        public Person()
        {
            fName = string.Empty;
            lName = string.Empty;
            DOB = string.Empty;
            favoriteFoods = string.Empty;
            acctBal = 0;
        }

        public Person(string FirstName, string LastName, string DateOfBirth, string FavoriteFood, double AcctBalance)
        {

            fName = FirstName;
            lName = LastName;
            DOB = DateOfBirth;
            favoriteFoods = FavoriteFood;
            acctBal = AcctBalance;

        }

        public override string ToString()
        {
            string output = $"{fName} {lName} {DOB} likes {favoriteFoods} and has {acctBal.ToString("C")}";
            return output;
        }

    }
}
