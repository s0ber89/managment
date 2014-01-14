/*
 * Created by SharpDevelop.
 * User: Sokolov
 * Date: 11.09.2013
 * Time: 10:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace managment
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьДоговорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьТипДоговораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.listView1 = new System.Windows.Forms.ListView();
			this.id = new System.Windows.Forms.ColumnHeader();
			this.name = new System.Windows.Forms.ColumnHeader();
			this.organization_name = new System.Windows.Forms.ColumnHeader();
			this.date_start = new System.Windows.Forms.ColumnHeader();
			this.date_end = new System.Windows.Forms.ColumnHeader();
			this.addContractBtn = new System.Windows.Forms.Button();
			this.addTypeContractBtn = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuFile,
									this.toolStripMenuEdit,
									this.toolStripMenuSearch});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuFile
			// 
			this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.добавитьДоговорToolStripMenuItem,
									this.добавитьТипДоговораToolStripMenuItem});
			this.toolStripMenuFile.Name = "toolStripMenuFile";
			this.toolStripMenuFile.Size = new System.Drawing.Size(48, 20);
			this.toolStripMenuFile.Text = "Файл";
			// 
			// добавитьДоговорToolStripMenuItem
			// 
			this.добавитьДоговорToolStripMenuItem.Name = "добавитьДоговорToolStripMenuItem";
			this.добавитьДоговорToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.добавитьДоговорToolStripMenuItem.Text = "Добавить договор";
			this.добавитьДоговорToolStripMenuItem.Click += new System.EventHandler(this.AddContractBtnClick);
			// 
			// добавитьТипДоговораToolStripMenuItem
			// 
			this.добавитьТипДоговораToolStripMenuItem.Name = "добавитьТипДоговораToolStripMenuItem";
			this.добавитьТипДоговораToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.добавитьТипДоговораToolStripMenuItem.Text = "Добавить тип договора";
			this.добавитьТипДоговораToolStripMenuItem.Click += new System.EventHandler(this.AddTypeContractBtnClick);
			// 
			// toolStripMenuEdit
			// 
			this.toolStripMenuEdit.Name = "toolStripMenuEdit";
			this.toolStripMenuEdit.Size = new System.Drawing.Size(59, 20);
			this.toolStripMenuEdit.Text = "Правка";
			// 
			// toolStripMenuSearch
			// 
			this.toolStripMenuSearch.Name = "toolStripMenuSearch";
			this.toolStripMenuSearch.Size = new System.Drawing.Size(54, 20);
			this.toolStripMenuSearch.Text = "Поиск";
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.id,
									this.name,
									this.organization_name,
									this.date_start,
									this.date_end});
			this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.Location = new System.Drawing.Point(12, 27);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(916, 477);
			this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
			// 
			// id
			// 
			this.id.Tag = "id";
			this.id.Text = "Номер договора";
			this.id.Width = 107;
			// 
			// name
			// 
			this.name.Tag = "name";
			this.name.Text = "Название договора";
			this.name.Width = 217;
			// 
			// organization_name
			// 
			this.organization_name.Tag = "organization_name";
			this.organization_name.Text = "Наименование организации";
			this.organization_name.Width = 359;
			// 
			// date_start
			// 
			this.date_start.Tag = "date_start";
			this.date_start.Text = "Дата подписания";
			this.date_start.Width = 111;
			// 
			// date_end
			// 
			this.date_end.Tag = "date_end";
			this.date_end.Text = "Дата окончания";
			this.date_end.Width = 117;
			// 
			// addContractBtn
			// 
			this.addContractBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addContractBtn.Location = new System.Drawing.Point(934, 126);
			this.addContractBtn.Name = "addContractBtn";
			this.addContractBtn.Size = new System.Drawing.Size(198, 23);
			this.addContractBtn.TabIndex = 2;
			this.addContractBtn.Text = "Добавить договор";
			this.addContractBtn.UseVisualStyleBackColor = true;
			this.addContractBtn.Click += new System.EventHandler(this.AddContractBtnClick);
			// 
			// addTypeContractBtn
			// 
			this.addTypeContractBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addTypeContractBtn.Location = new System.Drawing.Point(934, 155);
			this.addTypeContractBtn.Name = "addTypeContractBtn";
			this.addTypeContractBtn.Size = new System.Drawing.Size(198, 23);
			this.addTypeContractBtn.TabIndex = 3;
			this.addTypeContractBtn.Text = "Добавить тип договора";
			this.addTypeContractBtn.UseVisualStyleBackColor = true;
			this.addTypeContractBtn.Click += new System.EventHandler(this.AddTypeContractBtnClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.удалитьToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1144, 516);
			this.Controls.Add(this.addTypeContractBtn);
			this.Controls.Add(this.addContractBtn);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "ООО \"НИИТОНХиБТ\"";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem добавитьТипДоговораToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem добавитьДоговорToolStripMenuItem;
		private System.Windows.Forms.Button addTypeContractBtn;
		private System.Windows.Forms.Button addContractBtn;
		private System.Windows.Forms.ColumnHeader date_end;
		private System.Windows.Forms.ColumnHeader date_start;
		private System.Windows.Forms.ColumnHeader organization_name;
		private System.Windows.Forms.ColumnHeader name;
		public System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuSearch;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuEdit;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
