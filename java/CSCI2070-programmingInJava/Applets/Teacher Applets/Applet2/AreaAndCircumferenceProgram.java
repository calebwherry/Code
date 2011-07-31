//Program to determine the area and circumference of a circle

import javax.swing.JOptionPane;
import javax.swing.JApplet;

public class AreaAndCircumferenceProgram extends JApplet
{
   public static final double PI = 3.14;                   //Line 1

   public void init()                  //Line 2
   {
     double radius;                                        //Line 3
     double area;                                          //Line 4
     double circumference;                                 //Line 5
     String radiusString;                                  //Line 6
     String outputStr;                                     //Line 7

     radiusString =
         JOptionPane.showInputDialog("Enter the radius: ");	//Line 8

     radius = Double.parseDouble(radiusString);             //Line 9

     area = PI * radius * radius;       					//Line 10
     circumference = 2 * PI * radius;  						//Line 11

     outputStr = "Radius: " + radius + "\n" +
                 "Area: " + area + " square units\n" +
                 "Circumference: " + circumference
                 + " units";       							//Line 12

     JOptionPane.showMessageDialog(null, outputStr, "Circle",
                        JOptionPane.INFORMATION_MESSAGE);   //Line 13

     //System.exit(0);                                       	//Line 14
  }
}
