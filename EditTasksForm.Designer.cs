namespace Skill_Tracker
{
	partial class EditTasksForm
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
			this.SaveButton = new System.Windows.Forms.Button();
			this.CancButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.SaveButton.Location = new System.Drawing.Point(3, 3);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 0;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// CancButton
			// 
			this.CancButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CancButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancButton.Location = new System.Drawing.Point(225, 3);
			this.CancButton.Name = "CancButton";
			this.CancButton.Size = new System.Drawing.Size(75, 23);
			this.CancButton.TabIndex = 1;
			this.CancButton.Text = "Cancel";
			this.CancButton.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.TablePanel);
			this.panel1.Location = new System.Drawing.Point(12, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(310, 236);
			this.panel1.TabIndex = 2;
			// 
			// TablePanel
			// 
			this.TablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TablePanel.AutoScroll = true;
			this.TablePanel.ColumnCount = 2;
			this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TablePanel.Location = new System.Drawing.Point(3, 3);
			this.TablePanel.Name = "TablePanel";
			this.TablePanel.RowCount = 2;
			this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TablePanel.Size = new System.Drawing.Size(301, 191);
			this.TablePanel.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel2.Controls.Add(this.SaveButton);
			this.panel2.Controls.Add(this.CancButton);
			this.panel2.Location = new System.Drawing.Point(4, 200);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(303, 33);
			this.panel2.TabIndex = 2;
			// 
			// EditTasksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 261);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(350, 300);
			this.Name = "EditTasksForm";
			this.Text = "EditTasksForm";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button CancButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel TablePanel;
		private System.Windows.Forms.Panel panel2;
	}
}