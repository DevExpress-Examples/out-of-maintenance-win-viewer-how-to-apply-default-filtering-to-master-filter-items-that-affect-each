Namespace MutualDefaultFiltering
    Partial Public Class Dashboard1
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
            Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim measure1 As New DevExpress.DashboardCommon.Measure()
            Dim gridMeasureColumn1 As New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim measure2 As New DevExpress.DashboardCommon.Measure()
            Dim card1 As New DevExpress.DashboardCommon.Card()
            Dim cardStretchedLayoutTemplate1 As New DevExpress.DashboardCommon.CardStretchedLayoutTemplate()
            Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
            Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            Me.dashboardExtractDataSource1 = New DevExpress.DashboardCommon.DashboardExtractDataSource()
            Me.cardDashboardItem1 = New DevExpress.DashboardCommon.CardDashboardItem()
            CType(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dashboardExtractDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' gridDashboardItem1
            ' 
            dimension1.DataMember = "CategoryName"
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridDimensionColumn1.AddDataItem("Dimension", dimension1)
            measure1.DataMember = "ExtendedPrice"
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridMeasureColumn1.AddDataItem("Measure", measure1)
            Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridMeasureColumn1})
            Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
            Me.gridDashboardItem1.DataItemRepository.Clear()
            Me.gridDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
            Me.gridDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
            Me.gridDashboardItem1.DataSource = Me.dashboardExtractDataSource1
            Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.gridDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.gridDashboardItem1.Name = "Grid 1"
            Me.gridDashboardItem1.ShowCaption = True
            ' 
            ' dashboardExtractDataSource1
            ' 
            Me.dashboardExtractDataSource1.ComponentName = "dashboardExtractDataSource1"
            Me.dashboardExtractDataSource1.FileName = "C:\Data\NWind_SalesPerson.dat"
            Me.dashboardExtractDataSource1.Name = "Extract Data Source 1"
            ' 
            ' cardDashboardItem1
            ' 
            measure2.DataMember = "ExtendedPrice"
            cardStretchedLayoutTemplate1.BottomValue1.DimensionIndex = 0
            cardStretchedLayoutTemplate1.BottomValue1.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.PercentVariation
            cardStretchedLayoutTemplate1.BottomValue1.Visible = True
            cardStretchedLayoutTemplate1.BottomValue2.DimensionIndex = 0
            cardStretchedLayoutTemplate1.BottomValue2.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.AbsoluteVariation
            cardStretchedLayoutTemplate1.BottomValue2.Visible = True
            cardStretchedLayoutTemplate1.DeltaIndicator.Visible = True
            cardStretchedLayoutTemplate1.MainValue.DimensionIndex = 0
            cardStretchedLayoutTemplate1.MainValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Title
            cardStretchedLayoutTemplate1.MainValue.Visible = True
            cardStretchedLayoutTemplate1.Sparkline.Visible = True
            cardStretchedLayoutTemplate1.SubValue.DimensionIndex = 0
            cardStretchedLayoutTemplate1.SubValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.Subtitle
            cardStretchedLayoutTemplate1.SubValue.Visible = True
            cardStretchedLayoutTemplate1.TopValue.DimensionIndex = 0
            cardStretchedLayoutTemplate1.TopValue.ValueType = DevExpress.DashboardCommon.CardRowDataElementType.ActualValue
            cardStretchedLayoutTemplate1.TopValue.Visible = True
            card1.LayoutTemplate = cardStretchedLayoutTemplate1
            card1.AddDataItem("ActualValue", measure2)
            Me.cardDashboardItem1.Cards.AddRange(New DevExpress.DashboardCommon.Card() { card1})
            Me.cardDashboardItem1.ComponentName = "cardDashboardItem1"
            dimension2.DataMember = "Country"
            Me.cardDashboardItem1.DataItemRepository.Clear()
            Me.cardDashboardItem1.DataItemRepository.Add(measure2, "DataItem0")
            Me.cardDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1")
            Me.cardDashboardItem1.DataSource = Me.dashboardExtractDataSource1
            Me.cardDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.cardDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
            Me.cardDashboardItem1.Name = "Cards 1"
            Me.cardDashboardItem1.SeriesDimensions.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
            Me.cardDashboardItem1.ShowCaption = True
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardExtractDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.gridDashboardItem1, Me.cardDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.gridDashboardItem1
            dashboardLayoutItem1.Weight = 50R
            dashboardLayoutItem2.DashboardItem = Me.cardDashboardItem1
            dashboardLayoutItem2.Weight = 50R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
            dashboardLayoutGroup1.DashboardItem = Nothing
            dashboardLayoutGroup1.Weight = 100R
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dashboardExtractDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(measure2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cardDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private dashboardExtractDataSource1 As DevExpress.DashboardCommon.DashboardExtractDataSource
        Private gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
        Private cardDashboardItem1 As DevExpress.DashboardCommon.CardDashboardItem
    End Class
End Namespace
