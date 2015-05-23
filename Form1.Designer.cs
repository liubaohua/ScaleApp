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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.tbInvName = new System.Windows.Forms.TextBox();
            this.tbInvStd = new System.Windows.Forms.TextBox();
            this.tbInvCode = new System.Windows.Forms.TextBox();
            this.tbOrderCode = new System.Windows.Forms.TextBox();
            this.tbAxisBrand = new System.Windows.Forms.TextBox();
            this.tbGross = new System.Windows.Forms.TextBox();
            this.tbTare = new System.Windows.Forms.TextBox();
            this.tbProdNo = new System.Windows.Forms.TextBox();
            this.tbVenCode = new System.Windows.Forms.TextBox();
            this.tbCustCode = new System.Windows.Forms.TextBox();
            this.tbMoCode = new System.Windows.Forms.TextBox();
            this.tbProdTime = new System.Windows.Forms.TextBox();
            this.tbMacNo = new System.Windows.Forms.TextBox();
            this.tbStaffCode = new System.Windows.Forms.TextBox();
            this.tbNet = new System.Windows.Forms.TextBox();
            this.btnReadScale = new System.Windows.Forms.Button();
            this.cbLabelNo = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dtFinishDate = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.tbTotalLen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F);
            this.button1.Location = new System.Drawing.Point(45, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "打印(&D)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "产品条码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "规格型号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "产品编码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "订单编号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "线轴型号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "毛重";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "产品名称";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "生产订单号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "客户编码";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "厂商代码";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "生产编号";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(230, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "皮重/轴重";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(425, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "生产时间";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(426, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "完工日期";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(425, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "机台号";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(422, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "工号";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(43, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "标签模板";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(450, 229);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 1;
            this.label18.Text = "总长度KM";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 9F);
            this.button2.Location = new System.Drawing.Point(412, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "关闭(&G)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(102, 18);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(125, 21);
            this.tbBarcode.TabIndex = 0;
            this.tbBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FetchBarcodeInfo);
            // 
            // tbInvName
            // 
            this.tbInvName.Location = new System.Drawing.Point(295, 18);
            this.tbInvName.Name = "tbInvName";
            this.tbInvName.ReadOnly = true;
            this.tbInvName.Size = new System.Drawing.Size(125, 21);
            this.tbInvName.TabIndex = 3;
            // 
            // tbInvStd
            // 
            this.tbInvStd.Location = new System.Drawing.Point(103, 55);
            this.tbInvStd.Name = "tbInvStd";
            this.tbInvStd.ReadOnly = true;
            this.tbInvStd.Size = new System.Drawing.Size(125, 21);
            this.tbInvStd.TabIndex = 3;
            // 
            // tbInvCode
            // 
            this.tbInvCode.Location = new System.Drawing.Point(103, 87);
            this.tbInvCode.Name = "tbInvCode";
            this.tbInvCode.ReadOnly = true;
            this.tbInvCode.Size = new System.Drawing.Size(125, 21);
            this.tbInvCode.TabIndex = 3;
            // 
            // tbOrderCode
            // 
            this.tbOrderCode.Location = new System.Drawing.Point(102, 115);
            this.tbOrderCode.Name = "tbOrderCode";
            this.tbOrderCode.ReadOnly = true;
            this.tbOrderCode.Size = new System.Drawing.Size(125, 21);
            this.tbOrderCode.TabIndex = 3;
            // 
            // tbAxisBrand
            // 
            this.tbAxisBrand.Location = new System.Drawing.Point(102, 150);
            this.tbAxisBrand.Name = "tbAxisBrand";
            this.tbAxisBrand.ReadOnly = true;
            this.tbAxisBrand.Size = new System.Drawing.Size(125, 21);
            this.tbAxisBrand.TabIndex = 3;
            // 
            // tbGross
            // 
            this.tbGross.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbGross.ForeColor = System.Drawing.Color.Red;
            this.tbGross.Location = new System.Drawing.Point(102, 177);
            this.tbGross.Name = "tbGross";
            this.tbGross.ReadOnly = true;
            this.tbGross.Size = new System.Drawing.Size(125, 29);
            this.tbGross.TabIndex = 3;
            // 
            // tbTare
            // 
            this.tbTare.Font = new System.Drawing.Font("宋体", 14.25F);
            this.tbTare.ForeColor = System.Drawing.Color.Red;
            this.tbTare.Location = new System.Drawing.Point(295, 182);
            this.tbTare.Name = "tbTare";
            this.tbTare.ReadOnly = true;
            this.tbTare.Size = new System.Drawing.Size(125, 29);
            this.tbTare.TabIndex = 3;
            // 
            // tbProdNo
            // 
            this.tbProdNo.Location = new System.Drawing.Point(295, 150);
            this.tbProdNo.Name = "tbProdNo";
            this.tbProdNo.ReadOnly = true;
            this.tbProdNo.Size = new System.Drawing.Size(125, 21);
            this.tbProdNo.TabIndex = 3;
            // 
            // tbVenCode
            // 
            this.tbVenCode.Location = new System.Drawing.Point(295, 115);
            this.tbVenCode.Name = "tbVenCode";
            this.tbVenCode.ReadOnly = true;
            this.tbVenCode.Size = new System.Drawing.Size(125, 21);
            this.tbVenCode.TabIndex = 3;
            // 
            // tbCustCode
            // 
            this.tbCustCode.Location = new System.Drawing.Point(295, 82);
            this.tbCustCode.Name = "tbCustCode";
            this.tbCustCode.ReadOnly = true;
            this.tbCustCode.Size = new System.Drawing.Size(125, 21);
            this.tbCustCode.TabIndex = 3;
            // 
            // tbMoCode
            // 
            this.tbMoCode.Location = new System.Drawing.Point(295, 55);
            this.tbMoCode.Name = "tbMoCode";
            this.tbMoCode.ReadOnly = true;
            this.tbMoCode.Size = new System.Drawing.Size(125, 21);
            this.tbMoCode.TabIndex = 3;
            // 
            // tbProdTime
            // 
            this.tbProdTime.Location = new System.Drawing.Point(484, 18);
            this.tbProdTime.Name = "tbProdTime";
            this.tbProdTime.ReadOnly = true;
            this.tbProdTime.Size = new System.Drawing.Size(125, 21);
            this.tbProdTime.TabIndex = 3;
            // 
            // tbMacNo
            // 
            this.tbMacNo.Location = new System.Drawing.Point(484, 84);
            this.tbMacNo.Name = "tbMacNo";
            this.tbMacNo.ReadOnly = true;
            this.tbMacNo.Size = new System.Drawing.Size(125, 21);
            this.tbMacNo.TabIndex = 3;
            // 
            // tbStaffCode
            // 
            this.tbStaffCode.Location = new System.Drawing.Point(484, 115);
            this.tbStaffCode.Name = "tbStaffCode";
            this.tbStaffCode.ReadOnly = true;
            this.tbStaffCode.Size = new System.Drawing.Size(125, 21);
            this.tbStaffCode.TabIndex = 3;
            // 
            // tbNet
            // 
            this.tbNet.Font = new System.Drawing.Font("宋体", 14.25F);
            this.tbNet.ForeColor = System.Drawing.Color.Red;
            this.tbNet.Location = new System.Drawing.Point(484, 182);
            this.tbNet.Name = "tbNet";
            this.tbNet.ReadOnly = true;
            this.tbNet.Size = new System.Drawing.Size(123, 29);
            this.tbNet.TabIndex = 3;
            // 
            // btnReadScale
            // 
            this.btnReadScale.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadScale.Location = new System.Drawing.Point(219, 267);
            this.btnReadScale.Name = "btnReadScale";
            this.btnReadScale.Size = new System.Drawing.Size(80, 32);
            this.btnReadScale.TabIndex = 2;
            this.btnReadScale.Text = "打印设置(&S)";
            this.btnReadScale.UseVisualStyleBackColor = true;
            this.btnReadScale.Click += new System.EventHandler(this.Config_Click);
            // 
            // cbLabelNo
            // 
            this.cbLabelNo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbLabelNo.FormattingEnabled = true;
            this.cbLabelNo.Location = new System.Drawing.Point(102, 220);
            this.cbLabelNo.Name = "cbLabelNo";
            this.cbLabelNo.Size = new System.Drawing.Size(342, 27);
            this.cbLabelNo.TabIndex = 4;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(484, 151);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(125, 20);
            this.cbPort.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(422, 154);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 1;
            this.label20.Text = "电子秤端口";
            // 
            // dtFinishDate
            // 
            this.dtFinishDate.CustomFormat = "yyyy-MM-dd";
            this.dtFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinishDate.Location = new System.Drawing.Point(484, 52);
            this.dtFinishDate.Name = "dtFinishDate";
            this.dtFinishDate.Size = new System.Drawing.Size(123, 21);
            this.dtFinishDate.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(426, 194);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "净重";
            // 
            // tbTotalLen
            // 
            this.tbTotalLen.Font = new System.Drawing.Font("宋体", 14.25F);
            this.tbTotalLen.ForeColor = System.Drawing.Color.Red;
            this.tbTotalLen.Location = new System.Drawing.Point(509, 220);
            this.tbTotalLen.Name = "tbTotalLen";
            this.tbTotalLen.ReadOnly = true;
            this.tbTotalLen.Size = new System.Drawing.Size(98, 29);
            this.tbTotalLen.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 334);
            this.Controls.Add(this.dtFinishDate);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.cbLabelNo);
            this.Controls.Add(this.tbMoCode);
            this.Controls.Add(this.tbCustCode);
            this.Controls.Add(this.tbVenCode);
            this.Controls.Add(this.tbProdNo);
            this.Controls.Add(this.tbTotalLen);
            this.Controls.Add(this.tbTare);
            this.Controls.Add(this.tbGross);
            this.Controls.Add(this.tbAxisBrand);
            this.Controls.Add(this.tbOrderCode);
            this.Controls.Add(this.tbInvCode);
            this.Controls.Add(this.tbInvStd);
            this.Controls.Add(this.tbNet);
            this.Controls.Add(this.tbStaffCode);
            this.Controls.Add(this.tbMacNo);
            this.Controls.Add(this.tbProdTime);
            this.Controls.Add(this.tbInvName);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReadScale);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "U8称重系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosed1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.TextBox tbInvName;
        private System.Windows.Forms.TextBox tbInvStd;
        private System.Windows.Forms.TextBox tbInvCode;
        private System.Windows.Forms.TextBox tbOrderCode;
        private System.Windows.Forms.TextBox tbAxisBrand;
        private System.Windows.Forms.TextBox tbGross;
        private System.Windows.Forms.TextBox tbTare;
        private System.Windows.Forms.TextBox tbProdNo;
        private System.Windows.Forms.TextBox tbVenCode;
        private System.Windows.Forms.TextBox tbCustCode;
        private System.Windows.Forms.TextBox tbMoCode;
        private System.Windows.Forms.TextBox tbProdTime;
        private System.Windows.Forms.TextBox tbMacNo;
        private System.Windows.Forms.TextBox tbStaffCode;
        private System.Windows.Forms.TextBox tbNet;
        private System.Windows.Forms.Button btnReadScale;
        private System.Windows.Forms.ComboBox cbLabelNo;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtFinishDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbTotalLen;
    }
}

