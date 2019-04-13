using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
class Jumper: Form
{
	private Label maintextLabel;
	private GroupBox buttontypeGroupBox;
	private GroupBox iconGroupBox;
	private RadioButton radioButton1;
	private RadioButton radioButton2;
	private RadioButton radioButton3;
	private RadioButton radioButton4;
	private RadioButton radioButton5;
	private RadioButton radioButton6;
	private RadioButton radioButton11;
	private RadioButton radioButton12;
	private RadioButton radioButton13;
	private RadioButton radioButton14;
	private Button displayButton;
	private Label subtextLabel;
	private Panel displayPanel;
	private MessageBoxIcon iconType = MessageBoxIcon.Error;
	private MessageBoxButtons buttonType = MessageBoxButtons.OK;
	private void InitializeComponents()
	{
		this.SuspendLayout();
		
		this.maintextLabel = new Label();
		this.maintextLabel.Text = "Choose The Type  of MessageBox You Would Like to Display";
		this.maintextLabel.Location = new Point(20,10);
		this.maintextLabel.Size = new Size(900, 50);
		this.maintextLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
		this.maintextLabel.Font = new System.Drawing.Font("Calibri", 19.39F, FontStyle.Bold);
		
		this.radioButton1 = new RadioButton();
		this.radioButton1.Text = "OK";
		this.radioButton1.Location = new Point(15,40);
		this.radioButton1.Size = new Size(49,20);
		this.radioButton1.ForeColor = System.Drawing.SystemColors.GrayText;
		this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.21F);
		this.radioButton1.Click += new System.EventHandler(this.OkButton_Click);
		this.radioButton1.Click += new System.EventHandler(this.buttonTypeCheckedChange);
		
