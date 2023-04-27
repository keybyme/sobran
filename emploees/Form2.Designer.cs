namespace sobran
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblDate2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTardy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.cmbEmps = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.btnGenerateAll2 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnOpenFile2 = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate2
            // 
            this.lblDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate2.Location = new System.Drawing.Point(18, 222);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(234, 32);
            this.lblDate2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTardy);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTime2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 202);
            this.panel1.TabIndex = 22;
            // 
            // btnTardy
            // 
            this.btnTardy.BackColor = System.Drawing.Color.Black;
            this.btnTardy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTardy.ForeColor = System.Drawing.Color.White;
            this.btnTardy.Location = new System.Drawing.Point(268, 152);
            this.btnTardy.Name = "btnTardy";
            this.btnTardy.Size = new System.Drawing.Size(178, 35);
            this.btnTardy.TabIndex = 10;
            this.btnTardy.Text = "Go to Tardy page";
            this.btnTardy.UseVisualStyleBackColor = false;
            this.btnTardy.Click += new System.EventHandler(this.btnTardy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 199);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(253, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(709, 98);
            this.label2.TabIndex = 1;
            // 
            // lblTime2
            // 
            this.lblTime2.Location = new System.Drawing.Point(352, 157);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(201, 23);
            this.lblTime2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 202);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tardy and Call-outs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDate.Location = new System.Drawing.Point(19, 135);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(332, 23);
            this.lblDate.TabIndex = 21;
            // 
            // lblTime1
            // 
            this.lblTime1.Location = new System.Drawing.Point(753, 12);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(201, 23);
            this.lblTime1.TabIndex = 20;
            // 
            // cmbEmps
            // 
            this.cmbEmps.AccessibleName = "";
            this.cmbEmps.BackColor = System.Drawing.Color.Blue;
            this.cmbEmps.ForeColor = System.Drawing.Color.White;
            this.cmbEmps.FormattingEnabled = true;
            this.cmbEmps.Location = new System.Drawing.Point(798, 227);
            this.cmbEmps.Name = "cmbEmps";
            this.cmbEmps.Size = new System.Drawing.Size(177, 21);
            this.cmbEmps.TabIndex = 19;
            this.cmbEmps.Text = "Select Employee (Call-out)";
            this.cmbEmps.SelectedIndexChanged += new System.EventHandler(this.cmbEmps_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.Location = new System.Drawing.Point(23, 271);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(917, 262);
            this.dataGridView2.TabIndex = 18;
            // 
            // btnDelete2
            // 
            this.btnDelete2.BackColor = System.Drawing.Color.Red;
            this.btnDelete2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete2.Location = new System.Drawing.Point(334, 560);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(106, 42);
            this.btnDelete2.TabIndex = 24;
            this.btnDelete2.Text = "Delete";
            this.btnDelete2.UseVisualStyleBackColor = false;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // btnGenerateAll2
            // 
            this.btnGenerateAll2.Location = new System.Drawing.Point(876, 572);
            this.btnGenerateAll2.Name = "btnGenerateAll2";
            this.btnGenerateAll2.Size = new System.Drawing.Size(137, 49);
            this.btnGenerateAll2.TabIndex = 26;
            this.btnGenerateAll2.Text = "generate all";
            this.btnGenerateAll2.UseVisualStyleBackColor = true;
            this.btnGenerateAll2.Click += new System.EventHandler(this.btnGenerateAll2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(679, 572);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker2.TabIndex = 27;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnOpenFile2
            // 
            this.btnOpenFile2.Location = new System.Drawing.Point(446, 560);
            this.btnOpenFile2.Name = "btnOpenFile2";
            this.btnOpenFile2.Size = new System.Drawing.Size(116, 42);
            this.btnOpenFile2.TabIndex = 28;
            this.btnOpenFile2.Text = "open today\'s file";
            this.btnOpenFile2.UseVisualStyleBackColor = true;
            this.btnOpenFile2.Click += new System.EventHandler(this.btnOpenFile2_Click);
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl.Location = new System.Drawing.Point(679, 546);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(177, 23);
            this.lbl.TabIndex = 29;
            this.lbl.Text = "Past Reports";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(679, 598);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(191, 23);
            this.btnPrintReport.TabIndex = 30;
            this.btnPrintReport.Text = "Show File";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1096, 628);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnOpenFile2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.btnGenerateAll2);
            this.Controls.Add(this.btnDelete2);
            this.Controls.Add(this.lblDate2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.cmbEmps);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.ComboBox cmbEmps;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnTardy;
        private System.Windows.Forms.Button btnDelete2;
        private System.Windows.Forms.Button btnGenerateAll2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnOpenFile2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnPrintReport;
    }
}