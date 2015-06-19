using System;
namespace Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dvResult = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btQry = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbinvbarcode2 = new System.Windows.Forms.TextBox();
            this.tbinvcode2 = new System.Windows.Forms.TextBox();
            this.tbinvaddcode2 = new System.Windows.Forms.TextBox();
            this.tbinvaddcode1 = new System.Windows.Forms.TextBox();
            this.tbinvbarcode1 = new System.Windows.Forms.TextBox();
            this.tbinvcode1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp2 = new Print.FlatDateTimePicker();
            this.dtp1 = new Print.FlatDateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dvResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dvResult
            // 
            this.dvResult.AllowUserToAddRows = false;
            this.dvResult.AllowUserToDeleteRows = false;
            this.dvResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvResult.Location = new System.Drawing.Point(0, 0);
            this.dvResult.Name = "dvResult";
            this.dvResult.ReadOnly = true;
            this.dvResult.RowTemplate.Height = 23;
            this.dvResult.Size = new System.Drawing.Size(1067, 430);
            this.dvResult.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btQry);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbinvbarcode2);
            this.panel1.Controls.Add(this.tbinvcode2);
            this.panel1.Controls.Add(this.tbinvaddcode2);
            this.panel1.Controls.Add(this.tbinvaddcode1);
            this.panel1.Controls.Add(this.tbinvbarcode1);
            this.panel1.Controls.Add(this.tbinvcode1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtp2);
            this.panel1.Controls.Add(this.dtp1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 70);
            this.panel1.TabIndex = 2;
            // 
            // btQry
            // 
            this.btQry.Location = new System.Drawing.Point(741, 23);
            this.btQry.Name = "btQry";
            this.btQry.Size = new System.Drawing.Size(86, 34);
            this.btQry.TabIndex = 5;
            this.btQry.Text = "查询";
            this.btQry.UseVisualStyleBackColor = true;
            this.btQry.Click += new System.EventHandler(this.btQry_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "至";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "至";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "至";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "至";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "存货代码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "存货条码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "存货编码";
            // 
            // tbinvbarcode2
            // 
            this.tbinvbarcode2.Location = new System.Drawing.Point(596, 13);
            this.tbinvbarcode2.Name = "tbinvbarcode2";
            this.tbinvbarcode2.Size = new System.Drawing.Size(130, 21);
            this.tbinvbarcode2.TabIndex = 14;
            // 
            // tbinvcode2
            // 
            this.tbinvcode2.Location = new System.Drawing.Point(240, 42);
            this.tbinvcode2.Name = "tbinvcode2";
            this.tbinvcode2.Size = new System.Drawing.Size(130, 21);
            this.tbinvcode2.TabIndex = 9;
            // 
            // tbinvaddcode2
            // 
            this.tbinvaddcode2.Location = new System.Drawing.Point(596, 42);
            this.tbinvaddcode2.Name = "tbinvaddcode2";
            this.tbinvaddcode2.Size = new System.Drawing.Size(130, 21);
            this.tbinvaddcode2.TabIndex = 10;
            // 
            // tbinvaddcode1
            // 
            this.tbinvaddcode1.Location = new System.Drawing.Point(438, 42);
            this.tbinvaddcode1.Name = "tbinvaddcode1";
            this.tbinvaddcode1.Size = new System.Drawing.Size(127, 21);
            this.tbinvaddcode1.TabIndex = 11;
            // 
            // tbinvbarcode1
            // 
            this.tbinvbarcode1.Location = new System.Drawing.Point(438, 16);
            this.tbinvbarcode1.Name = "tbinvbarcode1";
            this.tbinvbarcode1.Size = new System.Drawing.Size(127, 21);
            this.tbinvbarcode1.TabIndex = 12;
            // 
            // tbinvcode1
            // 
            this.tbinvcode1.Location = new System.Drawing.Point(83, 42);
            this.tbinvcode1.Name = "tbinvcode1";
            this.tbinvcode1.Size = new System.Drawing.Size(128, 21);
            this.tbinvcode1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "出入库日期";
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "yyyy-MM-dd";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(239, 13);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(130, 21);
            this.dtp2.TabIndex = 6;
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "yyyy-MM-dd";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(83, 13);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(130, 21);
            this.dtp1.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dvResult);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 499);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 499);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "条码出入库流水账";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dvResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btQry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbinvbarcode2;
        private System.Windows.Forms.TextBox tbinvcode2;
        private System.Windows.Forms.TextBox tbinvaddcode2;
        private System.Windows.Forms.TextBox tbinvaddcode1;
        private System.Windows.Forms.TextBox tbinvbarcode1;
        private System.Windows.Forms.TextBox tbinvcode1;
        private System.Windows.Forms.Label label1;
        private FlatDateTimePicker dtp2;
        private FlatDateTimePicker dtp1;
        private System.Windows.Forms.SplitContainer splitContainer1;

    }
}