		this.radioButton2 = new RadioButton();
		this.radioButton2.Text = "OkCancel";
		this.radioButton2.Location = new Point(15,80);
		this.radioButton2.Size = new Size(90,20);
		this.radioButton2.ForeColor = System.Drawing.SystemColors.GrayText;
		this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.56F);
		this.radioButton2.Click += new System.EventHandler(this.OkCancelButton_Click);
		this.radioButton2.Click += new System.EventHandler(this.buttonTypeCheckedChange);
		
		this.radioButton3 = new RadioButton();
		this.radioButton3.Text = "AbortRetryIgnore";
		this.radioButton3.Location = new Point(15,120);
		this.radioButton3.Size = new Size(150,20);
		this.radioButton3.ForeColor = System.Drawing.SystemColors.GrayText;
		this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.56F);
		this.radioButton3.Click += new System.EventHandler(this.AbortRetryIgnoreButton_Click);
		this.radioButton3.Click += new System.EventHandler(this.buttonTypeCheckedChange);
		
		this.radioButton4 = new RadioButton();
		this.radioButton4.Text = "YesNoCancel";
		this.radioButton4.Location = new Point(15,160);
		this.radioButton4.Size = new Size(140,20);
		this.radioButton4.ForeColor = System.Drawing.SystemColors.GrayText;
		this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.56F);
		this.radioButton4.Click += new System.EventHandler(this.YesNoCancelButton_Click);
		this.radioButton4.Click += new System.EventHandler(this.buttonTypeCheckedChange);
		
		this.radioButton5 = new RadioButton();
		this.radioButton5.Text = "YesNo";
		this.radioButton5.Location = new Point(15,200);
		this.radioButton5.Size = new Size(90,20);
		this.radioButton5.ForeColor = System.Drawing.SystemColors.GrayText;
		this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.56F);
		this.radioButton5.Click += new System.EventHandler(this.YesNoButton_Click);
		this.radioButton5.Click += new System.EventHandler(this.buttonTypeCheckedChange);
		
		this.radioButton6 = new RadioButton();
		this.radioButton6.Text = "RetryCancel";
		this.radioButton6.Location = new Point(15,240);
		this.radioButton6.Size = new Size(105,20);
		this.radioButton6.ForeColor = System.Drawing.SystemColors.GrayText;
		this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.56F);
		this.radioButton6.Click += new System.EventHandler(this.RetryCancelButton_Click);
		this.radioButton6.Click += new System.EventHandler(this.buttonTypeCheckedChange);
		
		this.buttontypeGroupBox = new GroupBox();
		this.buttontypeGroupBox.Text = "Button Types";
		this.buttontypeGroupBox.Location = new Point(15,70);
		this.buttontypeGroupBox.Size = new Size(280,300);
		this.buttontypeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
		this.buttontypeGroupBox.Controls.AddRange(new Control[]{this.radioButton1, this.radioButton2, this.radioButton3, this.radioButton4, this.radioButton5, this.radioButton6});
		
		this.radioButton11 = new RadioButton();
		this.radioButton11.Text = "Error";
		this.radioButton11.Location = new Point(15,40);
		this.radioButton11.Size = new Size(70,20);
		this.radioButton11.ForeColor = System.Drawing.Color.Sienna;
		this.radioButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.56F);
		this.radioButton11.Click += new System.EventHandler(this.iconTypeCheckedChange);
		
		this.radioButton12 = new RadioButton();
		this.radioButton12.Text = "Exclamation";
		this.radioButton12.Location = new Point(15,80);
		this.radioButton12.Size = new Size(110,20);
		this.radioButton12.ForeColor = System.Drawing.Color.Sienna;
		this.radioButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.56F);
		this.radioButton12.Click += new System.EventHandler(this.iconTypeCheckedChange);
		
		this.radioButton13 = new RadioButton();
		this.radioButton13.Text = "Question";
		this.radioButton13.Location = new Point(15,120);
		this.radioButton13.Size = new Size(100,20);
		this.radioButton13.ForeColor = System.Drawing.Color.Sienna;
		this.radioButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.56F);
		this.radioButton13.Click += new System.EventHandler(this.iconTypeCheckedChange);
		
		this.radioButton14 = new RadioButton();
		this.radioButton14.Text = "Information";
		this.radioButton14.Location = new Point(15,160);
		this.radioButton14.Size = new Size(120,20);
		this.radioButton14.ForeColor = System.Drawing.Color.Sienna;
		this.radioButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.56F);
		this.radioButton14.Click += new System.EventHandler(this.iconTypeCheckedChange);
		
		this.iconGroupBox = new GroupBox();
		this.iconGroupBox.Text = "Icon";
		this.iconGroupBox.Location = new Point(345,70);
		this.iconGroupBox.Size = new Size(280,220);
		this.iconGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
		this.iconGroupBox.Controls.AddRange(new Control[]{this.radioButton11, this.radioButton12, this.radioButton13, this.radioButton14});
		
		this.displayButton = new Button();
		this.displayButton.Text = "Display";
		this.displayButton.Location = new Point(10,10);
		this.displayButton.Size = new Size(260,40);
		this.displayButton.Font = new System.Drawing.Font("Lucida Console", 12F, FontStyle.Bold);
		this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
		
		this.subtextLabel = new Label();
		//this.subtextLabel.Text = "Button Clicked";
		this.subtextLabel.Location = new Point(0,55);
		this.subtextLabel.Size = new Size(286,40);
		this.subtextLabel.Font = new System.Drawing.Font("Candara", 13F);
		this.subtextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		
		this.displayPanel = new Panel();
		this.displayPanel.Location = new Point(345,310);
		this.displayPanel.Size = new Size(280,90);
		this.displayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
		this.displayPanel.Controls.AddRange(new Control[]{this.displayButton, this.subtextLabel});
		
		this.Text = "Sorcery101";
		this.ClientSize = new System.Drawing.Size(700,450);
		this.Controls.Add(this.buttontypeGroupBox);
		//this.Controls.Add(this.radioButton1);
		//this.Controls.Add(this.radioButton2);
		//this.Controls.Add(this.radioButton3);
		//this.Controls.Add(this.radioButton4);
		//this.Controls.Add(this.radioButton5);
		//this.Controls.Add(this.radioButton6);
		//this.Controls.Add(this.radioButton11);
		//this.Controls.Add(this.radioButton12);
		//this.Controls.Add(this.radioButton13);
		//this.Controls.Add(this.radioButton14);
		this.Controls.Add(this.maintextLabel);
		this.Controls.Add(this.iconGroupBox);
		//this.Controls.Add(this.displayButton);
		//this.Controls.Add(this.subtextLabel);
		this.Controls.Add(this.displayPanel);
		this.ResumeLayout(false);
	}
	static void Main()
	{
		Application.Run(new Jumper());
	}
	Jumper()
	{
		InitializeComponents();
	}
	private void OkButton_Click(object sender, EventArgs e)
	{
		this.subtextLabel.Text = "OK Button Clicked";
	}
	private void OkCancelButton_Click(object sender, EventArgs e)
	{
		this.subtextLabel.Text = "OkCancel Button Clicked";
	}
	private void AbortRetryIgnoreButton_Click(object sender, EventArgs e)
	{
		this.subtextLabel.Text = "AbortRetryIgnore Button Clicked";
	}
	private void YesNoButton_Click(object sender, EventArgs e)
	{
		this.subtextLabel.Text = "YesNo Button Clicked";
	}
	private void YesNoCancelButton_Click(object sender, EventArgs e)
	{
		this.subtextLabel.Text = "YesNoCancel Button Clicked";
	}
	private void RetryCancelButton_Click(object sender, EventArgs e)
	{
		this.subtextLabel.Text = "RetryCancel Button Clicked";
	}
	private void displayButton_Click(object sender, EventArgs e)
	{
		DialogResult dr = MessageBox.Show("This is our customized MessageBox", "Message Box T", buttonType, iconType, 0,0);
		switch(dr)
		{
			case DialogResult.OK:
				subtextLabel.Text = "OK was pressed";
				break;
			case DialogResult.Cancel:
				subtextLabel.Text = "Cancel was pressed";
				break;
			case DialogResult.Abort:
				subtextLabel.Text = "Abort was pressed";
				break;
			case DialogResult.Retry:
				subtextLabel.Text = "Retry was pressed";
				break;
			case DialogResult.Ignore:
				subtextLabel.Text = "Ignore was pressed";
				break;
			case DialogResult.Yes:
				subtextLabel.Text = "Yes was pressed";
				break;
			case DialogResult.No:
				subtextLabel.Text = "No was pressed";
				break;
		}
	}
	private void buttonTypeCheckedChange(object sender, EventArgs e)
	{
		if(sender == radioButton1)
		{
			buttonType = MessageBoxButtons.OK;
		}
		else if(sender == radioButton2)
		{
			buttonType = MessageBoxButtons.OKCancel;
		}
		else if(sender == radioButton3)
		{
			buttonType = MessageBoxButtons.AbortRetryIgnore;
		}
		else if(sender == radioButton4)
		{
			buttonType = MessageBoxButtons.YesNoCancel;
		}
		else if(sender == radioButton5)
		{
			buttonType = MessageBoxButtons.YesNo;
		}
		else if(sender == radioButton6)
		{
			buttonType = MessageBoxButtons.RetryCancel;
		}
	}
	private void iconTypeCheckedChange(object sender, EventArgs e)
	{
		if(sender == radioButton11)
		{
			iconType = MessageBoxIcon.Error;
		}
		else if(sender == radioButton12)
		{
			iconType = MessageBoxIcon.Exclamation;
		}
		else if(sender == radioButton13)
		{
			iconType = MessageBoxIcon.Question;
		}
		else if(sender == radioButton14)
		{
			iconType = MessageBoxIcon.Information;
		}
	}
}