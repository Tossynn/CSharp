using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
class CalApp: Form
{
	private bool Status = false ;
	private bool isOperatorClicked = false ;
	private TextBox inputOperationTextBox;
	private Button inputButton1;
	private Button inputButton2;
	private Button inputButton3;
	private Button inputButton4;
	private Button inputButton5;
	private Button inputButton6;
	private Button inputButton7;
	private Button inputButton8;
	private Button inputButton9;
	private Button inputButton10;
	private Button inputButton11;
	private Button inputButton12;
	private Button inputButton13;
	private Button inputButton14;
	private Button inputButton15;
	private Button inputButton16;
	private Button inputButton17;
	private Button inputButton18;
	private Button inputButton19;
	private Button inputButton20;
	private Button inputButton21;
	private Button inputButton22;
	private Button inputButton23;
	private Button inputButton24;
	private Button inputButton25;
	private Button inputButton26;
	private Button inputButton27;
	private Button inputButton28;
	private Button inputButton29;
	
	private void InitializeComponet()
	{
		this.inputOperationTextBox = new TextBox();
		this.inputButton1 = new Button();
		this.inputButton2 = new Button();
		this.inputButton3 = new Button();
		this.inputButton4 = new Button();
		this.inputButton5 = new Button();
		this.inputButton6 = new Button();
		this.inputButton7 = new Button();
		this.inputButton8 = new Button();
		this.inputButton9 = new Button();
		this.inputButton10 = new Button();
		this.inputButton11 = new Button();
		this.inputButton12 = new Button();
		this.inputButton13 = new Button();
		this.inputButton14 = new Button();
		this.inputButton15 = new Button();
		this.inputButton16 = new Button();
		this.inputButton17 = new Button();
		this.inputButton18 = new Button();
		this.inputButton19 = new Button();
		this.inputButton20 = new Button();
		this.inputButton21 = new Button();
		this.inputButton22 = new Button();
		this.inputButton23 = new Button();
		this.inputButton24 = new Button();
		this.inputButton25 = new Button();
		this.inputButton26 = new Button();
		this.inputButton27 = new Button();
		this.inputButton28 = new Button();
		this.inputButton29 = new Button();
		this.SuspendLayout();
		
		this.inputOperationTextBox.Location = new System.Drawing.Point(0, 0);
		this.inputOperationTextBox.Multiline = true;
		this.inputOperationTextBox.Name = "inputOperationTextBox";
		this.inputOperationTextBox.Size = new System.Drawing.Size(297, 62);
		this.inputOperationTextBox.TabIndex = 1;
		this.inputOperationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif",19F);
		this.inputOperationTextBox.TextAlign= HorizontalAlignment.Right;
		
		this.inputButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.inputButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
        this.inputButton1.ForeColor = System.Drawing.Color.White;
		this.inputButton1.Location = new System.Drawing.Point(0, 141);
		this.inputButton1.Name = "inputButton1";
		this.inputButton1.Size = new System.Drawing.Size(57, 45);
		this.inputButton1.TabIndex = 8;
		this.inputButton1.Text = "7";
		this.inputButton1.Click += new System.EventHandler(this.inputButton_Click);
		
            this.inputButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.inputButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.inputButton2.ForeColor = System.Drawing.Color.White;
			this.inputButton2.Location = new System.Drawing.Point(60, 141);
			this.inputButton2.Name = "inputButton2";
			this.inputButton2.Size = new System.Drawing.Size(57, 45);
			this.inputButton2.TabIndex = 9;
			this.inputButton2.Text = "8";
			this.inputButton2.Click += new System.EventHandler(this.inputButton_Click);
			
		this.inputButton3.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
		this.inputButton3.ForeColor = System.Drawing.Color.White;
		this.inputButton3.Location = new System.Drawing.Point(120, 141);
		this.inputButton3.Name = "inputButton3";
		this.inputButton3.Size = new System.Drawing.Size(57, 45);
		this.inputButton3.TabIndex = 10;
		this.inputButton3.Text = "9";
		this.inputButton3.Click += new System.EventHandler(this.inputButton_Click);
		
			this.inputButton4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inputButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.inputButton4.ForeColor = System.Drawing.Color.White;
            this.inputButton4.Location = new System.Drawing.Point(0, 189);
            this.inputButton4.Name = "inputButton4";
            this.inputButton4.Size = new System.Drawing.Size(57, 45);
            this.inputButton4.TabIndex = 5;
            this.inputButton4.Text = "4";
			this.inputButton4.Click += new System.EventHandler(this.inputButton_Click);
			
		this.inputButton5.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
		this.inputButton5.ForeColor = System.Drawing.Color.White;
		this.inputButton5.Location = new System.Drawing.Point(60, 189);
		this.inputButton5.Name = "inputButton5";
		this.inputButton5.Size = new System.Drawing.Size(57, 45);
		this.inputButton5.TabIndex = 6;
		this.inputButton5.Text = "5";
		this.inputButton5.Click += new System.EventHandler(this.inputButton_Click);
		
			this.inputButton6.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.inputButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.inputButton6.ForeColor = System.Drawing.Color.White;
			this.inputButton6.Location = new System.Drawing.Point(120, 189);
			this.inputButton6.Name = "inputButton6";
			this.inputButton6.Size = new System.Drawing.Size(57, 45);
			this.inputButton6.TabIndex = 7;
			this.inputButton6.Text = "6";
			this.inputButton6.Click += new System.EventHandler(this.inputButton_Click);
			
		this.inputButton7.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
		this.inputButton7.ForeColor = System.Drawing.Color.White;
		this.inputButton7.Location = new System.Drawing.Point(0, 237);
		this.inputButton7.Name = "inputButton7";
		this.inputButton7.Size = new System.Drawing.Size(57, 45);
		this.inputButton7.TabIndex = 2;
		this.inputButton7.Text = "1";
		this.inputButton7.Click += new System.EventHandler(this.inputButton_Click);
		
			this.inputButton8.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.inputButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.inputButton8.ForeColor = System.Drawing.Color.White;
			this.inputButton8.Location = new System.Drawing.Point(60, 237);
			this.inputButton8.Name = "inputButton8";
			this.inputButton8.Size = new System.Drawing.Size(57, 45);
			this.inputButton8.TabIndex = 3;
			this.inputButton8.Text = "2";
			this.inputButton8.Click += new System.EventHandler(this.inputButton_Click);
		
		this.inputButton9.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
		this.inputButton9.ForeColor = System.Drawing.Color.White;
		this.inputButton9.Location = new System.Drawing.Point(120, 237);
		this.inputButton9.Name = "inputButton9";
		this.inputButton9.Size = new System.Drawing.Size(57, 45);
		this.inputButton9.TabIndex = 4;
		this.inputButton9.Text = "3";
		this.inputButton9.Click += new System.EventHandler(this.inputButton_Click);
		
			this.inputButton10.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.inputButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.inputButton10.ForeColor = System.Drawing.Color.White;
			this.inputButton10.Location = new System.Drawing.Point(0, 286);
			this.inputButton10.Name = "inputButton10";
			this.inputButton10.Size = new System.Drawing.Size(57, 45);
			this.inputButton10.TabIndex = 12;
			this.inputButton10.Text = "0";
			this.inputButton10.Click += new System.EventHandler(this.inputButton_Click);
			
		this.inputButton11.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
		this.inputButton11.ForeColor = System.Drawing.Color.White;
		this.inputButton11.Location = new System.Drawing.Point(60, 286);
		this.inputButton11.Name = "inputButton11";
		this.inputButton11.Size = new System.Drawing.Size(57, 45);
		this.inputButton11.TabIndex = 11;
		this.inputButton11.Text = ".";
		//this.inputButton11.Click += new System.EventHandler(this.zeroButton_Click);
		
			this.inputButton12.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.inputButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.inputButton12.ForeColor = System.Drawing.Color.White;
			this.inputButton12.Location = new System.Drawing.Point(120, 286);
			this.inputButton12.Name = "inputButton12";
			this.inputButton12.Size = new System.Drawing.Size(57, 45);
			this.inputButton12.TabIndex = 13;
			this.inputButton12.Text = "=";
		
			this.inputButton14.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.inputButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
			this.inputButton14.ForeColor = System.Drawing.Color.White;
			this.inputButton14.Location = new System.Drawing.Point(180, 141);
			this.inputButton14.Name = "inputButton14";
			this.inputButton14.Size = new System.Drawing.Size(47, 45);
			this.inputButton14.TabIndex = 15;
			this.inputButton14.Text = "/";
			//this.inputButton14.Click += new System.EventHandler(this.divideButton_Click);
		
		this.inputButton15.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
		this.inputButton15.ForeColor = System.Drawing.Color.White;
		this.inputButton15.Location = new System.Drawing.Point(180, 189);
		this.inputButton15.Name = "inputButton15";
		this.inputButton15.Size = new System.Drawing.Size(47, 45);
		this.inputButton15.TabIndex = 15;
		this.inputButton15.Text = "*";
		//this.inputButton15.Click += new System.EventHandler(this.multiplyButton_Click);
		
			this.inputButton16.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.inputButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
			this.inputButton16.ForeColor = System.Drawing.Color.White;
			this.inputButton16.Location = new System.Drawing.Point(180, 237);
			this.inputButton16.Name = "inputButton16";
			this.inputButton16.Size = new System.Drawing.Size(47, 45);
			this.inputButton16.TabIndex = 15;
			this.inputButton16.Text = "-";
			//this.inputButton16.Click += new System.EventHandler(this.subtractButton_Click);
			
		this.inputButton17.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton17.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
		this.inputButton17.ForeColor = System.Drawing.Color.White;
		this.inputButton17.Location = new System.Drawing.Point(180, 286);
		this.inputButton17.Name = "inputButton17";
		this.inputButton17.Size = new System.Drawing.Size(47, 45);
		this.inputButton17.TabIndex = 15;
		this.inputButton17.Text = "+";
		//this.inputButton17.Click += new System.EventHandler(this.addButton_Click);
		
		this.inputButton13.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
		this.inputButton13.ForeColor = System.Drawing.Color.White;
		this.inputButton13.Location = new System.Drawing.Point(180, 100);
		this.inputButton13.Name = "inputButton13";
		this.inputButton13.Size = new System.Drawing.Size(47, 35);
		this.inputButton13.TabIndex = 14;
		this.inputButton13.Text = "±";
		
		this.inputButton18.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
		this.inputButton18.ForeColor = System.Drawing.Color.White;
		this.inputButton18.Location = new System.Drawing.Point(120, 100);
		this.inputButton18.Name = "inputButton18";
		this.inputButton18.Size = new System.Drawing.Size(57, 35);
		this.inputButton18.TabIndex = 14;
		this.inputButton18.Text = "C";
		
		this.inputButton19.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
		this.inputButton19.ForeColor = System.Drawing.Color.White;
		this.inputButton19.Location = new System.Drawing.Point(60, 100);
		this.inputButton19.Name = "inputButton19";
		this.inputButton19.Size = new System.Drawing.Size(57, 35);
		this.inputButton19.TabIndex = 14;
		this.inputButton19.Text = "CE";
		
		this.inputButton20.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
		this.inputButton20.ForeColor = System.Drawing.Color.White;
		this.inputButton20.Location = new System.Drawing.Point(0, 100);
		this.inputButton20.Name = "inputButton20";
		this.inputButton20.Size = new System.Drawing.Size(57, 35);
		this.inputButton20.TabIndex = 14;
		this.inputButton20.Text = "←";
		
		this.inputButton21.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
		this.inputButton21.ForeColor = System.Drawing.Color.White;
		this.inputButton21.Location = new System.Drawing.Point(0, 62);
		this.inputButton21.Name = "inputButton21";
		this.inputButton21.Size = new System.Drawing.Size(57, 30);
		this.inputButton21.TabIndex = 14;
		this.inputButton21.Text = "MC";
		
		this.inputButton22.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
		this.inputButton22.ForeColor = System.Drawing.Color.White;
		this.inputButton22.Location = new System.Drawing.Point(60, 62);
		this.inputButton22.Name = "inputButton22";
		this.inputButton22.Size = new System.Drawing.Size(57, 30);
		this.inputButton22.TabIndex = 14;
		this.inputButton22.Text = "MR";
		
		this.inputButton23.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
		this.inputButton23.ForeColor = System.Drawing.Color.White;
		this.inputButton23.Location = new System.Drawing.Point(120, 62);
		this.inputButton23.Name = "inputButton23";
		this.inputButton23.Size = new System.Drawing.Size(57, 30);
		this.inputButton23.TabIndex = 14;
		this.inputButton23.Text = "MS";

		this.inputButton24.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
		this.inputButton24.ForeColor = System.Drawing.Color.White;
		this.inputButton24.Location = new System.Drawing.Point(180, 62);
		this.inputButton24.Name = "inputButton24";
		this.inputButton24.Size = new System.Drawing.Size(57, 30);
		this.inputButton24.TabIndex = 14;
		this.inputButton24.Text = "M+";
		
		this.inputButton25.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
		this.inputButton25.ForeColor = System.Drawing.Color.White;
		this.inputButton25.Location = new System.Drawing.Point(240, 62);
		this.inputButton25.Name = "inputButton25";
		this.inputButton25.Size = new System.Drawing.Size(57, 30);
		this.inputButton25.TabIndex = 14;
		this.inputButton25.Text = "M-";

		this.inputButton26.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
		this.inputButton26.ForeColor = System.Drawing.Color.White;
		this.inputButton26.Location = new System.Drawing.Point(235, 100);
		this.inputButton26.Name = "inputButton26";
		this.inputButton26.Size = new System.Drawing.Size(62, 35);
		this.inputButton26.TabIndex = 14;
		this.inputButton26.Text = "√";
		
		this.inputButton27.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
		this.inputButton27.ForeColor = System.Drawing.Color.White;
		this.inputButton27.Location = new System.Drawing.Point(235, 141);
		this.inputButton27.Name = "inputButton27";
		this.inputButton27.Size = new System.Drawing.Size(62, 35);
		this.inputButton27.TabIndex = 14;
		this.inputButton27.Text = "%";
		
		this.inputButton28.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
		this.inputButton28.ForeColor = System.Drawing.Color.White;
		this.inputButton28.Location = new System.Drawing.Point(235, 189);
		this.inputButton28.Name = "inputButton28";
		this.inputButton28.Size = new System.Drawing.Size(62, 35);
		this.inputButton28.TabIndex = 14;
		this.inputButton28.Text = "½";
		
		this.inputButton29.BackColor = System.Drawing.SystemColors.InactiveCaption;
		this.inputButton29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
		this.inputButton29.ForeColor = System.Drawing.Color.White;
		this.inputButton29.Location = new System.Drawing.Point(235, 237);
		this.inputButton29.Name = "inputButton29";
		this.inputButton29.Size = new System.Drawing.Size(62, 90);
		this.inputButton29.TabIndex = 14;
		this.inputButton29.Text = "ON";
		this.inputButton29.Click += new System.EventHandler(this.checkPowerButton_Click);
		
		this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(297, 360);
		this.Controls.Add(this.inputButton18);
		this.Controls.Add(this.inputButton19);
		this.Controls.Add(this.inputButton20);
		this.Controls.Add(this.inputButton21);
		this.Controls.Add(this.inputButton22);
		this.Controls.Add(this.inputButton23);
		this.Controls.Add(this.inputButton24);
		this.Controls.Add(this.inputButton25);
		this.Controls.Add(this.inputButton26);
		this.Controls.Add(this.inputButton27);
		this.Controls.Add(this.inputButton28);
		this.Controls.Add(this.inputButton29);
		this.Controls.Add(this.inputButton17);
		this.Controls.Add(this.inputButton16);
		this.Controls.Add(this.inputButton15);
		this.Controls.Add(this.inputButton14);
		this.Controls.Add(this.inputButton13);
		this.Controls.Add(this.inputButton12);
		this.Controls.Add(this.inputButton11);
		this.Controls.Add(this.inputButton10);
		this.Controls.Add(this.inputButton9);
		this.Controls.Add(this.inputButton8);
		this.Controls.Add(this.inputButton7);
		this.Controls.Add(this.inputButton6);
		this.Controls.Add(this.inputButton5);
		this.Controls.Add(this.inputButton3);
		this.Controls.Add(this.inputButton2);
		this.Controls.Add(this.inputButton1);
		this.Controls.Add(this.inputOperationTextBox);
		this.Controls.Add(this.inputButton4);
		this.Name = "Form1";
		this.Text = "CalculatorApplication";
		//this.Load += new System.EventHandler(this.Form1_Load);
		//this.ResumeLayout(false);
		this.PerformLayout();
	}
	private void inputButton_Click(Object sender, EventArgs e)
    {
        Button button = (Button) sender;
        string Text = button.Text;
		if (Status)
        {
            if (inputOperationTextBox.Text == "0" || this.isOperatorClicked)
            {
                inputOperationTextBox.Text = button.Text ;  
				this.isOperatorClicked = false ;    
            }
            else
            {
                inputOperationTextBox.Text += button.Text;
            }
        }
        else
        {
            MessageBox.Show("Please Switch ON Your calculator");
        }
	}
	    private void checkPowerButton_Click(Object Sender, EventArgs e)
    {
        if (inputButton29.Text.Equals("ON"))
        {
            inputButton29.Text ="OFF";
            inputOperationTextBox.Text ="0";
            Status= true;
        }
        else
        {
            inputButton29.Text="ON";
            inputOperationTextBox.Text ="";
            Status= false;
        }
    }
	static void Main()
	{
		Application.Run(new CalApp());
	}
	CalApp()
	{
		InitializeComponet();
	}
}