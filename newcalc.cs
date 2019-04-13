using System;
using System.Windows.Forms;
using System.Drawing;
class CalApp: Form
{
	private double ans ;
	private string operationType = "" ;
	private bool isOperatorClicked = false ;
	private string resultValue = "" ;
	private double addstore;
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
		
		
		this.inputOperationTextBox.Multiline = true;
		this.inputOperationTextBox.Font= new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputOperationTextBox.Name = "inputOperationTextBox";
		this.inputOperationTextBox.Size = new Size(300, 40);
		this.inputOperationTextBox.Location = new Point(0, 20);
        this.inputOperationTextBox.TextAlign= HorizontalAlignment.Right;
		
		this.inputButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.inputButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.inputButton1.ForeColor = System.Drawing.Color.White;
		this.inputButton1.Location = new System.Drawing.Point(0, 60);
		this.inputButton1.Name = "inputButton1";
		this.inputButton1.Size = new System.Drawing.Size(60, 40);
		this.inputButton1.TabIndex = 1;
		this.inputButton1.Text = "MC";
		this.inputButton1.Click+= new System.EventHandler(this.MC_Click);
		
		this.inputButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton2.ForeColor = System.Drawing.Color.White;
		this.inputButton2.Location = new System.Drawing.Point(0, 100);
		this.inputButton2.Name = "inputButton2";
		this.inputButton2.Size = new System.Drawing.Size(60, 40);
		this.inputButton2.TabIndex = 2;
		this.inputButton2.Text = "←";
        this.inputButton2.Click+= new System.EventHandler(this.backButton_Click);
			
		this.inputButton3.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton3.ForeColor = System.Drawing.Color.White;
		this.inputButton3.Location = new System.Drawing.Point(0, 140);
		this.inputButton3.Name = "inputButton3";
		this.inputButton3.Size = new System.Drawing.Size(60, 40);
		this.inputButton3.TabIndex = 3;
		this.inputButton3.Text = "7";
		this.inputButton3.Click += new System.EventHandler(this.inputButton_Click);
		
		this.inputButton4.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton4.ForeColor = System.Drawing.Color.White;
		this.inputButton4.Location = new System.Drawing.Point(0, 180);
		this.inputButton4.Name = "inputButton4";
		this.inputButton4.Size = new System.Drawing.Size(60, 40);
		this.inputButton4.TabIndex = 4;
		this.inputButton4.Text = "4";
		this.inputButton4.Click += new System.EventHandler(this.inputButton_Click);
			
		this.inputButton5.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton5.ForeColor = System.Drawing.Color.White;
		this.inputButton5.Location = new System.Drawing.Point(0, 220);
		this.inputButton5.Name = "inputButton5";
		this.inputButton5.Size = new System.Drawing.Size(60, 40);
		this.inputButton5.TabIndex = 5;
		this.inputButton5.Text = "1";
		this.inputButton5.Click += new System.EventHandler(this.inputButton_Click);
		
		this.inputButton6.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton6.ForeColor = System.Drawing.Color.White;
		this.inputButton6.Location = new System.Drawing.Point(60, 60);
		this.inputButton6.Name = "inputButton6";
		this.inputButton6.Size = new System.Drawing.Size(60, 40);
		this.inputButton6.TabIndex = 6;
		this.inputButton6.Text = "MR";
		this.inputButton6.Click += new System.EventHandler(this.MR_Click);
			
		this.inputButton7.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton7.ForeColor = System.Drawing.Color.White;
		this.inputButton7.Location = new System.Drawing.Point(60, 100);
		this.inputButton7.Name = "inputButton7";
		this.inputButton7.Size = new System.Drawing.Size(60, 40);
		this.inputButton7.TabIndex = 7;
		this.inputButton7.Text = "CE";
		
		this.inputButton8.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton8.ForeColor = System.Drawing.Color.White;
		this.inputButton8.Location = new System.Drawing.Point(60, 140);
		this.inputButton8.Name = "inputButton8";
		this.inputButton8.Size = new System.Drawing.Size(60, 40);
		this.inputButton8.TabIndex = 8;
		this.inputButton8.Text = "8";
		this.inputButton8.Click += new System.EventHandler(this.inputButton_Click);
		
		this.inputButton9.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton9.ForeColor = System.Drawing.Color.White;
		this.inputButton9.Location = new System.Drawing.Point(60, 180);
		this.inputButton9.Name = "inputButton9";
		this.inputButton9.Size = new System.Drawing.Size(60, 40);
		this.inputButton9.TabIndex = 9;
		this.inputButton9.Text = "5";
		this.inputButton9.Click += new System.EventHandler(this.inputButton_Click);
		
