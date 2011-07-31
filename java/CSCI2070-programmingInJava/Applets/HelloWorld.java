import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.JApplet;
import java.applet.*;

public class HelloWorld extends Applet implements ActionListener
{	
	Button fillcolorB;
	boolean pressed = false;

	public void init()
	{
		setBackground(Color.gray);
		fillcolorB = new Button("Fill In Color");
		add(fillcolorB);
		fillcolorB.addActionListener(this);
	}
	
	public void actionPerformed (ActionEvent e)
	{
		pressed = !pressed;
		repaint();
	}	
		
	public void paint(Graphics g)
	{
		if (!pressed)
		{
			g.drawString("Hello World!", 30, 30);
			g.drawRect(10, 40, 50, 50);
			g.drawRect(60, 90, 50, 50);
			g.drawRect(110, 140, 50, 50);			
		}
		
		else
		{
			g.drawString("Hello World!", 30, 30);
			g.setColor(Color.red);
			g.fillRect(10, 40, 50, 50);
			g.setColor(Color.white);
			g.fillRect(60, 90, 50, 50);
			g.setColor(Color.blue);
			g.fillRect(110, 140, 50, 50);
		}
	}
}