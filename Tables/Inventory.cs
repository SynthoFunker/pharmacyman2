using System;

namespace pharmacyp.Tables
{
    internal class Inventory
    {
        public int MedicationID { get; set; }
        public string Barcode { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int iQuantity { get; set; }
    }
}
