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
			
			DateTime today = DateTime.Now;
			DateTime answer = today.AddDays(7);
			
			Mysql mysql = new Mysql();
			Dictionary<int, Dictionary<string, string>> all = mysql.Get("contracts");
			Dictionary<int, Dictionary<string, string>> date = mysql.GetDate(answer.ToString("yyyy-MM-dd H:m:s"));
			
			SetViewContracts(all);
		}
		
		public void SetViewContracts(Dictionary<int, Dictionary<string, string>> contracts)
		{
            DateTime today = DateTime.Now;
			DateTime answer = today.AddDays(7);
			
			listView1.Items.Clear();
            for(int i = 0; i < contracts.Count; i++)
			{
				ListViewItem item = null;
				for(int y = 0; y < listView1.Columns.Count; y++)
				{
					if(y == 0)
						item = listView1.Items.Add(contracts[i][listView1.Columns[y].Tag.ToString()]);
					else
					{
						item.SubItems.Add(contracts[i][listView1.Columns[y].Tag.ToString()]);
						
						if(listView1.Columns[y].Tag.ToString() == "date_end" && (DateTime.Parse(contracts[i][listView1.Columns[y].Tag.ToString()]) < answer))
						{
							item.SubItems[item.SubItems.Count - 1].ForeColor = System.Drawing.Color.YellowGreen;
							item.UseItemStyleForSubItems = false;
						}
						
						if(listView1.Columns[y].Tag.ToString() == "date_end" && (DateTime.Parse(contracts[i][listView1.Columns[y].Tag.ToString()]) <= today))
						{
							item.SubItems[item.SubItems.Count - 1].ForeColor = System.Drawing.Color.Red;
							item.UseItemStyleForSubItems = false;
						}
					}
						
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
            child.FormClosing += Form2_Closing; 
			child.Show();
		}

        private void Form2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Mysql mysql = new Mysql();
            Dictionary<int, Dictionary<string, string>> all = mysql.Get("contracts");
            SetViewContracts(all);
        }
        
        private void listView1_MouseClick(object sender, MouseEventArgs e)
	    {            
	        if (e.Button == MouseButtons.Right)
	        {
	            if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
	            {
	                contextMenuStrip1.Show(Cursor.Position);
	            }
	        } 
	    }
		
		void deleteToolStripMenuItemClick(object sender, EventArgs e)
		{
			Mysql mysql = new Mysql();
			mysql.Delete(listView1.SelectedItems[0].SubItems[0].Text);
			listView1.SelectedItems[0].Remove();
		}
	}
	
}
