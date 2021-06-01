<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/MutualDefaultFiltering/Form1.cs) (VB: [Form1.vb](./VB/MutualDefaultFiltering/Form1.vb))
<!-- default file list end -->
# How to Apply Default Filtering to Master Filter Items that Affect Each Other


The following Dashboard Viewer events allow you to apply default master filtering: 

* [MasterFilterDefaultValues](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.MasterFilterDefaultValues)
* [RangeFilterDefaultValue](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.RangeFilterDefaultValue)

> If the [Neutral Filter mode](https://docs.devexpress.com/Dashboard/400262/main-features/interactivity/neutral-filter-mode) is enabled, master filters apply as expected and the workaround described in this document is not relevant.

If your dashboard contains several **master filter** items that **affect each other** and the Neutral Filter mode is **disabled**, default filter values may not be applied to some items due to technical limitations. Consider the following scenario: a dashboard contains the Grid and Card dashboard items that affect each other. If you handle the MasterFilterDefaultValues event for both items, filtering is not applied to the grid's _Extended Price_ column.

**code:**


```cs
        private void dashboardViewer1_MasterFilterDefaultValues(object sender, MasterFilterDefaultValuesEventArgs e) {
            if (e.ItemComponentName == "gridDashboardItem1")
                e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["CategoryName"] == "Beverages" || (string)v["CategoryName"] == "Condiments");
            if (e.ItemComponentName == "cardDashboardItem1")
                e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["Country"] == "UK");
        }
```

**result:**

![](https://raw.githubusercontent.com/DevExpress-Examples/win-viewer-how-to-apply-default-filtering-to-master-filter-items-that-affect-each-other-t474844/16.2.3+/media/43572027-e15b-11e6-80bf-00155d62480c.png)

To remedy the situation, call the [SetMasterFilter](https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_SetMasterFiltertopic) method to apply a filter to the _Cards 1_ item:

**code:**

```cs
dashboardViewer1.SetMasterFilter("cardDashboardItem1", new List<object>() { "UK" });

// ...
        private void dashboardViewer1_MasterFilterDefaultValues(object sender, MasterFilterDefaultValuesEventArgs e)
            if (e.ItemComponentName == "gridDashboardItem1") {
                e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["CategoryName"] == "Beverages" || (string)v["CategoryName"] == "Condiments");
        }
```


**result:**

![](https://raw.githubusercontent.com/DevExpress-Examples/win-viewer-how-to-apply-default-filtering-to-master-filter-items-that-affect-each-other-t474844/16.2.3+/media/6014919f-e157-11e6-80bf-00155d62480c.png)

## Documentation

- [Master Filtering](https://docs.devexpress.com/Dashboard/116912)

## More Examples 

- [How to Initialize Master Filters in Dashboard Viewer](https://github.com/DevExpress-Examples/how-to-apply-default-filtering-to-master-filters-in-dashboardviewer-t329583)
- [How to Set Master Filter in Dashboard Viewer](https://github.com/DevExpress-Examples/how-to-apply-master-filtering-in-dashboardviewer-e5097)

