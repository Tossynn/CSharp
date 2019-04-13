using System;
using System.Windows.Forms;
using System.Drawing;
class Grafik: Form
{
	private GroupBox ColorGroup;
    private GroupBox SizeColor;
    private RadioButton Red;
    private RadioButton Blue;
    private RadioButton Green;
    private RadioButton Small;
    private RadioButton Medium;
    private RadioButton Large;
    private Panel Displaypanel;
    bool shouldPaint = false;
    Color[] c = new Color[]{Color.Red, Color.Blue, Color.Green} ;
	private void InitializeComponents()
	{
		this.ColorGroup = new GroupBox();
        this.ColorGroup.Location = new Point(0, 0);
        this.ColorGroup.Size = new Size(100, 120);
        //this.ColorGroup.BackColor = System.Drawing.SystemColors.HotTrack;
        this.ColorGroup.Text = "Color";
        //this.ColorGroup.ForeColor = Color.BlueViolet;
        this.ColorGroup.Font = new Font("Microsoft Sans Serif", 15.0F);
		
		this.Red = new RadioButton();
        this.Red.Text = "Red";
        this.Red.Location= new Point(5, 30);
        this.Red.Size = new Size(70, 30);
        this.Red.Font = new Font("Microsoft Sans Serif", 10.0F);
        this.Red.Checked = true;

        this.Blue = new RadioButton();
        this.Blue.Text = "Blue";
        this.Blue.Location= new Point(5, 60);
        this.Blue.Size = new Size(70, 30);
        this.Blue.Font = new Font("Microsoft Sans Serif", 10.0F);
        
        this.Green = new RadioButton();
        this.Green.Text = "Green";
        this.Green.Location= new Point(5, 90);
        this.Green.Size = new Size(70, 20);
        this.Green.Font = new Font("Microsoft Sans Serif", 10.0F);

        this.ColorGroup.Controls.AddRange(new Control[]{this.Red, this.Blue,this.Green});

        this.SizeColor = new GroupBox();
        this.SizeColor.Location = new Point(0, 130);
        this.SizeColor.Size = new Size(100, 120);
        //this.SizeColor.BackColor = System.Drawing.SystemColors.HotTrack;
        this.SizeColor.Text = "Size";
        this.SizeColor.Font = new Font("Microsoft Sans Serif", 15.0F);

        this.Small = new RadioButton();
        this.Small.Text = "Small";
        this.Small.Location = new Point(5, 30);
        this.Small.Size = new Size(70, 30);
        this.Small.Font = new Font("Microsoft Sans Serif", 10.0F);

        this.Medium = new RadioButton();
        this.Medium.Text = "Medium";
        this.Medium.Location = new Point(5, 60);
        this.Medium.Size = new Size(90, 30);
        this.Medium.Font = new Font("Microsoft Sans Serif", 10.0F);

        this.Large = new RadioButton();
        this.Large.Text = "Large";
        this.Large.Location = new Point(5, 90);
        this.Large.Size = new Size(70, 20);
        this.Large.Font = new Font("Microsoft Sans Serif", 10.0F);

        this.Displaypanel = new Panel();
        this.Displaypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.Displaypanel.Location = new Point(110,5 );
        this.Displaypanel.Size = new Size(280,290);
		this.Displaypanel.BackColor = System.Drawing.Color.White;
        //this.Displaypanel.BackColor = SystemColors.Menu;
        this.Displaypanel.MouseDown += new MouseEventHandler(this.Painter_MouseDown);
        this.Displaypanel.MouseMove += new MouseEventHandler(this.Painter_MouseMove);
        this.Displaypanel.MouseUp += new MouseEventHandler(this.Painter_MouseUp);

        //this.Displaypanel.Controls.AddRange(new Control[]{ });
        this.SizeColor.Controls.AddRange(new Control[]{this.Small, this.Medium, this.Large});
		
        this.Controls.AddRange(new Control[] {this.ColorGroup, this.SizeColor, this.Displaypanel});
        this.ClientSize = new Size(400, 300);
	}
	static void Main()
	{
		Application.Run(new Grafik());
	}
	Grafik()
	{
		InitializeComponents();
	}
	private void Painter_MouseDown(Object Sender, MouseEventArgs e)
    {
        shouldPaint = true;
    }
    private void Painter_MouseUp(Object sender, MouseEventArgs e)
    {
        shouldPaint = false;
    }
    private void Painter_MouseMove(Object sender,MouseEventArgs e)
    {
        if (shouldPaint)
        {
            Color col = Color.Red;
            if (this.Red.Checked)
            {
                col = c[0];
            }
            else if(this.Blue.Checked)
            {
                col = c[1];
            }
            else if(this.Green.Checked)
            {
                col =c[2];
            }
            Graphics graphics = Displaypanel.CreateGraphics() ;
            graphics.FillEllipse(new SolidBrush(col) , e.X,e.Y,4,4);
        }
    }
}