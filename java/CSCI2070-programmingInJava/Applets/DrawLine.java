import java.awt.*;
import java.applet.*;

public class DrawLine extends Applet
{
	int click_X, click_Y;
	boolean mouse_click = false;
	int []X_array;
	int []Y_array;
	int size;
	int max_size;
	
	public void init()
	{
		setBackground(Color.black);
		max_size = Integer.parseInt(getParameter("max_size"));
		X_array = new int[max_size];
		Y_array = new int[max_size];
		size = 0;
	}
	
	public boolean mouseDown(Event e, int x, int y)
	{
		X_array[size] = x; 
		Y_array[size] = y;
	    size++;
        mouse_click = true;
        repaint();
        return true;
	}
	
	public void paint(Graphics g)
	{
		g.setColor(Color.green);
		
    	if (mouse_click)
    	{
	       for (int i=0; i<size; i++)
           		g.fillOval(X_array[i], Y_array[i], 10, 10);
           		
           mouse_click = false;
		}
	}
}	