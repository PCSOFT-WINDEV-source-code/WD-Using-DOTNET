using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using WL;

namespace EuroConverter
{
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label STC_LABEL1;
		private System.Windows.Forms.ComboBox CBOX_SOURCE;
		private System.Windows.Forms.TextBox EDT_SOURCE;
		private System.Windows.Forms.Label STC_SOURCE;
		private System.Windows.Forms.ComboBox CBOX_TARGET;
		private System.Windows.Forms.TextBox EDT_TARGET;
		private System.Windows.Forms.Label STC_TARGET;
		private System.Windows.Forms.Button BTN_EXIT;
        private System.ComponentModel.Container components = null;
		
		private cEuro gEuro;		//cEURO.DLL generated from WinDev
		private	bool bSource;		//Source
		private bool bTarget;		//Target
        		
		public Form1()
		{
			InitializeComponent();
		
			int Val1=0;
			int Val2=1;
			gEuro=new cEuro(Val1,Val2);
			bSource=false; bTarget=false;

		}

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.STC_LABEL1 = new System.Windows.Forms.Label();
            this.CBOX_SOURCE = new System.Windows.Forms.ComboBox();
            this.EDT_SOURCE = new System.Windows.Forms.TextBox();
            this.STC_SOURCE = new System.Windows.Forms.Label();
            this.CBOX_TARGET = new System.Windows.Forms.ComboBox();
            this.EDT_TARGET = new System.Windows.Forms.TextBox();
            this.STC_TARGET = new System.Windows.Forms.Label();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // STC_LABEL1
            // 
            this.STC_LABEL1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_LABEL1.Location = new System.Drawing.Point(8, 8);
            this.STC_LABEL1.Name = "STC_LABEL1";
            this.STC_LABEL1.Size = new System.Drawing.Size(416, 23);
            this.STC_LABEL1.TabIndex = 0;
            this.STC_LABEL1.Text = "Currency converter";
            // 
            // CBOX_SOURCE
            // 
            this.CBOX_SOURCE.Items.AddRange(new object[] {
            "Euro",
            "French Francs",
            "Italian Lira",
            "Belgian Francs",
            "Luxembourg Francs",
            "German Marks",
            "Austrian Schillings",
            "Pesatas",
            "Irish Pounds",
            "Dutch Florins",
            "Portuguese Escudos",
            "Greek Drachmae",
            "Finnish Marks",
            "Slovenian Tolar"});
            this.CBOX_SOURCE.Location = new System.Drawing.Point(8, 40);
            this.CBOX_SOURCE.Name = "CBOX_SOURCE";
            this.CBOX_SOURCE.Size = new System.Drawing.Size(176, 21);
            this.CBOX_SOURCE.TabIndex = 1;
            this.CBOX_SOURCE.Text = "CBOX_SOURCE";
            this.CBOX_SOURCE.SelectedIndexChanged += new System.EventHandler(this.CBOX_SOURCE_SelectedIndexChanged);
            // 
            // EDT_SOURCE
            // 
            this.EDT_SOURCE.Location = new System.Drawing.Point(192, 40);
            this.EDT_SOURCE.Name = "EDT_SOURCE";
            this.EDT_SOURCE.Size = new System.Drawing.Size(160, 20);
            this.EDT_SOURCE.TabIndex = 2;
            this.EDT_SOURCE.Text = "CONTROL_SOURCE";
            this.EDT_SOURCE.TextChanged += new System.EventHandler(this.EDT_SOURCE_TextChanged);
            this.EDT_SOURCE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EDT_SOURCE_KeyDown);
            // 
            // STC_SOURCE
            // 
            this.STC_SOURCE.Location = new System.Drawing.Point(360, 40);
            this.STC_SOURCE.Name = "STC_SOURCE";
            this.STC_SOURCE.Size = new System.Drawing.Size(48, 24);
            this.STC_SOURCE.TabIndex = 3;
            this.STC_SOURCE.Text = "EURO";
            this.STC_SOURCE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CBOX_TARGET
            // 
            this.CBOX_TARGET.Items.AddRange(new object[] {
            "Euro",
            "French Francs",
            "Italian Lira",
            "Belgian Francs",
            "Luxembourg Francs",
            "German Marks",
            "Austrian Schillings",
            "Pesatas",
            "Irish Pounds",
            "Dutch Florins",
            "Portuguese Escudos",
            "Greek Drachmae",
            "Finnish Marks",
            "Slovenian Tolar"});
            this.CBOX_TARGET.Location = new System.Drawing.Point(8, 72);
            this.CBOX_TARGET.Name = "CBOX_TARGET";
            this.CBOX_TARGET.Size = new System.Drawing.Size(176, 21);
            this.CBOX_TARGET.TabIndex = 4;
            this.CBOX_TARGET.Text = "COMBO_TARGET";
            this.CBOX_TARGET.SelectedIndexChanged += new System.EventHandler(this.CBOX_TARGET_SelectedIndexChanged);
            // 
            // EDT_TARGET
            // 
            this.EDT_TARGET.Location = new System.Drawing.Point(192, 72);
            this.EDT_TARGET.Name = "EDT_TARGET";
            this.EDT_TARGET.Size = new System.Drawing.Size(160, 20);
            this.EDT_TARGET.TabIndex = 5;
            this.EDT_TARGET.Text = "CONTROL_TARGET";
            this.EDT_TARGET.TextChanged += new System.EventHandler(this.EDT_TARGET_TextChanged);
            this.EDT_TARGET.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EDT_TARGET_KeyDown);
            // 
            // STC_TARGET
            // 
            this.STC_TARGET.Location = new System.Drawing.Point(360, 72);
            this.STC_TARGET.Name = "STC_TARGET";
            this.STC_TARGET.Size = new System.Drawing.Size(48, 24);
            this.STC_TARGET.TabIndex = 6;
            this.STC_TARGET.Text = "EURO";
            this.STC_TARGET.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_EXIT.Location = new System.Drawing.Point(336, 104);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(75, 23);
            this.BTN_EXIT.TabIndex = 7;
            this.BTN_EXIT.Text = "Exit";
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.BTN_EXIT;
            this.ClientSize = new System.Drawing.Size(416, 134);
            this.Controls.Add(this.BTN_EXIT);
            this.Controls.Add(this.STC_TARGET);
            this.Controls.Add(this.EDT_TARGET);
            this.Controls.Add(this.CBOX_TARGET);
            this.Controls.Add(this.STC_SOURCE);
            this.Controls.Add(this.EDT_SOURCE);
            this.Controls.Add(this.CBOX_SOURCE);
            this.Controls.Add(this.STC_LABEL1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "C# Euro Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form2());
			Application.Run(new Form1());
		}
		
		
		private void SourceToTarget()
		{
			double dValue;
			int nWay;
            nWay = 1;
			
			if (EDT_SOURCE.Text != "")
			{
				try
				{
                    dValue = double.Parse(EDT_SOURCE.Text);
                    EDT_TARGET.Text = gEuro.ConvertCurrency(dValue, nWay).ToString();
				}
				catch (Exception e2)
				{
					MessageBox.Show("Incorrect value\n" + e2.ToString());
				}
			}
		}

		private void TargetToSource()
		{

            double dValue;
            int nWay;
            nWay = 2;
			
			if (EDT_TARGET.Text != "")
			{
				try
				{
                    dValue = double.Parse(EDT_TARGET.Text);
                    EDT_SOURCE.Text = gEuro.ConvertCurrency(dValue, nWay).ToString();
				}
				catch (Exception e2)
				{
                    MessageBox.Show("Incorrect value" + e2.ToString());
				}
			}
		}
		private void Form1_Load(object sender, System.EventArgs e)
		{
			
			bSource=true;bTarget=true;

			CBOX_SOURCE.SelectedIndex=0;
			CBOX_TARGET.SelectedIndex=1;
			bSource=false;
			EDT_TARGET.Text="100,00";
			bTarget=false;
		}

		private void CBOX_SOURCE_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int nCurVal;	
			int nOrder;	
			
			
			nCurVal=CBOX_SOURCE.SelectedIndex+1;
			gEuro.FixSourceCurrency(nCurVal);
			
			nOrder=1;
			STC_SOURCE.Text=gEuro.EuroCaption(nOrder);
			
			if (bSource == false)
			{
				TargetToSource();
			}		
		}

	
		private void EDT_SOURCE_TextChanged(object sender, System.EventArgs e)
		{
			
			if (bTarget == false)
            {
				SourceToTarget();
			}			
		}

		private void CBOX_TARGET_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int nCurVal;	
			int nOrder;	
						
			nCurVal=CBOX_TARGET.SelectedIndex+1;
			gEuro.FixTargetCurrency(nCurVal);
            			
			nOrder=2;
			STC_TARGET.Text=gEuro.EuroCaption(nOrder);

			if (bTarget == false)
			{
				SourceToTarget();
			}
		}

		private void EDT_TARGET_TextChanged(object sender, System.EventArgs e)
		{
			if (bSource == false)
			{
				TargetToSource();
			}
		}

		private void EDT_SOURCE_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			bSource=true;bTarget=false;
		}

		private void EDT_TARGET_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			bSource=false;bTarget=true;
		}

		private void BTN_EXIT_Click(object sender, System.EventArgs e)
		{
			Close();		

		}
	}
}