		this.inputButton10.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton10.ForeColor = System.Drawing.Color.White;
		this.inputButton10.Location = new System.Drawing.Point(60, 220);
		this.inputButton10.Name = "inputButton10";
		this.inputButton10.Size = new System.Drawing.Size(60, 40);
		this.inputButton10.TabIndex = 10;
		this.inputButton10.Text = "2";
		this.inputButton10.Click += new System.EventHandler(this.inputButton_Click);
			
		this.inputButton11.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton11.ForeColor = System.Drawing.Color.White;
		this.inputButton11.Location = new System.Drawing.Point(60, 260);
		this.inputButton11.Name = "button11";
		this.inputButton11.Size = new System.Drawing.Size(60, 40);
		this.inputButton11.TabIndex = 11;
		this.inputButton11.Text = "0";
		this.inputButton11.Click += new System.EventHandler(this.inputButton_Click);
		

		this.inputButton12.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton12.ForeColor = System.Drawing.Color.White;
		this.inputButton12.Location = new System.Drawing.Point(120, 60);
		this.inputButton12.Name = "button12";
		this.inputButton12.Size = new System.Drawing.Size(60, 40);
		this.inputButton12.TabIndex = 12;
		this.inputButton12.Text = "MS";
		this.inputButton12.Click += new System.EventHandler(this.MS_Click);

		this.inputButton13.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton13.ForeColor = System.Drawing.Color.White;
		this.inputButton13.Location = new System.Drawing.Point(120, 100);
		this.inputButton13.Name = "button13";
		this.inputButton13.Size = new System.Drawing.Size(60, 40);
		this.inputButton13.TabIndex = 13;
		this.inputButton13.Text = "C";
		this.inputButton13.Click += new System.EventHandler(this.inputButton13_Click);

		this.inputButton14.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton14.ForeColor = System.Drawing.Color.White;
		this.inputButton14.Location = new System.Drawing.Point(120, 140);
		this.inputButton14.Name = "button14";
		this.inputButton14.Size = new System.Drawing.Size(60, 40);
		this.inputButton14.TabIndex = 14;
		this.inputButton14.Text = "9";
		this.inputButton14.Click += new System.EventHandler(this.inputButton_Click);

		this.inputButton15.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton15.ForeColor = System.Drawing.Color.White;
		this.inputButton15.Location = new System.Drawing.Point(120, 180);
		this.inputButton15.Name = "button15";
		this.inputButton15.Size = new System.Drawing.Size(60, 40);
		this.inputButton15.TabIndex = 15;
		this.inputButton15.Text = "6";
		this.inputButton15.Click += new System.EventHandler(this.inputButton_Click);

		this.inputButton16.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton16.ForeColor = System.Drawing.Color.White;
		this.inputButton16.Location = new System.Drawing.Point(120, 220);
		this.inputButton16.Name = "button16";
		this.inputButton16.Size = new System.Drawing.Size(60, 40);
		this.inputButton16.TabIndex = 16;
		this.inputButton16.Text = "3";
		this.inputButton16.Click += new System.EventHandler(this.inputButton_Click);

		this.inputButton17.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton17.ForeColor = System.Drawing.Color.White;
		this.inputButton17.Location = new System.Drawing.Point(120, 260);
		this.inputButton17.Name = "button17";
		this.inputButton17.Size = new System.Drawing.Size(60, 40);
		this.inputButton17.TabIndex = 17;
		this.inputButton17.Text = ".";
		this.inputButton17.Click += new System.EventHandler(this.dotButton_Click);


		this.inputButton18.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton18.ForeColor = System.Drawing.Color.White;
		this.inputButton18.Location = new System.Drawing.Point(180, 60);
		this.inputButton18.Name = "button18";
		this.inputButton18.Size = new System.Drawing.Size(60, 40);
		this.inputButton18.TabIndex = 18;
		this.inputButton18.Text = "M+";
		this.inputButton18.Click += new System.EventHandler(this.Mstore_Click);

		this.inputButton19.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton19.ForeColor = System.Drawing.Color.White;
		this.inputButton19.Location = new System.Drawing.Point(180, 100);
		this.inputButton19.Name = "button19";
		this.inputButton19.Size = new System.Drawing.Size(60, 40);
		this.inputButton19.TabIndex = 19;
		this.inputButton19.Text = "±";

