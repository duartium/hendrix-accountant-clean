namespace HendrixAccountant.Reports
{
    partial class rptVentas
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.TableGroup tableGroup1 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup2 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup3 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup4 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.TableGroup tableGroup5 = new Telerik.Reporting.TableGroup();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
            this.txtFechaActual = new Telerik.Reporting.TextBox();
            this.txtReporteVentas = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.tblFactDetalle = new Telerik.Reporting.Table();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // textBox5
            // 
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.678D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            this.textBox5.Style.Font.Bold = true;
            this.textBox5.Value = "Nombre de artículo";
            // 
            // textBox7
            // 
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.905D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            this.textBox7.Style.Font.Bold = true;
            this.textBox7.Value = "Cantidad";
            // 
            // textBox9
            // 
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.91D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            this.textBox9.Style.Font.Bold = true;
            this.textBox9.Value = "Precio unitario";
            // 
            // textBox11
            // 
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.82D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            this.textBox11.Style.Font.Bold = true;
            this.textBox11.StyleName = "";
            this.textBox11.Value = "Valor";
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.5D);
            this.pageHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtFechaActual,
            this.txtReporteVentas,
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox4});
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Docking = Telerik.Reporting.DockingStyle.Top;
            this.txtFechaActual.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.txtFechaActual.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.txtFechaActual.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtFechaActual.Value = "=Now()";
            // 
            // txtReporteVentas
            // 
            this.txtReporteVentas.Docking = Telerik.Reporting.DockingStyle.Top;
            this.txtReporteVentas.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.txtReporteVentas.Name = "txtReporteVentas";
            this.txtReporteVentas.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17D), Telerik.Reporting.Drawing.Unit.Cm(0.6D));
            this.txtReporteVentas.Style.Font.Bold = true;
            this.txtReporteVentas.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.txtReporteVentas.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtReporteVentas.Value = "REPORTE DE VENTAS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(1.2D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            this.textBox1.Style.Font.Bold = false;
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "Desde:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.4D), Telerik.Reporting.Drawing.Unit.Cm(1.2D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            this.textBox2.Style.Font.Bold = false;
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "Fields.FechaInicial";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.9D), Telerik.Reporting.Drawing.Unit.Cm(1.2D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            this.textBox3.Style.Font.Bold = false;
            this.textBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.Value = "Hasta:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.3D), Telerik.Reporting.Drawing.Unit.Cm(1.2D));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5D), Telerik.Reporting.Drawing.Unit.Cm(1D));
            this.textBox4.Style.Font.Bold = false;
            this.textBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.textBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox4.Value = "Fields.FechaFinal";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(5D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.tblFactDetalle});
            this.detail.Name = "detail";
            // 
            // tblFactDetalle
            // 
            this.tblFactDetalle.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(8.678D)));
            this.tblFactDetalle.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.905D)));
            this.tblFactDetalle.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.91D)));
            this.tblFactDetalle.Body.Columns.Add(new Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.82D)));
            this.tblFactDetalle.Body.Rows.Add(new Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.609D)));
            this.tblFactDetalle.Body.SetCellContent(0, 0, this.textBox6);
            this.tblFactDetalle.Body.SetCellContent(0, 1, this.textBox8);
            this.tblFactDetalle.Body.SetCellContent(0, 2, this.textBox10);
            this.tblFactDetalle.Body.SetCellContent(0, 3, this.textBox12);
            tableGroup1.Name = "tableGroup";
            tableGroup1.ReportItem = this.textBox5;
            tableGroup2.Name = "tableGroup1";
            tableGroup2.ReportItem = this.textBox7;
            tableGroup3.Name = "tableGroup2";
            tableGroup3.ReportItem = this.textBox9;
            tableGroup4.Name = "group";
            tableGroup4.ReportItem = this.textBox11;
            this.tblFactDetalle.ColumnGroups.Add(tableGroup1);
            this.tblFactDetalle.ColumnGroups.Add(tableGroup2);
            this.tblFactDetalle.ColumnGroups.Add(tableGroup3);
            this.tblFactDetalle.ColumnGroups.Add(tableGroup4);
            this.tblFactDetalle.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox6,
            this.textBox8,
            this.textBox10,
            this.textBox12,
            this.textBox5,
            this.textBox7,
            this.textBox9,
            this.textBox11});
            this.tblFactDetalle.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.321D), Telerik.Reporting.Drawing.Unit.Cm(0.3D));
            this.tblFactDetalle.Name = "tblFactDetalle";
            tableGroup5.Groupings.Add(new Telerik.Reporting.Grouping(null));
            tableGroup5.Name = "detailTableGroup";
            this.tblFactDetalle.RowGroups.Add(tableGroup5);
            this.tblFactDetalle.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(16.313D), Telerik.Reporting.Drawing.Unit.Cm(1.218D));
            // 
            // textBox6
            // 
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.678D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            this.textBox6.Style.Font.Bold = true;
            // 
            // textBox8
            // 
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.905D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            this.textBox8.Style.Font.Bold = true;
            this.textBox8.Value = "Fields.Cantidad";
            // 
            // textBox10
            // 
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.91D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            // 
            // textBox12
            // 
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.82D), Telerik.Reporting.Drawing.Unit.Cm(0.609D));
            this.textBox12.StyleName = "";
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.5D);
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // rptVentas
            // 
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageHeaderSection1,
            this.detail,
            this.pageFooterSection1});
            this.Name = "rptVentas";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(17D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.TextBox txtFechaActual;
        private Telerik.Reporting.TextBox txtReporteVentas;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox11;
        public Telerik.Reporting.Table tblFactDetalle;
    }
}