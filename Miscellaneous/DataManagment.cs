using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace pharmacyp.Miscellaneous
{
    public class DataManagement
    {
        public delegate void DataUpdatedEventHandler(PharDDataSet dataSet);
        public event DataUpdatedEventHandler DataUpdated;

        private PharDDataSet dataSet;
        private SqlDataAdapter dataAdapter;
        private Timer refreshTimer;

        public DataManagement()
        {
            dataSet = new PharDDataSet();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Customers", "Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;");
            dataAdapter.Fill(dataSet, "Customers");

            refreshTimer = new Timer(1000);// 1 second
            refreshTimer.Elapsed += RefreshTimer_Elapsed;
            refreshTimer.Start();
        }
        private void RefreshTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // fill the dataset with the latest data from the original data source
            dataSet.Clear();
            dataAdapter.Fill(dataSet, "Customers");

            // notify subscribers that new data is available
            DataUpdated?.Invoke(dataSet);
        }
        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            // fill the dataset with the latest data from the original data source
            dataSet.Clear();
            dataAdapter.Fill(dataSet, "Customers");

            // notify subscribers that new data is available
            if (DataUpdated != null)
                DataUpdated(dataSet);
        }
    }
}
