namespace Skill_Tracker
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.TablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.AddButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.TablePanel);
			this.panel1.Controls.Add(this.AddButton);
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(714, 492);
			this.panel1.TabIndex = 0;
			// 
			// TablePanel
			// 
			this.TablePanel.AutoScroll = true;
			this.TablePanel.ColumnCount = 3;
			this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.TablePanel.Location = new System.Drawing.Point(3, 4);
			this.TablePanel.Name = "TablePanel";
			this.TablePanel.RowCount = 2;
			this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TablePanel.Size = new System.Drawing.Size(708, 456);
			this.TablePanel.TabIndex = 3;
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(3, 466);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(118, 23);
			this.AddButton.TabIndex = 2;
			this.AddButton.Text = "ADD";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 519);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Skill Tracker";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.TableLayoutPanel TablePanel;
	}
}

