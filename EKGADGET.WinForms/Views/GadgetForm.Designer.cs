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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblObjetivoSemJef = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lblProyeccionMensual = new DevComponents.DotNetBar.LabelX();
            this.lblObjetivoSemCaje = new DevComponents.DotNetBar.LabelX();
            this.circularProgress3 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.circularProgress4 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.lblAcHoy = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.lblTotalHoy = new DevComponents.DotNetBar.LabelX();
            this.ratingStar1 = new DevComponents.DotNetBar.Controls.RatingStar();
            this.ratingStar2 = new DevComponents.DotNetBar.Controls.RatingStar();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.ratingStar3 = new DevComponents.DotNetBar.Controls.RatingStar();
            this.radialMenu1 = new DevComponents.DotNetBar.RadialMenu();
            this.lblDiasRestantes = new DevComponents.DotNetBar.LabelX();
            this.btnSaldos = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.btnClose = new DevComponents.DotNetBar.Controls.ReflectionImage();
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
            this.lblMes.Size = new System.Drawing.Size(128, 23);
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
            this.lblAno.Size = new System.Drawing.Size(173, 23);
            this.lblAno.TabIndex = 1;
            this.lblAno.Text = "Año: Actual";
            // 
            // lblEmpresa
            // 
            // 
            // 
            // 
            this.lblEmpresa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEmpresa.Location = new System.Drawing.Point(374, 38);
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
            this.lblFecha.Location = new System.Drawing.Point(153, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(173, 23);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha: Hoy";
            // 
            // lblSucursal
            // 
            // 
            // 
            // 
            this.lblSucursal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSucursal.Location = new System.Drawing.Point(374, 9);
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
            this.lblMensual.Location = new System.Drawing.Point(44, 127);
            this.lblMensual.Name = "lblMensual";
            this.lblMensual.Size = new System.Drawing.Size(215, 32);
            this.lblMensual.TabIndex = 5;
            this.lblMensual.Text = "Mensual: $0000.000";
            // 
            // lblDiasOperativo
            // 
            // 
            // 
            // 
            this.lblDiasOperativo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDiasOperativo.Location = new System.Drawing.Point(153, 38);
            this.lblDiasOperativo.Name = "lblDiasOperativo";
            this.lblDiasOperativo.Size = new System.Drawing.Size(106, 23);
            this.lblDiasOperativo.TabIndex = 6;
            this.lblDiasOperativo.Text = "DiasOperativo: 26";
            // 
            // lblHaceUnAño
            // 
            // 
            // 
            // 
            this.lblHaceUnAño.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHaceUnAño.Location = new System.Drawing.Point(12, 430);
            this.lblHaceUnAño.Name = "lblHaceUnAño";
            this.lblHaceUnAño.Size = new System.Drawing.Size(247, 28);
            this.lblHaceUnAño.TabIndex = 7;
            this.lblHaceUnAño.Text = "El Mes anterior (2018)  hiciste: $0000.000";
            // 
            // lblObjetivoDiario
            // 
            // 
            // 
            // 
            this.lblObjetivoDiario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblObjetivoDiario.Location = new System.Drawing.Point(285, 130);
            this.lblObjetivoDiario.Name = "lblObjetivoDiario";
            this.lblObjetivoDiario.Size = new System.Drawing.Size(142, 32);
            this.lblObjetivoDiario.TabIndex = 8;
            this.lblObjetivoDiario.Text = "Diario: $0000.00";
            // 
            // lblAcumuladoHastaHoy
            // 
            // 
            // 
            // 
            this.lblAcumuladoHastaHoy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAcumuladoHastaHoy.Location = new System.Drawing.Point(44, 160);
            this.lblAcumuladoHastaHoy.Name = "lblAcumuladoHastaHoy";
            this.lblAcumuladoHastaHoy.Size = new System.Drawing.Size(215, 23);
            this.lblAcumuladoHastaHoy.TabIndex = 9;
            this.lblAcumuladoHastaHoy.Text = "Acumulado Hasta Hoy: $ 000.00";
            // 
            // lblTotalOperacionesPrestamos
            // 
            // 
            // 
            // 
            this.lblTotalOperacionesPrestamos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalOperacionesPrestamos.Location = new System.Drawing.Point(44, 190);
            this.lblTotalOperacionesPrestamos.Name = "lblTotalOperacionesPrestamos";
            this.lblTotalOperacionesPrestamos.Size = new System.Drawing.Size(215, 23);
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
            this.circularProgress1.Location = new System.Drawing.Point(44, 256);
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
            this.circularProgress2.Location = new System.Drawing.Point(285, 259);
            this.circularProgress2.Name = "circularProgress2";
            this.circularProgress2.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circularProgress2.ProgressColor = System.Drawing.Color.DarkOrange;
            this.circularProgress2.ProgressTextVisible = true;
            this.circularProgress2.Size = new System.Drawing.Size(142, 134);
            this.circularProgress2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress2.TabIndex = 12;
            this.circularProgress2.Value = 80;
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
            this.reflectionImage1.Location = new System.Drawing.Point(661, 9);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(92, 81);
            this.reflectionImage1.TabIndex = 14;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(44, 227);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(142, 23);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "Acumulado al Mes";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(285, 230);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(142, 23);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Objetivo Diario";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblObjetivoSemJef
            // 
            // 
            // 
            // 
            this.lblObjetivoSemJef.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblObjetivoSemJef.Location = new System.Drawing.Point(458, 127);
            this.lblObjetivoSemJef.Name = "lblObjetivoSemJef";
            this.lblObjetivoSemJef.Size = new System.Drawing.Size(142, 32);
            this.lblObjetivoSemJef.TabIndex = 17;
            this.lblObjetivoSemJef.Text = "Semanal Jefe Suc.: $0.0000";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(335, 98);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(129, 23);
            this.labelX4.TabIndex = 18;
            this.labelX4.Text = "Objetivos de Prestamos";
            // 
            // lblProyeccionMensual
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProyeccionMensual.Location = new System.Drawing.Point(243, 430);
            this.lblProyeccionMensual.Name = "lblProyeccionMensual";
            this.lblProyeccionMensual.Size = new System.Drawing.Size(414, 23);
            this.lblProyeccionMensual.TabIndex = 19;
            this.lblProyeccionMensual.Text = "Proyección con lo que llevas hasta hoy llegarias al:: $1000.00 - 99% de objetivo";
            // 
            // lblObjetivoSemCaje
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblObjetivoSemCaje.Location = new System.Drawing.Point(639, 130);
            this.lblObjetivoSemCaje.Name = "lblObjetivoSemCaje";
            this.lblObjetivoSemCaje.Size = new System.Drawing.Size(142, 23);
            this.lblObjetivoSemCaje.TabIndex = 20;
            this.lblObjetivoSemCaje.Text = "Semanal Cajero: $000.00";
            // 
            // circularProgress3
            // 
            // 
            // 
            // 
            this.circularProgress3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress3.Location = new System.Drawing.Point(458, 256);
            this.circularProgress3.Name = "circularProgress3";
            this.circularProgress3.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circularProgress3.ProgressColor = System.Drawing.Color.Aqua;
            this.circularProgress3.ProgressTextVisible = true;
            this.circularProgress3.Size = new System.Drawing.Size(142, 134);
            this.circularProgress3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress3.TabIndex = 21;
            this.circularProgress3.Value = 40;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(458, 211);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(142, 39);
            this.labelX7.TabIndex = 22;
            this.labelX7.Text = "Objetivo Semanal \r\nJefe Sucursal";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // circularProgress4
            // 
            // 
            // 
            // 
            this.circularProgress4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress4.Location = new System.Drawing.Point(639, 255);
            this.circularProgress4.Name = "circularProgress4";
            this.circularProgress4.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circularProgress4.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.circularProgress4.ProgressTextVisible = true;
            this.circularProgress4.Size = new System.Drawing.Size(142, 134);
            this.circularProgress4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress4.TabIndex = 23;
            this.circularProgress4.Value = 35;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(624, 210);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(157, 39);
            this.labelX8.TabIndex = 24;
            this.labelX8.Text = "Objetivo Semanal\r\nCajero Valuador";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblAcHoy
            // 
            // 
            // 
            // 
            this.lblAcHoy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAcHoy.Location = new System.Drawing.Point(285, 163);
            this.lblAcHoy.Name = "lblAcHoy";
            this.lblAcHoy.Size = new System.Drawing.Size(142, 23);
            this.lblAcHoy.TabIndex = 25;
            this.lblAcHoy.Text = "Hoy Lleva: $1000.00";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(458, 165);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(177, 23);
            this.labelX5.TabIndex = 26;
            this.labelX5.Text = "Esta Semana llevas: $ 000.00";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(639, 162);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(151, 25);
            this.labelX6.TabIndex = 27;
            this.labelX6.Text = "Prestamos esta Semana: 000";
            // 
            // lblTotalHoy
            // 
            // 
            // 
            // 
            this.lblTotalHoy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalHoy.Location = new System.Drawing.Point(285, 192);
            this.lblTotalHoy.Name = "lblTotalHoy";
            this.lblTotalHoy.Size = new System.Drawing.Size(142, 24);
            this.lblTotalHoy.TabIndex = 28;
            this.lblTotalHoy.Text = "Prestamos Hoy: 100";
            // 
            // ratingStar1
            // 
            // 
            // 
            // 
            this.ratingStar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ratingStar1.Location = new System.Drawing.Point(457, 189);
            this.ratingStar1.Name = "ratingStar1";
            this.ratingStar1.Size = new System.Drawing.Size(143, 23);
            this.ratingStar1.TabIndex = 29;
            this.ratingStar1.TextColor = System.Drawing.Color.Empty;
            this.ratingStar1.TextSpacing = 40;
            // 
            // ratingStar2
            // 
            // 
            // 
            // 
            this.ratingStar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ratingStar2.Location = new System.Drawing.Point(639, 188);
            this.ratingStar2.Name = "ratingStar2";
            this.ratingStar2.Size = new System.Drawing.Size(151, 23);
            this.ratingStar2.TabIndex = 30;
            this.ratingStar2.TextColor = System.Drawing.Color.Empty;
            this.ratingStar2.TextSpacing = 40;
            // 
            // progressBarX1
            // 
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(153, 68);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(106, 22);
            this.progressBarX1.TabIndex = 31;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // ratingStar3
            // 
            // 
            // 
            // 
            this.ratingStar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ratingStar3.Location = new System.Drawing.Point(44, 396);
            this.ratingStar3.Name = "ratingStar3";
            this.ratingStar3.Size = new System.Drawing.Size(129, 37);
            this.ratingStar3.TabIndex = 32;
            this.ratingStar3.TextColor = System.Drawing.Color.Empty;
            this.ratingStar3.TextSpacing = 40;
            // 
            // radialMenu1
            // 
            // 
            // 
            // 
            this.radialMenu1.Colors.RadialMenuItemDisabledForeground = System.Drawing.Color.Empty;
            this.radialMenu1.Location = new System.Drawing.Point(192, 396);
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Size = new System.Drawing.Size(28, 28);
            this.radialMenu1.Symbol = "";
            this.radialMenu1.SymbolSize = 13F;
            this.radialMenu1.TabIndex = 33;
            this.radialMenu1.Text = "radialMenu1";
            // 
            // lblDiasRestantes
            // 
            // 
            // 
            // 
            this.lblDiasRestantes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDiasRestantes.Location = new System.Drawing.Point(11, 68);
            this.lblDiasRestantes.Name = "lblDiasRestantes";
            this.lblDiasRestantes.Size = new System.Drawing.Size(128, 23);
            this.lblDiasRestantes.TabIndex = 34;
            this.lblDiasRestantes.Text = "Dias Restantes: 26";
            // 
            // btnSaldos
            // 
            this.btnSaldos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaldos.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnSaldos.Location = new System.Drawing.Point(639, 425);
            this.btnSaldos.Name = "btnSaldos";
            this.btnSaldos.Size = new System.Drawing.Size(47, 28);
            this.btnSaldos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaldos.Symbol = "";
            this.btnSaldos.TabIndex = 35;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX1.Location = new System.Drawing.Point(696, 425);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(47, 28);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 0;
            // 
            // switchButton1
            // 
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Location = new System.Drawing.Point(153, 99);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.OffText = "Comprimir";
            this.switchButton1.OnText = "Expandir";
            this.switchButton1.Size = new System.Drawing.Size(105, 32);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.TabIndex = 36;
            // 
            // btnClose
            // 
            // 
            // 
            // 
            this.btnClose.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnClose.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(763, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 24);
            this.btnClose.TabIndex = 37;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GadgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 478);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.switchButton1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.btnSaldos);
            this.Controls.Add(this.lblDiasRestantes);
            this.Controls.Add(this.radialMenu1);
            this.Controls.Add(this.ratingStar3);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.ratingStar2);
            this.Controls.Add(this.ratingStar1);
            this.Controls.Add(this.lblTotalHoy);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.lblAcHoy);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.circularProgress4);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.circularProgress3);
            this.Controls.Add(this.lblObjetivoSemCaje);
            this.Controls.Add(this.lblProyeccionMensual);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.lblObjetivoSemJef);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.reflectionImage1);
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
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblObjetivoSemJef;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX lblProyeccionMensual;
        private DevComponents.DotNetBar.LabelX lblObjetivoSemCaje;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress3;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress4;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX lblAcHoy;
        private DevComponents.DotNetBar.LabelX lblTotalHoy;
        private DevComponents.DotNetBar.Controls.RatingStar ratingStar1;
        private DevComponents.DotNetBar.Controls.RatingStar ratingStar2;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private DevComponents.DotNetBar.Controls.RatingStar ratingStar3;
        private DevComponents.DotNetBar.RadialMenu radialMenu1;
        private DevComponents.DotNetBar.LabelX lblDiasRestantes;
        private DevComponents.DotNetBar.ButtonX btnSaldos;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;
        private DevComponents.DotNetBar.Controls.ReflectionImage btnClose;
    }
}