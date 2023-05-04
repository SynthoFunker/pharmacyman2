using Dapper;
using pharmacyp.Tables;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace pharmacyp.CrudHelper
{
    public static class DataAccess
    {

        public static string Cons(string cname)
        {
            return ConfigurationManager.ConnectionStrings[cname].ConnectionString.ToString();
        }

        public static OleDbConnection Conn(string cname)
        {
            OleDbConnection con = new OleDbConnection(Cons(cname));
            return con;
        }

        public static DataTable LoadRHistory(string barcode)
        {
            using (OleDbConnection con = new OleDbConnection(Cons("PharDCS")))
            {
                IDataReader re = con.ExecuteReader("SELECT mOrder.OrderID, mOrder.OrderDate, mUser.Uname, mOrder.OBarcode " +
                    "FROM mUser INNER JOIN mOrder ON mUser.UserID = mOrder.UserID where Obarcode = @bcode;", new { Bcode = barcode});
                DataTable dt = new DataTable();
                dt.Load(re);
                return dt;
            }
        }

        public static DataTable LoadRHistory()
        {
            using (OleDbConnection con = new OleDbConnection(Cons("PharDCS")))
            {
                IDataReader re = con.ExecuteReader("SELECT mOrder.OrderID, mOrder.OrderDate, mUser.Uname, mOrder.OBarcode FROM mUser INNER JOIN mOrder ON mUser.UserID = mOrder.UserID;");
                DataTable dt = new DataTable();
                dt.Load(re);
                return dt;
            }
        }

        public static DataTable LoadRReceipt(int orderID)
        {
            using (OleDbConnection con = new OleDbConnection(Cons("PharDCS")))
            {
                IDataReader re = con.ExecuteReader("SELECT mOrder.OrderID, mUser.Uname, Medication.MName, mOrder.olQuantity, mOrder.OBarcode, Medication.Sell " +
                    "FROM mUser INNER JOIN(Medication INNER JOIN mOrder ON Medication.MedicationID = mOrder.MedicationID) ON mUser.UserID = mOrder.UserID " +
                    "WHERE(((mOrder.OrderID) =[@OID])); ", new { OID = orderID });

                DataTable dt = new DataTable();
                dt.Load(re);
                return dt;
            }
        }
        public static DataTable LoadStorage()
        {
            using (OleDbConnection con = new OleDbConnection(Cons("PharDCS")))
            {
                IDataReader re = con.ExecuteReader("SELECT Medication.MedicationID, Medication.MName, Medication.Description, Medication.Dosage, Medication.Cost, Medication.Sell, Medication.Company, Medication.Barcode, Medication.ExpiryDate, Medicine_Stock.SQuantity, Medicine_Stock.MQuantity, Medicine_Stock.TotalQ FROM (Medication INNER JOIN Medicine_Stock ON Medication.MedicationID = Medicine_Stock.MedicationID; ");
                DataTable dt = new DataTable();
                dt.Load(re);
                return dt;
            }
        }

        public static List<OReport> GetSalesData()
        {
            using (OleDbConnection con = new OleDbConnection(Cons("PharDCS")))
            {
                List<OReport> dt = con.Query<OReport>("SELECT mUser.Uname, mOrder.OrderDate, Sum(mOrder.olQuantity * Medication.Sell) AS TotalSales " +
                       "FROM ((mOrder INNER JOIN Medication ON mOrder.MedicationID = Medication.MedicationID) " +
                       "INNER JOIN mUser ON mOrder.UserID = mUser.UserID) " +
                       "GROUP BY mUser.Uname, mOrder.OrderDate " +
                       "ORDER BY mOrder.OrderDate;").AsList();
                return dt;
            }
        }
    }
}