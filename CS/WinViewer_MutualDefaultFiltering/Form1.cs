using System.Collections.Generic;
using System.Linq;
using DevExpress.DashboardCommon;
using DevExpress.XtraEditors;

namespace WinViewer_MutualDefaultFiltering {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();  
            dashboardViewer1.SetMasterFilter("cardDashboardItem1", new List<object>() { "UK" });
        }

        private void dashboardViewer1_MasterFilterDefaultValues(object sender, MasterFilterDefaultValuesEventArgs e) {
            if (e.ItemComponentName == "gridDashboardItem1") {
                e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["CategoryName"] == "Beverages" ||
                    (string)v["CategoryName"] == "Condiments");
            }

            // Use the SetMasterFilter method instead of the code below as a workaround to 
            // apply filtering to the 'cardDashboardItem1'.
            //if (e.ItemComponentName == "cardDashboardItem1")
            //    e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["Country"] == "UK");
        }
    }
}
