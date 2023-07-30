namespace Skill_Tracker
{
	partial class Form2
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.CancelAddingButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.Item_Name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Error_Item_Exist = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Error_Item_Exist)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.CancelAddingButton);
			this.panel1.Controls.Add(this.AddButton);
			this.panel1.Controls.Add(this.Item_Name);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(494, 423);
			this.panel1.TabIndex = 0;
			// 
			// CancelAddingButton
			// 
			this.CancelAddingButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelAddingButton.Location = new System.Drawing.Point(416, 397);
			this.CancelAddingButton.Name = "CancelAddingButton";
			this.CancelAddingButton.Size = new System.Drawing.Size(75, 23);
			this.CancelAddingButton.TabIndex = 3;
			this.CancelAddingButton.Text = "CANCEL";
			this.CancelAddingButton.UseVisualStyleBackColor = true;
			// 
			// AddButton
			// 
			this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.AddButton.Enabled = false;
			this.AddButton.Location = new System.Drawing.Point(4, 397);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 2;
			this.AddButton.Text = "ADD";
			this.AddButton.UseVisualStyleBackColor = true;
			// 
			// Item_Name
			// 
			this.Item_Name.Location = new System.Drawing.Point(4, 21);
			this.Item_Name.MaxLength = 23;
			this.Item_Name.Name = "Item_Name";
			this.Item_Name.Size = new System.Drawing.Size(196, 20);
			this.Item_Name.TabIndex = 1;
			this.Item_Name.TextChanged += new System.EventHandler(this.Item_Name_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Item Name (maximum 23 characters)";
			// 
			// Error_Item_Exist
			// 
			this.Error_Item_Exist.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
			this.Error_Item_Exist.ContainerControl = this;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 448);
			this.Controls.Add(this.panel1);
			this.Name = "Form2";
			this.Text = "Add New Item To List";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Error_Item_Exist)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button CancelAddingButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.TextBox Item_Name;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider Error_Item_Exist;
	}
}