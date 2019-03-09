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
            this.lblFecha = new DevComponents.DotNetBar.LabelX();
            this.lblSucursal = new DevComponents.DotNetBar.LabelX();
            this.lblMensual = new DevComponents.DotNetBar.LabelX();
            this.lblDiasOperativo = new DevComponents.DotNetBar.LabelX();
            this.lblHaceUnAño = new DevComponents.DotNetBar.LabelX();
            this.lblObjetivoDiario = new DevComponents.DotNetBar.LabelX();
            this.lblAcumuladoHastaHoy = new DevComponents.DotNetBar.LabelX();
            this.lblTotalOperacionesPrestamos = new DevComponents.DotNetBar.LabelX();
            this.circPrestamos = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.cirDiario = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblObjetivoSemJef = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lblProyeccionMensual = new DevComponents.DotNetBar.LabelX();
            this.lblObjetivoSemCaje = new DevComponents.DotNetBar.LabelX();
            this.cirSemJefe = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.cirSemCajero = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.lblAcHoy = new DevComponents.DotNetBar.LabelX();
            this.lblAcumuladoJefe = new DevComponents.DotNetBar.LabelX();
            this.lblcantidadSemanal = new DevComponents.DotNetBar.LabelX();
            this.lblTotalHoy = new DevComponents.DotNetBar.LabelX();
            this.ratingStar1 = new DevComponents.DotNetBar.Controls.RatingStar();
            this.ratingStar2 = new DevComponents.DotNetBar.Controls.RatingStar();
            this.ratingTotal = new DevComponents.DotNetBar.Controls.RatingStar();
            this.radialMenu1 = new DevComponents.DotNetBar.RadialMenu();
            this.lblDiasRestantes = new DevComponents.DotNetBar.LabelX();
            this.btnSaldos = new DevComponents.DotNetBar.ButtonX();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.switchButton1 = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.prdDiasRestantes = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.piclLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            // 
            // 
            // 
            this.lblMes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(319, 409);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(184, 23);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Mes: Desconocido";
            // 
            // lblAno
            // 
            // 
            // 
            // 
            this.lblAno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(124, 409);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(173, 23);
            this.lblAno.TabIndex = 1;
            this.lblAno.Text = "Año: Actual";
            // 
            // lblFecha
            // 
            // 
            // 
            // 
            this.lblFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(124, 441);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(379, 23);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha: Hoy";
            // 
            // lblSucursal
            // 
            // 
            // 
            // 
            this.lblSucursal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(101, 556);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(336, 71);
            this.lblSucursal.TabIndex = 4;
            this.lblSucursal.Text = "Sucursal: Sucursal";
            // 
            // lblMensual
            // 
            // 
            // 
            // 
            this.lblMensual.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensual.Location = new System.Drawing.Point(9, 89);
            this.lblMensual.Name = "lblMensual";
            this.lblMensual.Size = new System.Drawing.Size(293, 32);
            this.lblMensual.TabIndex = 5;
            this.lblMensual.Text = "Mensual: $0000.000";
            // 
            // lblDiasOperativo
            // 
            // 
            // 
            // 
            this.lblDiasOperativo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDiasOperativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasOperativo.Location = new System.Drawing.Point(576, 404);
            this.lblDiasOperativo.Name = "lblDiasOperativo";
            this.lblDiasOperativo.Size = new System.Drawing.Size(106, 33);
            this.lblDiasOperativo.TabIndex = 6;
            this.lblDiasOperativo.Text = "DiasOperativo: \r\n26";
            this.lblDiasOperativo.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblHaceUnAño
            // 
            // 
            // 
            // 
            this.lblHaceUnAño.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHaceUnAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaceUnAño.Location = new System.Drawing.Point(462, 553);
            this.lblHaceUnAño.Name = "lblHaceUnAño";
            this.lblHaceUnAño.Size = new System.Drawing.Size(345, 74);
            this.lblHaceUnAño.TabIndex = 7;
            this.lblHaceUnAño.Text = "El Mes anterior (2018)  hiciste: $0000.000";
            this.lblHaceUnAño.Click += new System.EventHandler(this.lblHaceUnAño_Click);
            // 
            // lblObjetivoDiario
            // 
            // 
            // 
            // 
            this.lblObjetivoDiario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblObjetivoDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivoDiario.Location = new System.Drawing.Point(308, 35);
            this.lblObjetivoDiario.Name = "lblObjetivoDiario";
            this.lblObjetivoDiario.Size = new System.Drawing.Size(177, 23);
            this.lblObjetivoDiario.TabIndex = 8;
            this.lblObjetivoDiario.Text = "Diario: $0000.00";
            // 
            // lblAcumuladoHastaHoy
            // 
            // 
            // 
            // 
            this.lblAcumuladoHastaHoy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAcumuladoHastaHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcumuladoHastaHoy.Location = new System.Drawing.Point(9, 125);
            this.lblAcumuladoHastaHoy.Name = "lblAcumuladoHastaHoy";
            this.lblAcumuladoHastaHoy.Size = new System.Drawing.Size(293, 23);
            this.lblAcumuladoHastaHoy.TabIndex = 9;
            this.lblAcumuladoHastaHoy.Text = "Acumulado Hasta Hoy: $ 000.00";
            // 
            // lblTotalOperacionesPrestamos
            // 
            // 
            // 
            // 
            this.lblTotalOperacionesPrestamos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalOperacionesPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOperacionesPrestamos.Location = new System.Drawing.Point(9, 158);
            this.lblTotalOperacionesPrestamos.Name = "lblTotalOperacionesPrestamos";
            this.lblTotalOperacionesPrestamos.Size = new System.Drawing.Size(293, 23);
            this.lblTotalOperacionesPrestamos.TabIndex = 10;
            this.lblTotalOperacionesPrestamos.Text = "Total de Prestamos Hasta Hoy:  00";
            // 
            // circPrestamos
            // 
            // 
            // 
            // 
            this.circPrestamos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circPrestamos.Location = new System.Drawing.Point(12, 186);
            this.circPrestamos.Name = "circPrestamos";
            this.circPrestamos.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circPrestamos.ProgressColor = System.Drawing.Color.LimeGreen;
            this.circPrestamos.ProgressTextVisible = true;
            this.circPrestamos.Size = new System.Drawing.Size(162, 138);
            this.circPrestamos.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circPrestamos.TabIndex = 11;
            // 
            // cirDiario
            // 
            // 
            // 
            // 
            this.cirDiario.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground2;
            this.cirDiario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.cirDiario.Location = new System.Drawing.Point(295, 182);
            this.cirDiario.Name = "cirDiario";
            this.cirDiario.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.cirDiario.ProgressColor = System.Drawing.Color.DarkOrange;
            this.cirDiario.ProgressTextVisible = true;
            this.cirDiario.Size = new System.Drawing.Size(159, 138);
            this.cirDiario.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.cirDiario.TabIndex = 12;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48))))), System.Drawing.Color.Cyan);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(308, 137);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(135, 23);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Objetivo Diario";
            // 
            // lblObjetivoSemJef
            // 
            // 
            // 
            // 
            this.lblObjetivoSemJef.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblObjetivoSemJef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivoSemJef.Location = new System.Drawing.Point(529, 35);
            this.lblObjetivoSemJef.Name = "lblObjetivoSemJef";
            this.lblObjetivoSemJef.Size = new System.Drawing.Size(221, 23);
            this.lblObjetivoSemJef.TabIndex = 17;
            this.lblObjetivoSemJef.Text = "Semanal Jefe Suc.: $0.0000";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(73, 21);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(186, 49);
            this.labelX4.TabIndex = 18;
            this.labelX4.Text = "Objetivos de \r\nPrestamos";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblProyeccionMensual
            // 
            // 
            // 
            // 
            this.lblProyeccionMensual.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProyeccionMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyeccionMensual.Location = new System.Drawing.Point(27, 484);
            this.lblProyeccionMensual.Name = "lblProyeccionMensual";
            this.lblProyeccionMensual.Size = new System.Drawing.Size(945, 66);
            this.lblProyeccionMensual.TabIndex = 19;
            this.lblProyeccionMensual.Text = "Proyección con lo que llevas hasta hoy llegarias al:: $1000.00 - 99% de objetivo";
            this.lblProyeccionMensual.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblObjetivoSemCaje
            // 
            // 
            // 
            // 
            this.lblObjetivoSemCaje.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblObjetivoSemCaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivoSemCaje.Location = new System.Drawing.Point(744, 35);
            this.lblObjetivoSemCaje.Name = "lblObjetivoSemCaje";
            this.lblObjetivoSemCaje.Size = new System.Drawing.Size(215, 23);
            this.lblObjetivoSemCaje.TabIndex = 20;
            this.lblObjetivoSemCaje.Text = "Semanal Cajero: $000.00";
            // 
            // cirSemJefe
            // 
            // 
            // 
            // 
            this.cirSemJefe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cirSemJefe.Location = new System.Drawing.Point(536, 186);
            this.cirSemJefe.Name = "cirSemJefe";
            this.cirSemJefe.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.cirSemJefe.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.cirSemJefe.ProgressTextVisible = true;
            this.cirSemJefe.Size = new System.Drawing.Size(159, 119);
            this.cirSemJefe.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.cirSemJefe.TabIndex = 21;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(529, 129);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(142, 39);
            this.labelX7.TabIndex = 22;
            this.labelX7.Text = "Objetivo Semanal \r\nJefe Sucursal";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cirSemCajero
            // 
            // 
            // 
            // 
            this.cirSemCajero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cirSemCajero.Location = new System.Drawing.Point(744, 186);
            this.cirSemCajero.Name = "cirSemCajero";
            this.cirSemCajero.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.cirSemCajero.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cirSemCajero.ProgressTextVisible = true;
            this.cirSemCajero.Size = new System.Drawing.Size(159, 119);
            this.cirSemCajero.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.cirSemCajero.TabIndex = 23;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(744, 129);
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
            this.lblAcHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcHoy.Location = new System.Drawing.Point(308, 64);
            this.lblAcHoy.Name = "lblAcHoy";
            this.lblAcHoy.Size = new System.Drawing.Size(177, 23);
            this.lblAcHoy.TabIndex = 25;
            this.lblAcHoy.Text = "Hoy Lleva: $1000.00";
            // 
            // lblAcumuladoJefe
            // 
            // 
            // 
            // 
            this.lblAcumuladoJefe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAcumuladoJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcumuladoJefe.Location = new System.Drawing.Point(529, 64);
            this.lblAcumuladoJefe.Name = "lblAcumuladoJefe";
            this.lblAcumuladoJefe.Size = new System.Drawing.Size(221, 23);
            this.lblAcumuladoJefe.TabIndex = 26;
            this.lblAcumuladoJefe.Text = "Esta Semana llevas: $ 000.00";
            // 
            // lblcantidadSemanal
            // 
            // 
            // 
            // 
            this.lblcantidadSemanal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblcantidadSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadSemanal.Location = new System.Drawing.Point(744, 62);
            this.lblcantidadSemanal.Name = "lblcantidadSemanal";
            this.lblcantidadSemanal.Size = new System.Drawing.Size(199, 25);
            this.lblcantidadSemanal.TabIndex = 27;
            this.lblcantidadSemanal.Text = "Prestamos esta Semana: 000";
            // 
            // lblTotalHoy
            // 
            // 
            // 
            // 
            this.lblTotalHoy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTotalHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHoy.Location = new System.Drawing.Point(308, 93);
            this.lblTotalHoy.Name = "lblTotalHoy";
            this.lblTotalHoy.Size = new System.Drawing.Size(177, 24);
            this.lblTotalHoy.TabIndex = 28;
            this.lblTotalHoy.Text = "Prestamos Hoy: 100";
            // 
            // ratingStar1
            // 
            // 
            // 
            // 
            this.ratingStar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ratingStar1.IsEditable = false;
            this.ratingStar1.Location = new System.Drawing.Point(535, 94);
            this.ratingStar1.Name = "ratingStar1";
            this.ratingStar1.NumberOfStars = 10;
            this.ratingStar1.Size = new System.Drawing.Size(143, 23);
            this.ratingStar1.TabIndex = 29;
            this.ratingStar1.TextColor = System.Drawing.Color.Empty;
            // 
            // ratingStar2
            // 
            // 
            // 
            // 
            this.ratingStar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ratingStar2.IsEditable = false;
            this.ratingStar2.Location = new System.Drawing.Point(760, 94);
            this.ratingStar2.Name = "ratingStar2";
            this.ratingStar2.NumberOfStars = 10;
            this.ratingStar2.Size = new System.Drawing.Size(151, 23);
            this.ratingStar2.TabIndex = 30;
            this.ratingStar2.TextColor = System.Drawing.Color.Empty;
            this.ratingStar2.TextSpacing = 1;
            // 
            // ratingTotal
            // 
            // 
            // 
            // 
            this.ratingTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ratingTotal.IsEditable = false;
            this.ratingTotal.Location = new System.Drawing.Point(12, 330);
            this.ratingTotal.Name = "ratingTotal";
            this.ratingTotal.NumberOfStars = 10;
            this.ratingTotal.Size = new System.Drawing.Size(162, 37);
            this.ratingTotal.TabIndex = 32;
            this.ratingTotal.TextColor = System.Drawing.Color.Empty;
            this.ratingTotal.TextSpacing = 1;
            // 
            // radialMenu1
            // 
            // 
            // 
            // 
            this.radialMenu1.Colors.RadialMenuItemDisabledForeground = System.Drawing.Color.Empty;
            this.radialMenu1.Diameter = 360;
            this.radialMenu1.Location = new System.Drawing.Point(929, 285);
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Size = new System.Drawing.Size(48, 48);
            this.radialMenu1.Symbol = "";
            this.radialMenu1.SymbolSize = 13F;
            this.radialMenu1.TabIndex = 33;
            this.radialMenu1.Text = "radialMenu1";
            this.radialMenu1.ItemClick += new System.EventHandler(this.radialMenu1_ItemClick);
            // 
            // lblDiasRestantes
            // 
            // 
            // 
            // 
            this.lblDiasRestantes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDiasRestantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasRestantes.Location = new System.Drawing.Point(715, 404);
            this.lblDiasRestantes.Name = "lblDiasRestantes";
            this.lblDiasRestantes.Size = new System.Drawing.Size(128, 33);
            this.lblDiasRestantes.TabIndex = 34;
            this.lblDiasRestantes.Text = "Dias Restantes:\r\n 26";
            this.lblDiasRestantes.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnSaldos
            // 
            this.btnSaldos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaldos.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnSaldos.Location = new System.Drawing.Point(929, 106);
            this.btnSaldos.Name = "btnSaldos";
            this.btnSaldos.Size = new System.Drawing.Size(54, 54);
            this.btnSaldos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaldos.SubItemsExpandWidth = 1;
            this.btnSaldos.Symbol = "";
            this.btnSaldos.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSaldos.SymbolSize = 36F;
            this.btnSaldos.TabIndex = 35;
            this.btnSaldos.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSaldos.Tooltip = "ENVIAR SALDOS";
            this.btnSaldos.Click += new System.EventHandler(this.btnSaldos_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnPrint.Location = new System.Drawing.Point(929, 197);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(54, 54);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.SubItemsExpandWidth = 1;
            this.btnPrint.Symbol = "";
            this.btnPrint.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPrint.SymbolSize = 36F;
            this.btnPrint.TabIndex = 0;
            this.btnPrint.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnPrint.Tooltip = "ENVIAR E IMPRIMIR INFORME";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // switchButton1
            // 
            this.switchButton1.BackColor = System.Drawing.Color.Aqua;
            // 
            // 
            // 
            this.switchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchButton1.Location = new System.Drawing.Point(724, 2);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.OffText = "Comprimir";
            this.switchButton1.OnText = "Expandir";
            this.switchButton1.Size = new System.Drawing.Size(177, 27);
            this.switchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchButton1.TabIndex = 36;
            this.switchButton1.ValueChanged += new System.EventHandler(this.switchButton1_ValueChanged);
            // 
            // prdDiasRestantes
            // 
            // 
            // 
            // 
            this.prdDiasRestantes.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prdDiasRestantes.Location = new System.Drawing.Point(576, 448);
            this.prdDiasRestantes.MarqueeAnimationSpeed = 800;
            this.prdDiasRestantes.Name = "prdDiasRestantes";
            this.prdDiasRestantes.Size = new System.Drawing.Size(267, 16);
            this.prdDiasRestantes.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.prdDiasRestantes.TabIndex = 38;
            this.prdDiasRestantes.Value = 30;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::EKGADGET.WinForms.Properties.Resources.chart_1_111423;
            this.pictureBox5.Location = new System.Drawing.Point(9, 14);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 68);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 44;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EKGADGET.WinForms.Properties.Resources.sucursal;
            this.pictureBox4.Location = new System.Drawing.Point(27, 556);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 71);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EKGADGET.WinForms.Properties.Resources.storia_icona;
            this.pictureBox2.Location = new System.Drawing.Point(870, 409);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EKGADGET.WinForms.Properties.Resources.calendario;
            this.pictureBox1.Location = new System.Drawing.Point(27, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // piclLogo
            // 
            this.piclLogo.Location = new System.Drawing.Point(868, 553);
            this.piclLogo.Name = "piclLogo";
            this.piclLogo.Size = new System.Drawing.Size(75, 74);
            this.piclLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclLogo.TabIndex = 39;
            this.piclLogo.TabStop = false;
            // 
            // btnClose
            // 
            // 
            // 
            // 
            this.btnClose.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnClose.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(945, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 24);
            this.btnClose.TabIndex = 37;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // GadgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 641);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.piclLogo);
            this.Controls.Add(this.prdDiasRestantes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.switchButton1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSaldos);
            this.Controls.Add(this.lblDiasRestantes);
            this.Controls.Add(this.radialMenu1);
            this.Controls.Add(this.ratingTotal);
            this.Controls.Add(this.ratingStar2);
            this.Controls.Add(this.ratingStar1);
            this.Controls.Add(this.lblTotalHoy);
            this.Controls.Add(this.lblcantidadSemanal);
            this.Controls.Add(this.lblAcumuladoJefe);
            this.Controls.Add(this.lblAcHoy);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.cirSemCajero);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.cirSemJefe);
            this.Controls.Add(this.lblObjetivoSemCaje);
            this.Controls.Add(this.lblProyeccionMensual);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.lblObjetivoSemJef);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cirDiario);
            this.Controls.Add(this.circPrestamos);
            this.Controls.Add(this.lblTotalOperacionesPrestamos);
            this.Controls.Add(this.lblAcumuladoHastaHoy);
            this.Controls.Add(this.lblObjetivoDiario);
            this.Controls.Add(this.lblHaceUnAño);
            this.Controls.Add(this.lblDiasOperativo);
            this.Controls.Add(this.lblMensual);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblMes);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 680);
            this.MinimumSize = new System.Drawing.Size(1000, 408);
            this.Name = "GadgetForm";
            this.Text = "Gadget SEMP";
            this.Load += new System.EventHandler(this.GadgetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblMes;
        private DevComponents.DotNetBar.LabelX lblAno;
        private DevComponents.DotNetBar.LabelX lblFecha;
        private DevComponents.DotNetBar.LabelX lblSucursal;
        private DevComponents.DotNetBar.LabelX lblMensual;
        private DevComponents.DotNetBar.LabelX lblDiasOperativo;
        private DevComponents.DotNetBar.LabelX lblHaceUnAño;
        private DevComponents.DotNetBar.LabelX lblObjetivoDiario;
        private DevComponents.DotNetBar.LabelX lblAcumuladoHastaHoy;
        private DevComponents.DotNetBar.LabelX lblTotalOperacionesPrestamos;
        private DevComponents.DotNetBar.Controls.CircularProgress circPrestamos;
        private DevComponents.DotNetBar.Controls.CircularProgress cirDiario;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblObjetivoSemJef;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX lblProyeccionMensual;
        private DevComponents.DotNetBar.LabelX lblObjetivoSemCaje;
        private DevComponents.DotNetBar.Controls.CircularProgress cirSemJefe;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.CircularProgress cirSemCajero;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX lblAcumuladoJefe;
        private DevComponents.DotNetBar.LabelX lblcantidadSemanal;
        private DevComponents.DotNetBar.LabelX lblAcHoy;
        private DevComponents.DotNetBar.LabelX lblTotalHoy;
        private DevComponents.DotNetBar.Controls.RatingStar ratingStar1;
        private DevComponents.DotNetBar.Controls.RatingStar ratingStar2;
        private DevComponents.DotNetBar.Controls.RatingStar ratingTotal;
        private DevComponents.DotNetBar.RadialMenu radialMenu1;
        private DevComponents.DotNetBar.LabelX lblDiasRestantes;
        private DevComponents.DotNetBar.ButtonX btnSaldos;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.Controls.SwitchButton switchButton1;
        private DevComponents.DotNetBar.Controls.ReflectionImage btnClose;
        private DevComponents.DotNetBar.Controls.ProgressBarX prdDiasRestantes;
        private System.Windows.Forms.PictureBox piclLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}