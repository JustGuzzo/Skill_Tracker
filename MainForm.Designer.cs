namespace Skill_Tracker
{
	partial class MainForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.save = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.openAnotherTaskListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.TablePanel);
			this.panel1.Location = new System.Drawing.Point(10, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(562, 322);
			this.panel1.TabIndex = 0;
			// 
			// TablePanel
			// 
			this.TablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TablePanel.AutoScroll = true;
			this.TablePanel.ColumnCount = 4;
			this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
			this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
			this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
			this.TablePanel.Location = new System.Drawing.Point(3, 3);
			this.TablePanel.Name = "TablePanel";
			this.TablePanel.RowCount = 2;
			this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TablePanel.Size = new System.Drawing.Size(556, 316);
			this.TablePanel.TabIndex = 3;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "st";
			this.saveFileDialog1.Filter = "Skill Tracker files (*.st)|*.st";
			this.saveFileDialog1.RestoreDirectory = true;
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "st";
			this.openFileDialog1.Filter = "Skill Tracker files (*.st)|*.st";
			this.openFileDialog1.InitialDirectory = ".";
			this.openFileDialog1.RestoreDirectory = true;
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.tasksToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(584, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save,
            this.saveAs,
            this.openAnotherTaskListToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.FileToolStripMenuItem.Text = "File";
			// 
			// save
			// 
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(114, 22);
			this.save.Text = "Save";
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// saveAs
			// 
			this.saveAs.Name = "saveAs";
			this.saveAs.Size = new System.Drawing.Size(114, 22);
			this.saveAs.Text = "Save As";
			this.saveAs.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
			// 
			// openAnotherTaskListToolStripMenuItem
			// 
			this.openAnotherTaskListToolStripMenuItem.Name = "openAnotherTaskListToolStripMenuItem";
			this.openAnotherTaskListToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
			this.openAnotherTaskListToolStripMenuItem.Text = "Open";
			this.openAnotherTaskListToolStripMenuItem.Click += new System.EventHandler(this.openAnotherTaskListToolStripMenuItem_Click);
			// 
			// tasksToolStripMenuItem
			// 
			this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTaskToolStripMenuItem,
            this.editTasksToolStripMenuItem});
			this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
			this.tasksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.tasksToolStripMenuItem.Text = "Tasks";
			// 
			// addNewTaskToolStripMenuItem
			// 
			this.addNewTaskToolStripMenuItem.Name = "addNewTaskToolStripMenuItem";
			this.addNewTaskToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.addNewTaskToolStripMenuItem.Text = "Add New Task";
			this.addNewTaskToolStripMenuItem.Click += new System.EventHandler(this.addNewTaskToolStripMenuItem_Click);
			// 
			// editTasksToolStripMenuItem
			// 
			this.editTasksToolStripMenuItem.Name = "editTasksToolStripMenuItem";
			this.editTasksToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.editTasksToolStripMenuItem.Text = "Edit Tasks";
			this.editTasksToolStripMenuItem.Click += new System.EventHandler(this.editTasksToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(600, 400);
			this.Name = "MainForm";
			this.Text = "Skill Tracker";
			this.panel1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel TablePanel;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAs;
		private System.Windows.Forms.ToolStripMenuItem openAnotherTaskListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem save;
		private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewTaskToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editTasksToolStripMenuItem;
	}
}

