Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.DashboardCommon
Imports DevExpress.XtraEditors

Namespace WinViewer_MutualDefaultFiltering
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            dashboardViewer1.SetMasterFilter("cardDashboardItem1", New List(Of Object)() From {"UK"})
        End Sub

        Private Sub dashboardViewer1_MasterFilterDefaultValues(ByVal sender As Object, _
                                                               ByVal e As MasterFilterDefaultValuesEventArgs) _
                                                           Handles dashboardViewer1.MasterFilterDefaultValues
            If e.ItemComponentName = "gridDashboardItem1" Then
                e.FilterValues = e.AvailableFilterValues.Where(Function(v) CStr(v("CategoryName")) = "Beverages" _
                                                                   OrElse CStr(v("CategoryName")) = "Condiments")
            End If

            ' Use the SetMasterFilter method instead of the code below as a workaround to 
            ' apply filtering to the 'cardDashboardItem1'.
            'if (e.ItemComponentName == "cardDashboardItem1")
            '    e.FilterValues = e.AvailableFilterValues.Where(v => (string)v["Country"] == "UK");
        End Sub
    End Class
End Namespace
