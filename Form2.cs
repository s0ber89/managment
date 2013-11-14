/*
 * Created by SharpDevelop.
 * User: Sokolov
 * Date: 23.09.2013
 * Time: 14:04
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
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			Mysql mysql = new Mysql();
			Dictionary<int, Dictionary<string, string>> type = mysql.Get("contract_type");
			ComboBox typeCombo = (ComboBox) comboBox1;
			
			for(int i = 0; i < type.Count; i++)
			{
				typeCombo.Items.Add(type[i]["title"]);
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			TextBox number = (TextBox) textBox1;
			TextBox organization = (TextBox) textBox2;
			TextBox name = (TextBox) textBox3;
			ComboBox type = (ComboBox) comboBox1;
			
			DateTimePicker dateStart = (DateTimePicker) dateTimePicker1;
			DateTimePicker dateEnd = (DateTimePicker) dateTimePicker2;
			
			MessageBox.Show(dateStart.Value.ToString());
			
			Dictionary<string, string> data = new Dictionary<string, string>();
			
			//data.
			
			//Mysql mysql = new Mysql();
			//mysql.Set("contract", data);
		}
	}
}
