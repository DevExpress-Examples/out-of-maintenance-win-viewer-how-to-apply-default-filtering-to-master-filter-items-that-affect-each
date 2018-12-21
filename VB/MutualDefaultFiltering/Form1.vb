Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace MutualDefaultFiltering
    Partial Public Class Form1
        Inherits XtraForm

        Public isNeutralFilterMode As Boolean
        Public Sub New()
            InitializeComponent()
            ' Enable or disable the Neutral Filter mode.
            dashboardViewer1.UseNeutralFilterMode = True

            AddHandler dashboardViewer1.ConfigureDataConnection, AddressOf DashboardViewer1_ConfigureDataConnection
            AddHandler dashboardViewer1.MasterFilterDefaultValues, AddressOf DashboardViewer1_MasterFilterDefaultValues
            ' Set the flag for subsequent use. 
            isNeutralFilterMode = dashboardViewer1.UseNeutralFilterMode

            ' Load a dashboard after the UseNeutralFilterMode property changes.
            dashboardViewer1.Dashboard = New Dashboard1()

            ' Call the SetMasterFilter method instead of applying filter values in the MasterFilterDefaultValues event handler
            ' if the Neutral Filter Mode is disabled.
            If Not isNeutralFilterMode Then
                dashboardViewer1.SetMasterFilter("cardDashboardItem1", New List(Of Object)() From {"UK"})
            End If
        End Sub

        Private Sub DashboardViewer1_ConfigureDataConnection(ByVal sender As Object, ByVal e As DashboardConfigureDataConnectionEventArgs)
            Dim connParameters As ExtractDataSourceConnectionParameters = TryCast(e.ConnectionParameters, ExtractDataSourceConnectionParameters)
            connParameters.FileName = "NWind_SalesPerson.dat"
        End Sub

        Private Sub DashboardViewer1_MasterFilterDefaultValues(ByVal sender As Object, ByVal e As MasterFilterDefaultValuesEventArgs)
            If e.ItemComponentName = "gridDashboardItem1" Then
                e.FilterValues = e.AvailableFilterValues.Where(Function(v) CStr(v("CategoryName")) = "Beverages" OrElse CStr(v("CategoryName")) = "Condiments")
            End If

            If isNeutralFilterMode Then
                ' The SetMasterFilter method call is required in the initialization routine instead of the code below
                ' if the Neutral Filter Mode is disabled.
                If e.ItemComponentName = "cardDashboardItem1" Then
                    e.FilterValues = e.AvailableFilterValues.Where(Function(v) CStr(v("Country")) = "UK")
                End If
            End If
        End Sub
    End Class
End Namespace
