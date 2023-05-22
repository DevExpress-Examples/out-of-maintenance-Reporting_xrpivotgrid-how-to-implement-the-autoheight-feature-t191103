Namespace WindowsFormsApplication1

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim msSqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
            Dim tableQuery1 As DevExpress.DataAccess.Sql.TableQuery = New DevExpress.DataAccess.Sql.TableQuery()
            Dim relationInfo1 As DevExpress.DataAccess.Sql.RelationInfo = New DevExpress.DataAccess.Sql.RelationInfo()
            Dim relationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim tableInfo1 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableInfo2 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo5 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo6 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WindowsFormsApplication1.XtraReport1))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
            Me.fieldProductName1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldUnitPrice1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldUnitsInStock1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldUnitsOnOrder1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldCategoryName1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldDescription1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.HeightF = 0F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 48.33333F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 50F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "logachev-nb-w8.Northwind.dbo"
            msSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows
            msSqlConnectionParameters1.DatabaseName = "Northwind"
            msSqlConnectionParameters1.Password = Nothing
            msSqlConnectionParameters1.ServerName = "(local)"
            msSqlConnectionParameters1.UserName = Nothing
            Me.sqlDataSource1.ConnectionParameters = msSqlConnectionParameters1
            tableQuery1.Name = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            relationInfo1.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() {relationColumnInfo1})
            relationInfo1.NestedTable = "Categories"
            relationInfo1.ParentTable = "Products"
            tableQuery1.Relations.AddRange(New DevExpress.DataAccess.Sql.RelationInfo() {relationInfo1})
            tableInfo1.Name = "Products"
            columnInfo1.Name = "ProductName"
            columnInfo2.Name = "UnitPrice"
            columnInfo3.Name = "UnitsInStock"
            columnInfo4.Name = "UnitsOnOrder"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {columnInfo1, columnInfo2, columnInfo3, columnInfo4})
            tableInfo2.Name = "Categories"
            columnInfo5.Name = "CategoryName"
            columnInfo6.Name = "Description"
            tableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {columnInfo5, columnInfo6})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() {tableInfo1, tableInfo2})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {tableQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' reportHeaderBand1
            ' 
            Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPivotGrid1})
            Me.reportHeaderBand1.HeightF = 125F
            Me.reportHeaderBand1.Name = "reportHeaderBand1"
            ' 
            ' xrPivotGrid1
            ' 
            Me.xrPivotGrid1.DataMember = "Products"
            Me.xrPivotGrid1.DataSource = Me.sqlDataSource1
            Me.xrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() {Me.fieldProductName1, Me.fieldUnitPrice1, Me.fieldUnitsInStock1, Me.fieldUnitsOnOrder1, Me.fieldCategoryName1, Me.fieldDescription1})
            Me.xrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrPivotGrid1.Name = "xrPivotGrid1"
            Me.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3
            Me.xrPivotGrid1.SizeF = New System.Drawing.SizeF(649.9999F, 125F)
            AddHandler Me.xrPivotGrid1.CustomRowHeight, New System.EventHandler(Of DevExpress.XtraReports.UI.PivotGrid.PivotCustomRowHeightEventArgs)(AddressOf Me.xrPivotGrid1_CustomRowHeight)
            ' 
            ' fieldProductName1
            ' 
            Me.fieldProductName1.AreaIndex = 0
            Me.fieldProductName1.Caption = "Product Name"
            Me.fieldProductName1.FieldName = "ProductName"
            Me.fieldProductName1.Name = "fieldProductName1"
            ' 
            ' fieldUnitPrice1
            ' 
            Me.fieldUnitPrice1.AreaIndex = 1
            Me.fieldUnitPrice1.Caption = "Unit Price"
            Me.fieldUnitPrice1.FieldName = "UnitPrice"
            Me.fieldUnitPrice1.Name = "fieldUnitPrice1"
            ' 
            ' fieldUnitsInStock1
            ' 
            Me.fieldUnitsInStock1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldUnitsInStock1.AreaIndex = 2
            Me.fieldUnitsInStock1.Caption = "Units In Stock"
            Me.fieldUnitsInStock1.FieldName = "UnitsInStock"
            Me.fieldUnitsInStock1.Name = "fieldUnitsInStock1"
            ' 
            ' fieldUnitsOnOrder1
            ' 
            Me.fieldUnitsOnOrder1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldUnitsOnOrder1.AreaIndex = 1
            Me.fieldUnitsOnOrder1.Caption = "Units On Order"
            Me.fieldUnitsOnOrder1.FieldName = "UnitsOnOrder"
            Me.fieldUnitsOnOrder1.Name = "fieldUnitsOnOrder1"
            ' 
            ' fieldCategoryName1
            ' 
            Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName1.AreaIndex = 0
            Me.fieldCategoryName1.Caption = "Category Name"
            Me.fieldCategoryName1.FieldName = "CategoryName"
            Me.fieldCategoryName1.Name = "fieldCategoryName1"
            ' 
            ' fieldDescription1
            ' 
            Me.fieldDescription1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.fieldDescription1.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center
            Me.fieldDescription1.Appearance.Cell.WordWrap = True
            Me.fieldDescription1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldDescription1.AreaIndex = 0
            Me.fieldDescription1.Caption = "Description"
            Me.fieldDescription1.FieldName = "Description"
            Me.fieldDescription1.Name = "fieldDescription1"
            Me.fieldDescription1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.reportHeaderBand1})
            Me.DataMember = "Products"
            Me.DataSource = Me.sqlDataSource1
            Me.Margins = New System.Drawing.Printing.Margins(100, 100, 48, 50)
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "14.1"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

'#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource

        Private reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand

        Private Title As DevExpress.XtraReports.UI.XRControlStyle

        Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle

        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle

        Private DataField As DevExpress.XtraReports.UI.XRControlStyle

        Private xrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid

        Private fieldProductName1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField

        Private fieldUnitPrice1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField

        Private fieldUnitsInStock1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField

        Private fieldUnitsOnOrder1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField

        Private fieldCategoryName1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField

        Private fieldDescription1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
    End Class
End Namespace
