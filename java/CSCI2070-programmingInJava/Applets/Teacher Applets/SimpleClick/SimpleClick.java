

import java.awt.event.MouseListener;
import java.awt.event.MouseEvent;
import javax.swing.JApplet;
import java.awt.Graphics;

public class SimpleClick extends JApplet 
			 implements MouseListener {

    StringBuffer buffer;

    public void init() {
	addMouseListener(this);
	buffer = new StringBuffer();
        addItem("initializing........");
    }

    public void start() {
        addItem("starting............");
    }

    public void stop() {
        addItem("stopping............");
    }

    public void destroy() {
        addItem("unloading...........");
    }

    void addItem(String newWord) {
        System.out.println(newWord);
        buffer.append(newWord);
        repaint();
    }

    public void paint(Graphics g) {
	//Draw a Rectangle around the applet's display area.
        g.drawRect(0, 0, 
		   getSize().width - 1,
		   getSize().height - 1);

	//Draw the current string inside the rectangle.
	    String myString=buffer.toString();
		int count=0;
	    for(int i=0;i<buffer.length();i=i+20)
        g.drawString(myString.substring(i,i+20), 5, (i+20)/20*15);
        
    }

    //The following empty methods can be removed
    //by implementing a MouseAdapter (usually done
    //using an inner class).
    public void mouseEntered(MouseEvent event) {
    addItem("mouseEntered!.......");}
    public void mouseExited(MouseEvent event) {
	addItem("mouseExited!........");
    }
    public void mousePressed(MouseEvent event) {
	addItem("mousePressed!.......");
    }
    public void mouseReleased(MouseEvent event) {
	addItem("mouseReleased!......");
    }

    public void mouseClicked(MouseEvent event) {
	addItem("click!..............");
    }
}
