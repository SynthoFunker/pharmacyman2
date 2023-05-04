using System;

namespace pharmacyp.Tables
{
    public class OReport
    {
        public int OrderID { get; set; }

        public string Uname { get; set; }

        public DateTime OrderDate { get; set; }

        public int TotalSales { get; set; }

        public string MName { get; set; }

        public int olQuantity { get; set; }

        public int Sell { get; set; }

        public string OBarcode { get; set; }

        public byte[] BImage { get; set; }

        public int Total { get { return olQuantity * Sell; } }
    }
}
