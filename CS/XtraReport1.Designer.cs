namespace WindowsFormsApplication1
{
    partial class XtraReport1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
            DevExpress.DataAccess.Sql.TableQuery tableQuery1 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.RelationInfo relationInfo1 = new DevExpress.DataAccess.Sql.RelationInfo();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo1 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo1 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo2 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo3 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo4 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.TableInfo tableInfo2 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo5 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo6 = new DevExpress.DataAccess.Sql.ColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport1));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.fieldProductName1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldUnitPrice1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldUnitsInStock1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldUnitsOnOrder1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldCategoryName1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDescription1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 48.33333F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 50F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "logachev-nb-w8.Northwind.dbo";
            msSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows;
            msSqlConnectionParameters1.DatabaseName = "Northwind";
            msSqlConnectionParameters1.Password = null;
            msSqlConnectionParameters1.ServerName = "(local)";
            msSqlConnectionParameters1.UserName = null;
            this.sqlDataSource1.ConnectionParameters = msSqlConnectionParameters1;
            tableQuery1.Name = "Products";
            relationColumnInfo1.NestedKeyColumn = "CategoryID";
            relationColumnInfo1.ParentKeyColumn = "CategoryID";
            relationInfo1.KeyColumns.AddRange(new DevExpress.DataAccess.Sql.RelationColumnInfo[] {
            relationColumnInfo1});
            relationInfo1.NestedTable = "Categories";
            relationInfo1.ParentTable = "Products";
            tableQuery1.Relations.AddRange(new DevExpress.DataAccess.Sql.RelationInfo[] {
            relationInfo1});
            tableInfo1.Name = "Products";
            columnInfo1.Name = "ProductName";
            columnInfo2.Name = "UnitPrice";
            columnInfo3.Name = "UnitsInStock";
            columnInfo4.Name = "UnitsOnOrder";
            tableInfo1.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo1,
            columnInfo2,
            columnInfo3,
            columnInfo4});
            tableInfo2.Name = "Categories";
            columnInfo5.Name = "CategoryName";
            columnInfo6.Name = "Description";
            tableInfo2.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo5,
            columnInfo6});
            tableQuery1.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo1,
            tableInfo2});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.reportHeaderBand1.HeightF = 125F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataMember = "Products";
            this.xrPivotGrid1.DataSource = this.sqlDataSource1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldProductName1,
            this.fieldUnitPrice1,
            this.fieldUnitsInStock1,
            this.fieldUnitsOnOrder1,
            this.fieldCategoryName1,
            this.fieldDescription1});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(649.9999F, 125F);
            this.xrPivotGrid1.CustomRowHeight += new System.EventHandler<DevExpress.XtraReports.UI.PivotGrid.PivotCustomRowHeightEventArgs>(this.xrPivotGrid1_CustomRowHeight);
            // 
            // fieldProductName1
            // 
            this.fieldProductName1.AreaIndex = 0;
            this.fieldProductName1.Caption = "Product Name";
            this.fieldProductName1.FieldName = "ProductName";
            this.fieldProductName1.Name = "fieldProductName1";
            // 
            // fieldUnitPrice1
            // 
            this.fieldUnitPrice1.AreaIndex = 1;
            this.fieldUnitPrice1.Caption = "Unit Price";
            this.fieldUnitPrice1.FieldName = "UnitPrice";
            this.fieldUnitPrice1.Name = "fieldUnitPrice1";
            // 
            // fieldUnitsInStock1
            // 
            this.fieldUnitsInStock1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitsInStock1.AreaIndex = 2;
            this.fieldUnitsInStock1.Caption = "Units In Stock";
            this.fieldUnitsInStock1.FieldName = "UnitsInStock";
            this.fieldUnitsInStock1.Name = "fieldUnitsInStock1";
            // 
            // fieldUnitsOnOrder1
            // 
            this.fieldUnitsOnOrder1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitsOnOrder1.AreaIndex = 1;
            this.fieldUnitsOnOrder1.Caption = "Units On Order";
            this.fieldUnitsOnOrder1.FieldName = "UnitsOnOrder";
            this.fieldUnitsOnOrder1.Name = "fieldUnitsOnOrder1";
            // 
            // fieldCategoryName1
            // 
            this.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName1.AreaIndex = 0;
            this.fieldCategoryName1.Caption = "Category Name";
            this.fieldCategoryName1.FieldName = "CategoryName";
            this.fieldCategoryName1.Name = "fieldCategoryName1";
            // 
            // fieldDescription1
            // 
            this.fieldDescription1.Appearance.Cell.TextHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.fieldDescription1.Appearance.Cell.TextVerticalAlignment = DevExpress.Utils.VertAlignment.Center;
            this.fieldDescription1.Appearance.Cell.WordWrap = true;
            this.fieldDescription1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDescription1.AreaIndex = 0;
            this.fieldDescription1.Caption = "Description";
            this.fieldDescription1.FieldName = "Description";
            this.fieldDescription1.Name = "fieldDescription1";
            this.fieldDescription1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new DevExpress.Drawing.DXFont("Times New Roman", 20F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Name = "Title";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1F;
            this.FieldCaption.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
            this.FieldCaption.Name = "FieldCaption";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = "PageInfo";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.Transparent;
            this.DataField.BorderColor = System.Drawing.Color.Black;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1F;
            this.DataField.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.DataField.ForeColor = System.Drawing.Color.Black;
            this.DataField.Name = "DataField";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportHeaderBand1});
            this.DataMember = "Products";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new DevExpress.Drawing.DXMargins(100, 100, 48, 50);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.FieldCaption,
            this.PageInfo,
            this.DataField});
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldProductName1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldUnitPrice1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldUnitsInStock1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldUnitsOnOrder1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCategoryName1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDescription1;
    }
}
