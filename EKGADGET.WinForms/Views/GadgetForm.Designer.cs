namespace EKGADGET.WinForms
{
    partial class GadgetForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GadgetForm));
            this.lblMes = new DevComponents.DotNetBar.LabelX();
            this.lblAno = new DevComponents.DotNetBar.LabelX();
            this.lblEmpresa = new DevComponents.DotNetBar.LabelX();
            this.lblFecha = new DevComponents.DotNetBar.LabelX();
            this.lblSucursal = new DevComponents.DotNetBar.LabelX();
            this.lblMensual = new DevComponents.DotNetBar.LabelX();
            this.lblDiasOperativo = new DevComponents.DotNetBar.LabelX();
            this.lblHaceUnAño = new DevComponents.DotNetBar.LabelX();
            this.lblObjetivoDiario = new DevComponents.DotNetBar.LabelX();
            this.lblAcumuladoHastaHoy = new DevComponents.DotNetBar.LabelX();
            this.lblTotalOperacionesPrestamos = new DevComponents.DotNetBar.LabelX();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.circularProgress2 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.radialMenu1 = new DevComponents.DotNetBar.RadialMenu();
            this.radialMenuItem1 = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialMenuItem2 = new DevComponents.DotNetBar.RadialMenuItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.radialMenuItem3 = new DevComponents.DotNetBar.RadialMenuItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            // 
            // 
            // 
            this.lblMes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMes.Location = new System.Drawing.Point(11, 38);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(208, 23);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Mes: Desconocido";
            // 
            // lblAno
            // 
            // 
            // 
            // 
            this.lblAno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAno.Location = new System.Drawing.Point(11, 9);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(208, 23);
            this.lblAno.TabIndex = 1;
            this.lblAno.Text = "Año: Actual";
            // 
            // lblEmpresa
            // 
            // 
            // 
            // 
            this.lblEmpresa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEmpresa.Location = new System.Drawing.Point(230, 38);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(226, 23);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.Text = "Empresa: Empresa";
            // 
            // lblFecha
            // 
            // 
            // 
            // 
            this.lblFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFecha.Location = new System.Drawing.Point(11, 67);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(208, 23);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha: Hoy";
            // 
            // lblSucursal
            // 
            // 
            // 
            // 
            this.lblSucursal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSucursal.Location = new System.Drawing.Point(230, 9);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(226, 23);
            this.lblSucursal.TabIndex = 4;
            this.lblSucursal.Text = "Sucursal: Sucursal";
            // 
            // lblMensual
            // 
            // 
            // 
            // 
            this.lblMensual.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMensual.Location = new System.Drawing.Point(11, 106);
            this.lblMensual.Name = "lblMensual";
            this.lblMensual.Size = new System.Drawing.Size(169, 38);
            this.lblMensual.TabIndex = 5;
            this.lblMensual.Text = "Objetivo Mensual: $0000.000";
            // 
            // lblDiasOperativo
            // 
            // 
            // 
            // 
            this.lblDiasOperativo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDiasOperativo.Location = new System.Drawing.Point(230, 67);
            this.lblDiasOperativo.Name = "lblDiasOperativo";
            this.lblDiasOperativo.Size = new System.Drawing.Size(226, 23);
            this.lblDiasOperativo.TabIndex = 6;
            this.lblDiasOperativo.Text = "DiasOperativo: 26";
            // 
            // lblHaceUnAño
            // 
            // 
            // 
            // 
            this.lblHaceUnAño.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHaceUnAño.Location = new System.Drawing.Point(11, 147);
            this.lblHaceUnAño.Name = "lblHaceUnAño";
            this.lblHaceUnAño.Size = new System.Drawing.Size(342, 28);
            this.lblHaceUnAño.TabIndex = 7;
            this.lblHaceUnAño.Text = "El Mes del Año anterior (2018)  hiciste: $0000.000";
            // 
            // lblObjetivoDiario
            // 
            // 
            // 
            // 
            this.lblObjetivoDiario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblObjetivoDiario.Location = new System.Drawing.Point(230, 106);
            this.lblObjetivoDiario.Name = "lblObjetivoDiario";
            this.lblObjetivoDiario.Size = new System.Drawing.Size(226, 35);
            this.lblObjetivoDiario.TabIndex = 8;
            this.lblObjetivoDiario.Text = "Objetivo Diario: $0000.00";
            // 
            // lblAcumuladoHastaHoy
            // 
            // 
            // 
            // 
            this.lblAcumuladoHastaHoy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAcumuladoHastaHoy.Location = new System.Drawing.Point(11, 181);
            this.lblAcumuladoHastaHoy.Name = "lblAcumuladoHastaHoy";
            this.lblAcumuladoHastaHoy.Size = new System.Drawing.Size(342, 23);
            this.lblAcumuladoHastaHoy.TabIndex = 9;
            this.lblAcumuladoHastaHoy.Text = "Acumulado Hasta Hoy: $ 000.00";
            // 
            // lblTotalOperacionesPrestamos
            // 
            // 
            // 
            // 
            this.lblTotalOperacionesPrestamos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalOperacionesPrestamos.Location = new System.Drawing.Point(11, 210);
            this.lblTotalOperacionesPrestamos.Name = "lblTotalOperacionesPrestamos";
            this.lblTotalOperacionesPrestamos.Size = new System.Drawing.Size(342, 23);
            this.lblTotalOperacionesPrestamos.TabIndex = 10;
            this.lblTotalOperacionesPrestamos.Text = "Total de Prestamos Hasta Hoy:  00";
            // 
            // circularProgress1
            // 
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgress1.Location = new System.Drawing.Point(120, 279);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circularProgress1.ProgressColor = System.Drawing.Color.LimeGreen;
            this.circularProgress1.ProgressTextVisible = true;
            this.circularProgress1.Size = new System.Drawing.Size(142, 134);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 11;
            this.circularProgress1.Value = 80;
            // 
            // circularProgress2
            // 
            // 
            // 
            // 
            this.circularProgress2.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground2;
            this.circularProgress2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.circularProgress2.Location = new System.Drawing.Point(314, 279);
            this.circularProgress2.Name = "circularProgress2";
            this.circularProgress2.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circularProgress2.ProgressColor = System.Drawing.Color.DarkOrange;
            this.circularProgress2.ProgressTextVisible = true;
            this.circularProgress2.Size = new System.Drawing.Size(142, 134);
            this.circularProgress2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress2.TabIndex = 12;
            this.circularProgress2.Value = 80;
            // 
            // radialMenu1
            // 
            // 
            // 
            // 
            this.radialMenu1.Colors.RadialMenuItemDisabledForeground = System.Drawing.Color.Empty;
            this.radialMenu1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.radialMenuItem1,
            this.radialMenuItem2,
            this.radialMenuItem3});
            this.radialMenu1.Location = new System.Drawing.Point(27, 409);
            this.radialMenu1.MenuType = DevComponents.DotNetBar.eRadialMenuType.Circular;
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Size = new System.Drawing.Size(48, 48);
            this.radialMenu1.Symbol = "";
            this.radialMenu1.SymbolSize = 24F;
            this.radialMenu1.TabIndex = 13;
            this.radialMenu1.Text = "Prestamos Por Categoria";
            // 
            // radialMenuItem1
            // 
            this.radialMenuItem1.Name = "radialMenuItem1";
            this.radialMenuItem1.Symbol = "";
            this.radialMenuItem1.Text = "Autos";
            // 
            // radialMenuItem2
            // 
            this.radialMenuItem2.Name = "radialMenuItem2";
            this.radialMenuItem2.Text = "Joyeria";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(462, 12);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(92, 81);
            this.reflectionImage1.TabIndex = 14;
            // 
            // radialMenuItem3
            // 
            this.radialMenuItem3.Name = "radialMenuItem3";
            this.radialMenuItem3.Text = "Electronicos";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(120, 239);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(118, 23);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "Acumulado al Mes";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(314, 239);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(105, 23);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Objetivo Diario";
            // 
            // GadgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 469);
            this.ControlBox = false;
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.radialMenu1);
            this.Controls.Add(this.circularProgress2);
            this.Controls.Add(this.circularProgress1);
            this.Controls.Add(this.lblTotalOperacionesPrestamos);
            this.Controls.Add(this.lblAcumuladoHastaHoy);
            this.Controls.Add(this.lblObjetivoDiario);
            this.Controls.Add(this.lblHaceUnAño);
            this.Controls.Add(this.lblDiasOperativo);
            this.Controls.Add(this.lblMensual);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMes);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GadgetForm";
            this.Text = "Gadget SEMP";
            this.Load += new System.EventHandler(this.GadgetForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblMes;
        private DevComponents.DotNetBar.LabelX lblAno;
        private DevComponents.DotNetBar.LabelX lblEmpresa;
        private DevComponents.DotNetBar.LabelX lblFecha;
        private DevComponents.DotNetBar.LabelX lblSucursal;
        private DevComponents.DotNetBar.LabelX lblMensual;
        private DevComponents.DotNetBar.LabelX lblDiasOperativo;
        private DevComponents.DotNetBar.LabelX lblHaceUnAño;
        private DevComponents.DotNetBar.LabelX lblObjetivoDiario;
        private DevComponents.DotNetBar.LabelX lblAcumuladoHastaHoy;
        private DevComponents.DotNetBar.LabelX lblTotalOperacionesPrestamos;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress2;
        private DevComponents.DotNetBar.RadialMenu radialMenu1;
        private DevComponents.DotNetBar.RadialMenuItem radialMenuItem1;
        private DevComponents.DotNetBar.RadialMenuItem radialMenuItem2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.RadialMenuItem radialMenuItem3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}