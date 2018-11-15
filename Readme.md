<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinViewer_MutualDefaultFiltering/Form1.cs) (VB: [Form1.vb](./VB/WinViewer_MutualDefaultFiltering/Form1.vb))
<!-- default file list end -->
# Win Viewer - How to apply default filtering to master filter items that affect each other


The DashboardViewer control allows you to apply default filtering using the following events

* <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_MasterFilterDefaultValuestopic">MasterFilterDefaultValues</a>.
* <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_RangeFilterDefaultValuetopic">RangeFilterDefaultValue</a>.<br>- <strong>FilterElementDefaultValues</strong> (v16.1 and earlier).
* <strong>SingleFilterDefaultValue</strong> (v16.1 and earlier).<br>If your dashboard contains several master filter items that affect each other, filtering may not be applied to some items due to architectural limitations of DevExpress Dashboard. Let's consider the following scenario: a dashboard contains the Grid and Card dashboard items that affect each other. If you handle the MasterFilterDefaultValues event for both items, filtering will not be applied to the <em>Extended Price</em> column of Grid 1:<br><strong>code:</strong><br>


```cs
        private void dashboardViewer1_MasterFilterDefaultValues(object sender, MasterFilterDefaultValuesEventArgs e) {
            if (e.ItemComponentName == "gridDashboardItem1")
                e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["CategoryName"] == "Beverages" || (string)v["CategoryName"] == "Condiments");
            if (e.ItemComponentName == "cardDashboardItem1")
                e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["Country"] == "UK");
        }
```


 <strong>result:</strong><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/win-viewer-how-to-apply-default-filtering-to-master-filter-items-that-affect-each-other-t474844/16.2.3+/media/43572027-e15b-11e6-80bf-00155d62480c.png"><br><br><br>As a workaround, you need to call the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_SetMasterFiltertopic">SetMasterFilter</a> method for Cards 1. In this case, filtering will be applied correctly:<br><strong>code:</strong><br>


```cs
dashboardViewer1.SetMasterFilter("cardDashboardItem1", new List<object>() { "UK" });

// ...
        private void dashboardViewer1_MasterFilterDefaultValues(object sender, MasterFilterDefaultValuesEventArgs e)
            if (e.ItemComponentName == "gridDashboardItem1") {
                e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["CategoryName"] == "Beverages" || (string)v["CategoryName"] == "Condiments");
        }
```


<strong>result:</strong><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/win-viewer-how-to-apply-default-filtering-to-master-filter-items-that-affect-each-other-t474844/16.2.3+/media/6014919f-e157-11e6-80bf-00155d62480c.png">

<br/>


