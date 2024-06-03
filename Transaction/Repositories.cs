using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction
{
    public class Repositories
    {
        //
        public static DataClasses1DataContext db = null;

        //repositories from tbltransaction
        public static void AddTra(tblTransaction table)
        {
            db = new DataClasses1DataContext();
            db.sp_InsertTra(table.amount, table.transType, table.transDate, table.userid);
        }

        public static void UpdateTra(tblTransaction table)
        {
            db = new DataClasses1DataContext();
            db.sp_UpdateTra(table.transactionId, table.amount, table.transType, table.transDate);
        }

        public static void DeleteTra(tblTransaction table)
        {
            db = new DataClasses1DataContext();
            db.sp_DeleteTra(table.transactionId);
        }

        public static List<sp_ViewTraResult> ViewTra()
        {
            db = new DataClasses1DataContext();
            List<sp_ViewTraResult> viewTraResults = db.sp_ViewTra().ToList<sp_ViewTraResult>();
            return viewTraResults;
        }

        // add proc in tbltransaction [search]

        //repositories form user

        public static void AddUser(tblUser table)
        {
            db = new DataClasses1DataContext();
            db.sp_InsertUser(table.fname, table.lname, table.username, table.upassword, table.userpin, table.Balance);
        }

        public static void UpdateUser(tblUser table)
        {
            db = new DataClasses1DataContext();
            db.sp_UpdateUser(table.userId, table.fname, table.lname, table.username, table.upassword);
        }

        public static void DeleteUser(tblUser table)
        {
            db = new DataClasses1DataContext();
            db.sp_DeleteUser(table.userId);
        }

        public static List<sp_ViewUserResult> ViewUser()
        {
            db = new DataClasses1DataContext();
            List<sp_ViewUserResult> viewUserResults = db.sp_ViewUser().ToList<sp_ViewUserResult>();
            return viewUserResults;
        }

        //validation function
        public static bool VLogin(string username, string password)
        {
            db = new DataClasses1DataContext();
            bool result = (bool)db.ValidateLogin(username, password);
            Transac.Username = username;
            Transac.Password = password;
            return result;            
        }     

        public static int GetPin(int pin)
        {
            db = new DataClasses1DataContext();
            db.GetPin(pin);
            Transac.Pin = pin;
            return Transac.Pin = pin;
        }

        public static decimal GetBalance(int balance)
        {
            db = new DataClasses1DataContext();
            db.GetBalance(balance);
            Transac.Balance = balance;
            return Transac.Balance = balance;
        }
    }
}

