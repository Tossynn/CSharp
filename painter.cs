using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
//using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
//alright it is my own part of the code
public class Painter: Form
{
	bool shouldPaint = false;
	static void Main()
	{
		Application.Run(new Painter());
	}
	private void Painter_MouseDown(object sender, MouseEventArgs e)
	{
		shouldPaint = true;
	} 
	private void Painter_MouseUp(object sender, MouseEventArgs e)
	{
		shouldPaint = false;
	}
	private void Painter_MouseMove(object sender, MouseEventArgs e)
	{
		if(shouldPaint)
		{
			Graphics graphics = CreateGraphics();
			graphics.FillEllipse(new SolidBrush(Color.BlueViolet),e.X,e.Y,2,2);
		}
	}
	Painter()
	{
		InitializeComponent();
	}
	private void InitializeComponent()
	{
		this.MouseMove += new MouseEventHandler(this.Painter_MouseMove);
		this.MouseUp += new  MouseEventHandler(this.Painter_MouseUp);
		this.MouseDown += new MouseEventHandler(this.Painter_MouseDown);
	}
}