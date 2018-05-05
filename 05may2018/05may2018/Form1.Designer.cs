namespace _05may2018
{
    partial class Form1
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
            this.DgvComputers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.BtnAddComputer = new System.Windows.Forms.Button();
            this.TxtRam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.CmbComputersId = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComputers)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvComputers
            // 
            this.DgvComputers.AllowUserToAddRows = false;
            this.DgvComputers.AllowUserToDeleteRows = false;
            this.DgvComputers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvComputers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvComputers.Location = new System.Drawing.Point(327, 12);
            this.DgvComputers.Name = "DgvComputers";
            this.DgvComputers.Size = new System.Drawing.Size(489, 244);
            this.DgvComputers.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Marka";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RAM";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Display";
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(15, 28);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(100, 20);
            this.TxtMarka.TabIndex = 1;
            // 
            // BtnAddComputer
            // 
            this.BtnAddComputer.Location = new System.Drawing.Point(12, 188);
            this.BtnAddComputer.Name = "BtnAddComputer";
            this.BtnAddComputer.Size = new System.Drawing.Size(103, 23);
            this.BtnAddComputer.TabIndex = 4;
            this.BtnAddComputer.Text = "Əlavə et";
            this.BtnAddComputer.UseVisualStyleBackColor = true;
            this.BtnAddComputer.Click += new System.EventHandler(this.BtnAddComputer_Click);
            // 
            // TxtRam
            // 
            this.TxtRam.Location = new System.Drawing.Point(12, 81);
            this.TxtRam.Name = "TxtRam";
            this.TxtRam.Size = new System.Drawing.Size(100, 20);
            this.TxtRam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RAM";
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(15, 137);
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(100, 20);
            this.TxtDisplay.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Display";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(12, 172);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 8;
            // 
            // CmbComputersId
            // 
            this.CmbComputersId.FormattingEnabled = true;
            this.CmbComputersId.Location = new System.Drawing.Point(12, 257);
            this.CmbComputersId.Name = "CmbComputersId";
            this.CmbComputersId.Size = new System.Drawing.Size(121, 21);
            this.CmbComputersId.TabIndex = 5;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(158, 257);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 400);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.CmbComputersId);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtRam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAddComputer);
            this.Controls.Add(this.TxtMarka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvComputers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvComputers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvComputers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMarka;
        private System.Windows.Forms.Button BtnAddComputer;
        private System.Windows.Forms.TextBox TxtRam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.ComboBox CmbComputersId;
        private System.Windows.Forms.Button BtnDelete;
    }
}