		this.inputButton20.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton20.ForeColor = System.Drawing.Color.White;
		this.inputButton20.Location = new System.Drawing.Point(180, 140);
		this.inputButton20.Name = "button20";
		this.inputButton20.Size = new System.Drawing.Size(60, 40);
		this.inputButton20.TabIndex = 12;
		this.inputButton20.Text = "/";
		this.inputButton20.Click += new System.EventHandler(this.operationPerform_Click);

		this.inputButton21.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton21.ForeColor = System.Drawing.Color.White;
		this.inputButton21.Location = new System.Drawing.Point(180, 180);
		this.inputButton21.Name = "button21";
		this.inputButton21.Size = new System.Drawing.Size(60, 40);
		this.inputButton21.TabIndex = 21;
		this.inputButton21.Text = "*";
		this.inputButton21.Click += new System.EventHandler(this.operationPerform_Click);

		this.inputButton22.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton22.ForeColor = System.Drawing.Color.White;
		this.inputButton22.Location = new System.Drawing.Point(180, 220);
		this.inputButton22.Name = "button22";
		this.inputButton22.Size = new System.Drawing.Size(60, 40);
		this.inputButton22.TabIndex = 22;
		this.inputButton22.Text = "-";
		this.inputButton22.Click += new System.EventHandler(this.operationPerform_Click);

		this.inputButton23.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton23.ForeColor = System.Drawing.Color.White;
		this.inputButton23.Location = new System.Drawing.Point(180, 260);
		this.inputButton23.Name = "button23";
		this.inputButton23.Size = new System.Drawing.Size(60, 40);
		this.inputButton23.TabIndex = 23;
		this.inputButton23.Text = "+";
		this.inputButton23.Click += new System.EventHandler(this.operationPerform_Click);

		this.inputButton24.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton24.ForeColor = System.Drawing.Color.White;
		this.inputButton24.Location = new System.Drawing.Point(240, 60);
		this.inputButton24.Name = "button24";
		this.inputButton24.Size = new System.Drawing.Size(60, 40);
		this.inputButton24.TabIndex = 24;
		this.inputButton24.Text = "M-";
		this.inputButton24.Click += new System.EventHandler(this.substore_Click);

		this.inputButton25.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton25.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton25.ForeColor = System.Drawing.Color.White;
		this.inputButton25.Location = new System.Drawing.Point(240, 100);
		this.inputButton25.Name = "button25";
		this.inputButton25.Size = new System.Drawing.Size(60, 40);
		this.inputButton25.TabIndex = 25;
		this.inputButton25.Text = "++";

		this.inputButton26.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton26.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton26.ForeColor = System.Drawing.Color.White;
		this.inputButton26.Location = new System.Drawing.Point(240, 140);
		this.inputButton26.Name = "button26";
		this.inputButton26.Size = new System.Drawing.Size(60, 40);
		this.inputButton26.TabIndex = 26;
		this.inputButton26.Text = "%";


		this.inputButton27.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton27.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton27.ForeColor = System.Drawing.Color.White;
		this.inputButton27.Location = new System.Drawing.Point(240, 180);
		this.inputButton27.Name = "button27";
		this.inputButton27.Size = new System.Drawing.Size(60, 40);
		this.inputButton27.TabIndex = 27;
		this.inputButton27.Text = "½";


		this.inputButton28.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton28.ForeColor = System.Drawing.Color.White;
		this.inputButton28.Location = new System.Drawing.Point(240, 220);
		this.inputButton28.Name = "button28";
		this.inputButton28.Size = new System.Drawing.Size(60, 80);
		this.inputButton28.TabIndex = 28;
		this.inputButton28.Text = "=";
		this.inputButton28.Click += new System.EventHandler(this.computeAns_Click);

		this.inputButton29.BackColor = System.Drawing.SystemColors.ActiveCaption;
		this.inputButton29.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		this.inputButton29.ForeColor = System.Drawing.Color.White;
		this.inputButton29.Location = new System.Drawing.Point(0, 260);
		this.inputButton29.Name = "inputButton10";
		this.inputButton29.Size = new System.Drawing.Size(60, 40);
		this.inputButton29.TabIndex = 10;
		this.inputButton29.Text = "ON";
		//this.inputButton29.Click += new System.EventHandler(this.inputButton_Click);
        this.inputButton29.Click += new System.EventHandler(this.checkPowerButton_Click);

		this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(300, 300);

