using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EuroConverter
{
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label STC_PRESENTATION;
		private System.Windows.Forms.Label STC_LABEL1;
		private System.Windows.Forms.Label STC_LABEL2;
		private System.Windows.Forms.Button BTN_VALIDATE;
		private System.ComponentModel.Container components = null;

		public Form2()
		{
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Generated code
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.STC_PRESENTATION = new System.Windows.Forms.Label();
            this.STC_LABEL1 = new System.Windows.Forms.Label();
            this.STC_LABEL2 = new System.Windows.Forms.Label();
            this.BTN_VALIDATE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // STC_PRESENTATION
            // 
            this.STC_PRESENTATION.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_PRESENTATION.Location = new System.Drawing.Point(8, 48);
            this.STC_PRESENTATION.Name = "STC_PRESENTATION";
            this.STC_PRESENTATION.Size = new System.Drawing.Size(488, 139);
            this.STC_PRESENTATION.TabIndex = 0;
            this.STC_PRESENTATION.Text = resources.GetString("STC_PRESENTATION.Text");
            // 
            // STC_LABEL1
            // 
            this.STC_LABEL1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_LABEL1.Location = new System.Drawing.Point(8, 8);
            this.STC_LABEL1.Name = "STC_LABEL1";
            this.STC_LABEL1.Size = new System.Drawing.Size(256, 32);
            this.STC_LABEL1.TabIndex = 1;
            this.STC_LABEL1.Text = "Example description";
            // 
            // STC_LABEL2
            // 
            this.STC_LABEL2.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_LABEL2.Location = new System.Drawing.Point(8, 187);
            this.STC_LABEL2.Name = "STC_LABEL2";
            this.STC_LABEL2.Size = new System.Drawing.Size(168, 23);
            this.STC_LABEL2.TabIndex = 2;
            this.STC_LABEL2.Text = "Copyright : PC SOFT";
            // 
            // BTN_VALIDATE
            // 
            this.BTN_VALIDATE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_VALIDATE.Location = new System.Drawing.Point(214, 209);
            this.BTN_VALIDATE.Name = "BTN_VALIDATE";
            this.BTN_VALIDATE.Size = new System.Drawing.Size(75, 23);
            this.BTN_VALIDATE.TabIndex = 3;
            this.BTN_VALIDATE.Text = "OK";
            this.BTN_VALIDATE.Click += new System.EventHandler(this.BTN_VALIDATE_Click);
            // 
            // Form2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(496, 238);
            this.Controls.Add(this.BTN_VALIDATE);
            this.Controls.Add(this.STC_LABEL2);
            this.Controls.Add(this.STC_LABEL1);
            this.Controls.Add(this.STC_PRESENTATION);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "WD Using DOTNET";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void Form2_Load(object sender, System.EventArgs e)
		{
		
		}

		private void BTN_VALIDATE_Click(object sender, System.EventArgs e)
		{
			Close();
		}






		
	}
}
