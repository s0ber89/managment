/*
 * Created by SharpDevelop.
 * User: Sokolov
 * Date: 11.09.2013
 * Time: 10:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql;

namespace managment
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Mysql mysql = new Mysql();
			Dictionary<int, Dictionary<string, string>> all = mysql.Get("contracts");
			SetViewContracts(all);
		}
		
		public void SetViewContracts(Dictionary<int, Dictionary<string, string>> contracts)
		{
			for(int i = 0; i < contracts.Count; i++)
			{
				ListViewItem item = null;
				for(int y = 0; y < listView1.Columns.Count; y++)
				{
					if(y == 0)
						item = listView1.Items.Add(contracts[i][listView1.Columns[y].Tag.ToString()]);
					else
						item.SubItems.Add(contracts[i][listView1.Columns[y].Tag.ToString()]);
					//MessageBox.Show(contracts[i][listView1.Columns[y].Tag.ToString()]);
				}
			}
			
		}
		
		
		void AddTypeContractBtnClick(object sender, EventArgs e)
		{
			Form1 child = new Form1();
			child.Show();
		}
		
		void AddContractBtnClick(object sender, EventArgs e)
		{
			Form2 child = new Form2();
			child.Show();
		}
	}
	
}
