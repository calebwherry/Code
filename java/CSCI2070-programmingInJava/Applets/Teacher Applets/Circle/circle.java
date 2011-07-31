
import java.awt.*;
import java.applet.*;

 public class circle extends Applet {
    private int mouseX, mouseY;
    private boolean mouseclicked = false;
    int []arrayX;
		int []arrayY;
		int size;
		int maxSize; 
	  public void init()  {
		setBackground(Color.blue);
        maxSize=Integer.parseInt(getParameter("maxSize"));
		arrayX=new int[maxSize];
		arrayY=new int[maxSize];
		size=0;
		
	  }

   public boolean mouseDown(Event e, int x, int y ) {
       arrayX[size]=x; arrayY[size]=y;
	   size++;
       mouseclicked = true;
       repaint();
       return true;
   }

    public void paint( Graphics g ) {
       g.setColor(Color.red);
       if (mouseclicked) {
	       for(int i=0;i<size;i++)
           g.fillOval(arrayX[i], arrayY[i], 10, 10);
           mouseclicked = false;
       }
   }    
}

