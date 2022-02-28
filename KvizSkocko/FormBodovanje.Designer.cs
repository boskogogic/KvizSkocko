namespace KvizSkocko
{
	partial class FormBodovanje
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
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Image = global::KvizSkocko.Properties.Resources.BodovanjeKONACNO;
			this.label1.Location = new System.Drawing.Point(-2, -8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(505, 717);
			this.label1.TabIndex = 0;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// FormBodovanje
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 691);
			this.Controls.Add(this.label1);
			this.Name = "FormBodovanje";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormBodovanje";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
	}
}