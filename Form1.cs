﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Threading;
//using Microsoft.Office.Core;
using Microsoft.Office;

namespace Print
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitDatabaseSetting();
        }

        private System.Data.SqlClient.SqlConnection sqlConnection1;

        String XMLFILENAME = "UserData.xml";

        private void InitDatabaseSetting()
        {
            if (!File.Exists(XMLFILENAME))
                WriteXml();
            string ConnString = "data source=.;user id=sa;password=ufida123456;initial catalog=UFDATA_009_2015;Connect Timeout=10;Persist Security Info=True ;Current Language=Simplified Chinese;";
            string Server = ReadXmlData("SqlServer", "Server");
            string User = ReadXmlData("SqlServer", "User");
            string Password = ReadXmlData("SqlServer", "Password");
            string DataBase = ReadXmlData("SqlServer", "DataBase");
            ConnString = "data source=" + RC4.Decrypt("1",Server) + ";";
            ConnString += "user id=" + RC4.Decrypt("1",User) + ";";
            ConnString += "password=" + RC4.Decrypt("1",Password) + ";";
            ConnString += "initial catalog=" + RC4.Decrypt("1",DataBase) + ";";
            ConnString += "Connect Timeout=10;Persist Security Info=True ;Current Language=Simplified Chinese;";
            this.sqlConnection1.ConnectionString = ConnString;
        }

        String ReadXmlData(String ElementName,String ElementName2)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XMLFILENAME);
            XmlNode root = doc.DocumentElement[ElementName];
            if (root != null && root.SelectSingleNode(ElementName2)!=null)
                return root.SelectSingleNode(ElementName2).InnerText;
            return "";
        }

        String ReadXmlData(String ElementName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XMLFILENAME);
            XmlNode root = doc.DocumentElement[ElementName];
            if (root != null)
                return root.InnerText;
            return "";
        }

        void ModifyXml(UserData ud)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XMLFILENAME);
            XmlNode root = doc.DocumentElement[ud.ElementName];
            List<NameValuePair> udList = ud.ValueList;
            if(udList!=null)
            {
                for (int i = 0; i <= udList.Count - 1; i++)
                    root.SelectSingleNode(udList[i].Name).InnerText = udList[i].Value;
            }
            doc.Save(XMLFILENAME);
        }

        void ModifyXml(String Name, String Value)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XMLFILENAME);
            XmlNode root = doc.DocumentElement[Name];
            if (root != null)
            {
                root.InnerText = Value;
                doc.Save(XMLFILENAME);
            }
        }


        void WriteXml()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            XmlWriter writer = XmlWriter.Create(XMLFILENAME, settings);
            writer.WriteStartDocument();
            writer.WriteComment("This file is generated by the program.");
            writer.WriteStartElement("Information");
            writer.WriteStartElement("SqlServer");
            writer.WriteElementString("Server", "");
            writer.WriteElementString("User", "");
            writer.WriteElementString("Password", "");
            writer.WriteElementString("DataBase", "");
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();

        }
        string isLog = "";

        private object missing = Missing.Value;
        //        private System.Data.SqlClient.SqlCommand sqlCommand1;

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            {
                MessageBox.Show(("y".Equals(isLog)?ex.StackTrace:ex.Message), "打印时错误");
            }
        }

        private DateTime FormatTime(string p)
        {
            return DateTime.Parse(p);
        }

        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public void GcCollect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ReadScale_Click(object sender, EventArgs e)
        {

        }

        private void DbSetting_Click(object sender, EventArgs e)
        {
            DbSettingForm form = new DbSettingForm();
            DialogResult dr = form.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                UserData ud = new UserData();
                ud.ElementName = "SqlServer";
                List<NameValuePair> list = new List<NameValuePair>();
                NameValuePair np = new NameValuePair();
                np.Name = "Server";
                np.Value = RC4.Encrypt("1",form.getIP());
                list.Add(np);

                np = new NameValuePair();
                np.Name = "User";
                np.Value = RC4.Encrypt("1",form.getUser());
                list.Add(np);

                np = new NameValuePair();
                np.Name = "Password";
                np.Value = RC4.Encrypt("1",form.getPassword());
                list.Add(np);

                np = new NameValuePair();
                np.Name = "DataBase";
                np.Value = RC4.Encrypt("1", form.getDatabasename());
                list.Add(np);


                ud.ValueList = list;
                ModifyXml(ud);
                InitDatabaseSetting();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control & e.KeyCode == Keys.S)//CTRL + S
                DbSetting_Click(null, null);

        }

        private void TestDb()
        {
            try
            {
                SqlCommand cmdSelect = new SqlCommand("select 1 as mydata", this.sqlConnection1);
                //cmdSelect.Parameters.Add("@ID", SqlDbType.Int, 4);
                //cmdSelect.Parameters["@ID"].Value = InvCode
                this.sqlConnection1.Open();
                MessageBox.Show("数据库连接成功","提示");
            }
            catch
                (Exception e)
            {
                MessageBox.Show(e.Message, "提示");
            }
            finally
            {
                this.sqlConnection1.Close();
            }
            
        }

        private void btQry_Click(object sender, EventArgs e)
        {
                try
                {
                    StringBuilder invcodecond = new StringBuilder();
                    if (!tbinvcode1.Text.Equals("") && !tbinvcode2.Text.Equals(""))
                        invcodecond.Append(" and rs1.cinvcode>='" + tbinvcode1.Text + "' and rs1.cinvcode<='" + tbinvcode2.Text + "' ");
                    if (!dtp1.Text.Trim().Equals("") && !dtp2.Text.Trim().Equals(""))
                        invcodecond.Append(" and r1.ddate>='" + String.Format("{0:yyyy-MM-dd}", dtp1.Text) + "' and r1.ddate<='" + String.Format("{0:yyyy-MM-dd}", dtp2.Text) + "' ");
                    if (!tbinvbarcode1.Text.Equals("") && !tbinvbarcode2.Text.Equals(""))
                        invcodecond.Append(" and rs1.cbarcode>='" + tbinvbarcode1.Text + "' and rs1.cbarcode<='" + tbinvbarcode2.Text + "' ");

                    if (invcodecond.Length == 0 && (tbinvaddcode1.Text.Equals("") || tbinvaddcode2.Text.Equals("")))
                    {
                        MessageBox.Show("请您选择查询条件","提示");
                        return;
                    }
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select t2.ddate as 日期,t2.cVouchName as 单据类型,t2.cCode 单据号,t2.cwhName 仓库,t2.cinvcode 存货编码,t2.cbarcode 存货条码,t2.cInvAddCode 存货代码,");
                    sb.AppendLine("t2.cinvname 存货名称,t2.cinvstd 规格型号,t2.cinvccode 存货类别编码,t2.cinvcname 存货类别名称,t2.cComUnitName 主计量单位,t2.inquantity 入库数量,t2.onquantity 出库数量,");
                    sb.AppendLine("c.cCusName 客户,t2.cmemo 备注,t2.cmaker 制单人,t2.chandler 审核人,t2.dVeriDate 审核日期 from (");
                    sb.AppendLine("select t.ddate,t.cVouchType,v.cVouchName,t.cCode,w.cwhName,i.cinvcode,t.cbarcode,i.cInvAddCode,");
                    sb.AppendLine("i.cinvname,i.cinvstd,i.cinvccode,ic.cinvcname,cu.cComUnitName,");
                    sb.AppendLine("(case when t.bRdFlag=1 then cast(t.iquantity as decimal(18,2)) end) inquantity,");
                    sb.AppendLine("(case when t.bRdFlag=0 then cast(t.iquantity as decimal(18,2)) end) onquantity,t.cmemo,t.cmaker,t.chandler,t.dVeriDate,t.cCusCode");
                    sb.AppendLine("from");
                    sb.AppendLine("(select r1.bRdFlag,r1.ddate,r1.cVouchType,r1.cCode,r1.cCusCode,r1.cwhcode,r1.cmemo,r1.cmaker,r1.chandler,r1.dVeriDate,");
                    sb.AppendLine("rs1.cinvcode,rs1.cbarcode,rs1.iquantity");
                    sb.AppendLine("from rdrecord01 r1,rdrecords01 rs1");
                    sb.AppendLine("where r1.id = rs1.id ");
                    sb.AppendLine(invcodecond.ToString());
                    sb.AppendLine("union");
                    sb.AppendLine("select r1.bRdFlag,r1.ddate,r1.cVouchType,r1.cCode,r1.cCusCode,r1.cwhcode,r1.cmemo,r1.cmaker,r1.chandler,r1.dVeriDate,");
                    sb.AppendLine("rs1.cinvcode,rs1.cbarcode,rs1.iquantity");
                    sb.AppendLine("from rdrecord10 r1,rdrecords10 rs1");
                    sb.AppendLine("where r1.id = rs1.id  ");
                    sb.AppendLine(invcodecond.ToString());
                    sb.AppendLine("union");
                    sb.AppendLine("select r1.bRdFlag,r1.ddate,r1.cVouchType,r1.cCode,r1.cCusCode,r1.cwhcode,r1.cmemo,r1.cmaker,r1.chandler,r1.dVeriDate,");
                    sb.AppendLine("rs1.cinvcode,rs1.cbarcode,rs1.iquantity");
                    sb.AppendLine("from rdrecord08 r1,rdrecords08 rs1");
                    sb.AppendLine("where r1.id = rs1.id  ");
                    sb.AppendLine(invcodecond.ToString());
                    sb.AppendLine("union");
                    sb.AppendLine("select r1.bRdFlag,r1.ddate,r1.cVouchType,r1.cCode,r1.cCusCode,r1.cwhcode,r1.cmemo,r1.cmaker,r1.chandler,r1.dVeriDate,");
                    sb.AppendLine("rs1.cinvcode,rs1.cbarcode,rs1.iquantity");
                    sb.AppendLine("from rdrecord11 r1,rdrecords11 rs1");
                    sb.AppendLine("where r1.id = rs1.id ");
                    sb.AppendLine(invcodecond.ToString());
                    sb.AppendLine("union");
                    sb.AppendLine("select r1.bRdFlag,r1.ddate,r1.cVouchType,r1.cCode,r1.cCusCode,r1.cwhcode,r1.cmemo,r1.cmaker,r1.chandler,r1.dVeriDate,");
                    sb.AppendLine("rs1.cinvcode,rs1.cbarcode,rs1.iquantity");
                    sb.AppendLine("from rdrecord32 r1,rdrecords32 rs1");
                    sb.AppendLine("where r1.id = rs1.id ");
                    sb.AppendLine(invcodecond.ToString());
                    sb.AppendLine("union");
                    sb.AppendLine("select r1.bRdFlag,r1.ddate,r1.cVouchType,r1.cCode,r1.cCusCode,r1.cwhcode,r1.cmemo,r1.cmaker,r1.chandler,r1.dVeriDate,");
                    sb.AppendLine("rs1.cinvcode,rs1.cbarcode,rs1.iquantity");
                    sb.AppendLine("from rdrecord09 r1,rdrecords09 rs1");
                    sb.AppendLine("where r1.id = rs1.id");
                    sb.AppendLine(invcodecond.ToString());
                    sb.AppendLine(") t,warehouse w,inventory i,inventoryclass ic,ComputationUnit cu,VouchType v ");
                    sb.AppendLine("where w.cwhcode = t.cwhcode and i.cinvcode=t.cinvcode");
                    sb.AppendLine("and ic.cinvccode = i.cinvccode and cu.cComunitCode  = i.cComUnitCode and v.cVouchType = t.cVouchType");
                    
                    if (!tbinvaddcode1.Text.Equals("") && !tbinvaddcode2.Text.Equals(""))
                        sb.Append(" and i.cInvAddCode>='" + tbinvaddcode1.Text + "' and i.cInvAddCode<='" + tbinvaddcode2.Text + "' ");

                    sb.AppendLine(") t2");
                    sb.AppendLine("left join Customer c");
                    sb.AppendLine("on c.cCuscode=t2.cCuscode ");
                    sb.AppendLine("");

                    SqlCommand cmdSelect = new SqlCommand(sb.ToString(), this.sqlConnection1);
                    this.sqlConnection1.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    dvResult.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误");
                }
                finally
                {
                    this.sqlConnection1.Close();
                }
        }
    }
}