		this.Controls.Add(this.inputButton29);
		this.Controls.Add(this.inputButton28);
		this.Controls.Add(this.inputButton27);
		this.Controls.Add(this.inputButton26);
		this.Controls.Add(this.inputButton25);
		this.Controls.Add(this.inputButton24);
		this.Controls.Add(this.inputButton23);
		this.Controls.Add(this.inputButton22);
		this.Controls.Add(this.inputButton21);
		this.Controls.Add(this.inputButton20);
		this.Controls.Add(this.inputButton19);
		this.Controls.Add(this.inputButton18);
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

	
		this.PerformLayout();
	}
	 private void MC_Click(Object sender,EventArgs e)
    {
        if (Status)
		{
			addstore =Double.Parse("0");
		}
		 else
        {
            MessageBox.Show("Please Switch ON Your calculator");
        }
    }
	public void MR_Click(Object sender, EventArgs e)
	{
		if (Status)
		{
			this.inputOperationTextBox.Text = addstore.ToString();
			this.isOperatorClicked = true ;
		}
		else
		{
			MessageBox.Show("Please Switch ON Your calculator");
		}
	}
	public void MS_Click(Object sender, EventArgs e)
	{
		if (Status)
		{
			this.addstore= Double.Parse(inputOperationTextBox.Text);
			isOperatorClicked = true ;
		}
		else
		{
			MessageBox.Show("Please Switch ON Your calculator");
		}
	}
	private void Mstore_Click(Object sender, EventArgs e)
	{
		if (Status)
		{
			addstore = addstore + Double.Parse(inputOperationTextBox.Text);
			this.isOperatorClicked = true ;
		}
		else
		{
			MessageBox.Show("Please Switch ON Your calculator");
		}
	}
	private void substore_Click(Object sender, EventArgs e)
	{
		if (Status)
		{
			addstore = addstore-Double.Parse(inputOperationTextBox.Text);
			this.isOperatorClicked = true ;
		}
		else
		{
			MessageBox.Show("Please Switch ON Your calculator");
		}
	}
    private void backButton_Click(Object sender,EventArgs e)
    {
        string disp = inputOperationTextBox.Text;
		int len = disp.Length ;
		if (!isOperatorClicked)
		{
			string ret = disp.Substring(0 , len-1)	;
			inputOperationTextBox.Text=ret;
			if(len == 1)
			inputOperationTextBox.Text ="0" ;
		}
    }
    private void dotButton_Click(Object sender, EventArgs e)
    {
        if(Status)
        {
                 String display = inputOperationTextBox.Text ;
                int pos = display.IndexOf(".") ;
                if(pos < 0)
                {
                    inputOperationTextBox.Text += "." ; 
                }
        }
        else
        {
            MessageBox.Show("Please Switch ON Your calculator");
        }
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
    private void inputButton13_Click(Object Sender, EventArgs e)
    {
        this.inputOperationTextBox.Text="0";
    }

	private void operationPerform_Click(object sender , EventArgs e)
	{
		if(Status)
        {
            Button operators = (Button) sender ;
			this.isOperatorClicked = true;
			if(resultValue == "")
			{
				resultValue = inputOperationTextBox.Text ;
			}
			else
			{
				if(this.operationType == "")
				{
					resultValue = inputOperationTextBox.Text ;
				}
				else
				{
					this.inputButton28.PerformClick() ;
				}
			}
			this.operationType = operators.Text ;
        }
        else
        {
            MessageBox.Show("Please Switch ON Your calculator");
        }
	}
	private void computeAns_Click(object sender , EventArgs e)
	{ 
		//MessageBox.Show(this.operationType) ;
		if(this.operationType != "")
		{
			switch (this.operationType)
			{
				case "+" :
				ans = Double.Parse(resultValue) + Double.Parse(inputOperationTextBox.Text) ;
				break ;
				case "-" :
				ans = Double.Parse(resultValue) - Double.Parse(inputOperationTextBox.Text) ;
				break ;
				case "/" :
				ans = Double.Parse(resultValue) / Double.Parse(inputOperationTextBox.Text) ;
				break ;
				case "*" :
				ans = Double.Parse(resultValue) * Double.Parse(inputOperationTextBox.Text) ;
				break ;
			} 
			this.inputOperationTextBox.Text = ans.ToString() ;
			this.operationType = "" ;
			this.resultValue = ans.ToString() ;
		}
		this.isOperatorClicked = true  ;
	}
    private bool Status=false;

	static void Main()
	{
		Application.Run(new CalApp());
	}
	CalApp()
	{
		InitializeComponet();
	}
}