
//Given the length and width of a rectangle, this Java
//program determines its area and perimeter.

import javax.swing.*;    //JFrame
import java.awt.*;       //Container
import java.awt.event.*; //Event handler
import javax.swing.JApplet.*;

public class RectangleProgramA extends JApplet
{
    JLabel lengthL, widthL,
           areaL, perimeterL;
    JTextField lengthTF, widthTF,
                           areaTF, perimeterTF;
    JButton calculateB, exitB;
    CalculateButtonHandler calculateHandler;
    ExitButtonHandler exitHandler;

    //private static final int WIDTH = 400;
    //private static final int HEIGHT = 300;

    public void init()
    {
                        // Create four labels
              lengthL = new JLabel("Enter the length: ", SwingConstants.RIGHT);
              widthL = new JLabel("Enter the width: ", SwingConstants.RIGHT);
              areaL = new JLabel("Area: ", SwingConstants.RIGHT);
              perimeterL = new JLabel("Perimeter: ", SwingConstants.RIGHT);

                          //Create four textfields
              lengthTF = new JTextField(10);
              widthTF = new JTextField(10);
              areaTF = new JTextField(10);
              perimeterTF = new JTextField(10);

                          //create Calculate Button
              calculateB = new JButton("Calculate");
              calculateHandler = new CalculateButtonHandler();
              calculateB.addActionListener(calculateHandler);

                          //Create Exit Button
              exitB = new JButton("Exit");
              exitHandler = new ExitButtonHandler();
              exitB.addActionListener(exitHandler);

                          //Set the title of the window
              //setTitle("Area and Perimeter of a Rectangle");

                          //Get the container
              Container pane = getContentPane();

                          //Set the layout
        pane.setLayout(new GridLayout(5,2));

                          //Place all items created
              pane.add(lengthL);
              pane.add(lengthTF);
              pane.add(widthL);
              pane.add(widthTF);
              pane.add(areaL);
              pane.add(areaTF);
              pane.add(perimeterL);
              pane.add(perimeterTF);
              pane.add(calculateB);
              pane.add(exitB);

                        //set the size of the window and display it
              setSize(WIDTH,HEIGHT);
              setVisible(true);
                         //setDefaultCloseOperation(EXIT_ON_CLOSE);
    }

    private class CalculateButtonHandler implements ActionListener
    {
              public void actionPerformed(ActionEvent e)
              {
                  double width, length, area, perimeter;

                  length = Double.parseDouble(lengthTF.getText());
                  width = Double.parseDouble(widthTF.getText());
                  area = length * width;
                  perimeter = 2 * (length + width);

                  areaTF.setText("" + area);
                  perimeterTF.setText("" + perimeter);
              }
    }

    private class ExitButtonHandler implements ActionListener
    {
              public void actionPerformed(ActionEvent e)
              {
                        System.exit(0);
              }
    }
}
    