/*
 * Created by SharpDevelop.
 * User: Sokolov
 * Date: 23.09.2013
 * Time: 10:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql;
using System.Collections.Generic;

namespace managment
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			TextBox tb = (TextBox) textBox1;
			Dictionary<string, string> data = new Dictionary<string, string>();
			data["title"] = tb.Text.ToString();
			Mysql mysql = new Mysql();
			mysql.Set("contract_type", data);
			this.Close();
			MessageBox.Show("Тип договора добавлен");
		}
	}
}
