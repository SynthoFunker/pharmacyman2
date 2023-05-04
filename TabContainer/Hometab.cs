using Dapper;
using pharmacyp.CrudHelper;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace pharmacyp.TabContainer
{
    public partial class Hometab : UserControl
    {
        public Hometab()
        {
            this.InitializeComponent();
            this.Loadgraph();
        }

        public void Loadgraph()
        {
            IDataReader reader = DataAccess.Conn("PharDCS").ExecuteReader("SELECT m.MName, s.MQuantity FROM Medication m Inner JOIN Medicine_Stock s ON m.MedicationID = s.MedicationID");
            int i = 0;
            while (reader.Read())
            {
                string mName = reader["MName"].ToString();
                int mQuantity = Convert.ToInt32(reader["MQuantity"]);

                QuantityChart.Series["Quantity"].Points.AddXY(mName, mQuantity);

                Color color = Color.Green;
                if (mQuantity <= 3)
                {
                    color = Color.Red;
                }
                else if (mQuantity <= 5)
                {
                    color = Color.Orange;
                }
                else if (mQuantity <= 10)
                {
                    color = Color.Yellow;
                }

                QuantityChart.Series["Quantity"].Points[i].Color = color;
                i++;
            }
        }
    }
}