using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutualDefaultFiltering
{
    public partial class Form1 : XtraForm
    {
        public bool isNeutralFilterMode;
        public Form1()
        {
            InitializeComponent();
            // Enable or disable the Neutral Filter mode.
            dashboardViewer1.UseNeutralFilterMode = true;

            dashboardViewer1.ConfigureDataConnection += DashboardViewer1_ConfigureDataConnection;
            dashboardViewer1.MasterFilterDefaultValues += DashboardViewer1_MasterFilterDefaultValues;
            // Set the flag for subsequent use. 
            isNeutralFilterMode = dashboardViewer1.UseNeutralFilterMode;

            // Load a dashboard after the UseNeutralFilterMode property changes.
            dashboardViewer1.Dashboard = new Dashboard1();

            // Call the SetMasterFilter method instead of applying filter values in the MasterFilterDefaultValues event handler
            // if the Neutral Filter Mode is disabled.
            if (!isNeutralFilterMode)
                dashboardViewer1.SetMasterFilter("cardDashboardItem1", new List<object>() { "UK" });
        }

        private void DashboardViewer1_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e)
        {
            ExtractDataSourceConnectionParameters connParameters = e.ConnectionParameters as ExtractDataSourceConnectionParameters;
            connParameters.FileName = "NWind_SalesPerson.dat";
        }

        private void DashboardViewer1_MasterFilterDefaultValues(object sender, MasterFilterDefaultValuesEventArgs e)
        {
            if (e.ItemComponentName == "gridDashboardItem1")
            {
                e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["CategoryName"] == "Beverages" ||
                    (string)v["CategoryName"] == "Condiments");
            }

            if (isNeutralFilterMode)
            {
                // The SetMasterFilter method call is required in the initialization routine instead of the code below
                // if the Neutral Filter Mode is disabled.
                if (e.ItemComponentName == "cardDashboardItem1")
                    e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["Country"] == "UK");
            }
        }
    }
}
