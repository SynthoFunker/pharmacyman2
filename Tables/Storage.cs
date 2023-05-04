using System;

namespace pharmacyp.Tables
{
    public class Storage
    {
        public int MedicationID { get; set; }

        public string MName { get; set; }

        public string Description { get; set; }

        public string Dosage { get; set; }

        public int Cost { get; set; }

        public int Sell { get; set; }

        public string Company { get; set; }

        public string Barcode { get; set; }

        public DateTime ExpiryDate { get; set; }

        public int SQuantity { get; set; }

        public int MQuantity { get; set; }

        public int TotalQ { get; set; }
    }
}
