namespace EKGADGET.WinForms.Views
{
    partial class SaldosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaldosForm));
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.CONCEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRestaC1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRestaC2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridViewX2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.CONCEPTO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblC1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.txtSaldoC1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSaldoC2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblC2 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCaja2 = new DevComponents.DotNetBar.ButtonX();
            this.btnCaja = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CONCEPTO,
            this.IMPORTE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.EnableHeadersVisualStyles = false;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(132)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(92, 171);
            this.dataGridViewX1.Name = "dataGridViewX1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dataGridViewX1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dataGridViewX1.Size = new System.Drawing.Size(340, 133);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellValueChanged);
            this.dataGridViewX1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewX1_EditingControlShowing);
            this.dataGridViewX1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewX1_UserDeletedRow);
            this.dataGridViewX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewX1_KeyPress);
            // 
            // CONCEPTO
            // 
            this.CONCEPTO.HeaderText = "CONCEPTO";
            this.CONCEPTO.Name = "CONCEPTO";
            // 
            // IMPORTE
            // 
            this.IMPORTE.HeaderText = "IMPORTE";
            this.IMPORTE.Name = "IMPORTE";
            // 
            // txtRestaC1
            // 
            this.txtRestaC1.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtRestaC1.Border.Class = "TextBoxBorder";
            this.txtRestaC1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRestaC1.DisabledBackColor = System.Drawing.Color.Black;
            this.txtRestaC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestaC1.ForeColor = System.Drawing.Color.White;
            this.txtRestaC1.Location = new System.Drawing.Point(275, 358);
            this.txtRestaC1.Name = "txtRestaC1";
            this.txtRestaC1.PreventEnterBeep = true;
            this.txtRestaC1.ReadOnly = true;
            this.txtRestaC1.Size = new System.Drawing.Size(157, 30);
            this.txtRestaC1.TabIndex = 1;
            // 
            // txtRestaC2
            // 
            this.txtRestaC2.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtRestaC2.Border.Class = "TextBoxBorder";
            this.txtRestaC2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRestaC2.DisabledBackColor = System.Drawing.Color.Black;
            this.txtRestaC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestaC2.ForeColor = System.Drawing.Color.White;
            this.txtRestaC2.Location = new System.Drawing.Point(709, 358);
            this.txtRestaC2.Name = "txtRestaC2";
            this.txtRestaC2.PreventEnterBeep = true;
            this.txtRestaC2.ReadOnly = true;
            this.txtRestaC2.Size = new System.Drawing.Size(154, 30);
            this.txtRestaC2.TabIndex = 2;
            // 
            // dataGridViewX2
            // 
            this.dataGridViewX2.AllowUserToAddRows = false;
            this.dataGridViewX2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridViewX2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CONCEPTO2,
            this.IMPORTE2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewX2.EnableHeadersVisualStyles = false;
            this.dataGridViewX2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(132)))));
            this.dataGridViewX2.Location = new System.Drawing.Point(523, 171);
            this.dataGridViewX2.Name = "dataGridViewX2";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX2.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dataGridViewX2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewX2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dataGridViewX2.Size = new System.Drawing.Size(340, 133);
            this.dataGridViewX2.TabIndex = 3;
            this.dataGridViewX2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX2_CellValueChanged);
            this.dataGridViewX2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewX2_EditingControlShowing);
            this.dataGridViewX2.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewX2_UserDeletedRow);
            this.dataGridViewX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewX2_KeyPress);
            // 
            // CONCEPTO2
            // 
            this.CONCEPTO2.HeaderText = "CONCEPTO";
            this.CONCEPTO2.Name = "CONCEPTO2";
            // 
            // IMPORTE2
            // 
            this.IMPORTE2.HeaderText = "IMPORTE";
            this.IMPORTE2.Name = "IMPORTE2";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(48, 37);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(8, 8);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "labelX1";
            // 
            // lblC1
            // 
            // 
            // 
            // 
            this.lblC1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblC1.Location = new System.Drawing.Point(218, 77);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(75, 23);
            this.lblC1.TabIndex = 5;
            this.lblC1.Text = "CAJA 1";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(738, 403);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(125, 35);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.Symbol = "";
            this.buttonX4.TabIndex = 10;
            this.buttonX4.Text = "ENVIAR";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // txtSaldoC1
            // 
            this.txtSaldoC1.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtSaldoC1.Border.Class = "TextBoxBorder";
            this.txtSaldoC1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSaldoC1.DisabledBackColor = System.Drawing.Color.Black;
            this.txtSaldoC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoC1.ForeColor = System.Drawing.Color.White;
            this.txtSaldoC1.Location = new System.Drawing.Point(275, 135);
            this.txtSaldoC1.Name = "txtSaldoC1";
            this.txtSaldoC1.PreventEnterBeep = true;
            this.txtSaldoC1.ReadOnly = true;
            this.txtSaldoC1.Size = new System.Drawing.Size(157, 30);
            this.txtSaldoC1.TabIndex = 11;
            // 
            // txtSaldoC2
            // 
            this.txtSaldoC2.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txtSaldoC2.Border.Class = "TextBoxBorder";
            this.txtSaldoC2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSaldoC2.DisabledBackColor = System.Drawing.Color.Black;
            this.txtSaldoC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoC2.ForeColor = System.Drawing.Color.White;
            this.txtSaldoC2.Location = new System.Drawing.Point(709, 135);
            this.txtSaldoC2.Name = "txtSaldoC2";
            this.txtSaldoC2.PreventEnterBeep = true;
            this.txtSaldoC2.ReadOnly = true;
            this.txtSaldoC2.Size = new System.Drawing.Size(154, 30);
            this.txtSaldoC2.TabIndex = 12;
            // 
            // lblC2
            // 
            // 
            // 
            // 
            this.lblC2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblC2.Location = new System.Drawing.Point(631, 77);
            this.lblC2.Name = "lblC2";
            this.lblC2.Size = new System.Drawing.Size(75, 23);
            this.lblC2.TabIndex = 13;
            this.lblC2.Text = "CAJA 2";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 5);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(503, 42);
            this.labelX4.TabIndex = 14;
            this.labelX4.Text = "AGREGA TUS VALES, COMPROBANTES, GASTOS QUE TENGAS EN LAS CAJAS PARA SABER\r\n DE CU" +
    "ANTO ES TU SALDO FISICO Y PODERLO ENVIAR ;)\r\n";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(149, 142);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(120, 23);
            this.labelX5.TabIndex = 15;
            this.labelX5.Text = "Saldo Actual:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(580, 142);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(123, 23);
            this.labelX6.TabIndex = 16;
            this.labelX6.Text = "Saldo Actual:";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(149, 365);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(96, 23);
            this.labelX7.TabIndex = 17;
            this.labelX7.Text = "Efectivo:";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(580, 365);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(87, 23);
            this.labelX8.TabIndex = 18;
            this.labelX8.Text = "Efectivo:";
            // 
            // circularProgress1
            // 
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(406, 37);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressColor = System.Drawing.Color.SpringGreen;
            this.circularProgress1.Size = new System.Drawing.Size(75, 65);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 23;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Image = global::EKGADGET.WinForms.Properties.Resources.anterior;
            this.btnUpdate.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnUpdate.Location = new System.Drawing.Point(815, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(48, 45);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EKGADGET.WinForms.Properties.Resources.money;
            this.pictureBox4.Location = new System.Drawing.Point(523, 335);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EKGADGET.WinForms.Properties.Resources.caja;
            this.pictureBox3.Location = new System.Drawing.Point(523, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EKGADGET.WinForms.Properties.Resources.money;
            this.pictureBox2.Location = new System.Drawing.Point(92, 335);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EKGADGET.WinForms.Properties.Resources.caja;
            this.pictureBox1.Location = new System.Drawing.Point(92, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnCaja2
            // 
            this.btnCaja2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaja2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaja2.Image = global::EKGADGET.WinForms.Properties.Resources.plus_PNG8;
            this.btnCaja2.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnCaja2.Location = new System.Drawing.Point(454, 171);
            this.btnCaja2.Name = "btnCaja2";
            this.btnCaja2.Size = new System.Drawing.Size(42, 38);
            this.btnCaja2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaja2.TabIndex = 8;
            this.btnCaja2.Click += new System.EventHandler(this.btnCaja2_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCaja.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCaja.Image = global::EKGADGET.WinForms.Properties.Resources.plus_PNG8;
            this.btnCaja.ImageFixedSize = new System.Drawing.Size(24, 24);
            this.btnCaja.Location = new System.Drawing.Point(25, 168);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(45, 37);
            this.btnCaja.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCaja.TabIndex = 7;
            this.btnCaja.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // SaldosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.circularProgress1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.lblC2);
            this.Controls.Add(this.txtSaldoC2);
            this.Controls.Add(this.txtSaldoC1);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.btnCaja2);
            this.Controls.Add(this.btnCaja);
            this.Controls.Add(this.lblC1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dataGridViewX2);
            this.Controls.Add(this.txtRestaC2);
            this.Controls.Add(this.txtRestaC1);
            this.Controls.Add(this.dataGridViewX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(893, 489);
            this.MinimumSize = new System.Drawing.Size(893, 489);
            this.Name = "SaldosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Saldos";
            this.Load += new System.EventHandler(this.SaldosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRestaC1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRestaC2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblC1;
        private DevComponents.DotNetBar.ButtonX btnCaja;
        private DevComponents.DotNetBar.ButtonX btnCaja2;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSaldoC1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSaldoC2;
        private DevComponents.DotNetBar.LabelX lblC2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONCEPTO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTE2;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
    }
}