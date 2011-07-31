// Caleb Wherry
// 04/08/2007
// javaProgram.java
// Purpose:

import java.awt.*;
import java.awt.event.*;
import java.text.*;
import javax.swing.*;
import java.applet.*;

public class javaProgram extends Applet implements ActionListener, Runnable
{
	JTextField textFieldTF, textField2TF;
	Button guessB;
	JTextField timeTF;
	
	long startTime;
    SimpleDateFormat timerFormat = new SimpleDateFormat("mm : ss");
    Thread updater;
    boolean isRunning= false, clicked = false, guess = false;
		
	public void init()
	{		
		textFieldTF = new JTextField(10);
		textField2TF = new JTextField(15);
		textField2TF.setEditable(false);
		
		timeTF = new JTextField(10);
		timeTF.setEditable(false);
		timeTF.setBackground(Color.red);
		timeTF.setForeground(Color.yellow);
		
		guessB = new Button("Guess");
		guessB.setBackground(Color.green);
			
		add(textFieldTF);
		add(textField2TF);
		add(timeTF);
		add(guessB);
		
		//guessB.addActionListener(this);
		guessB.addActionListener(new guessListener());
		
		setSize(WIDTH, HEIGHT);
		
		setVisible(true);
	}

	private class guessListener implements ActionListener
	{	
    	public void actionPerformed (ActionEvent e)
  		{
    		int number, guess, turns;
    		
    		turns = -2;                
    		number = 1 + (int)(100 * Math.random());
    		
    		turns++; 

    		do
    		{
      			guess = Integer.parseInt(textFieldTF.getText());
      			
      			if ((guess < 0) || (guess > 100))
      			{
        			textField2TF.setText("Guess Between 0 & 100!!!");
      			}
      			else if (guess < number)
      			{
        			textField2TF.setText(guess + " is too low.  Try a higher number.");
      			}
      			else if (guess > number)
      			{
        			textField2TF.setText(guess + " is too high.  Try a lower number.");
      			}
      			else
      			{
      				turns = -3;
        			textField2TF.setText(guess + " is correct. It took ");
      			}
      			
    		} while (guess != number);
		}
	}
	
	Runnable displayUpdater= new Runnable()
    {
        public void run()
        {
            displayElapsedTime(System.currentTimeMillis() - javaProgram.this.startTime);
        }
    };
	 
    public void actionPerformed (ActionEvent e)
    {
    	if (!clicked)
    	{
    		startTime= System.currentTimeMillis();
        	isRunning= true;
        	updater= new Thread(this);
        	updater.start();
        	clicked = true;
    	}   	
    }
    
    private void displayElapsedTime(long elapsedTime)
    {
        timeTF.setText(timerFormat.format(new java.util.Date(elapsedTime)));
    }
    
    public void run()
    {
        try
        {
            while(isRunning)
            {
                SwingUtilities.invokeAndWait(displayUpdater);
                Thread.sleep(50);
            }
        }
        catch(java.lang.reflect.InvocationTargetException ite)
        {
            ite.printStackTrace(System.err);
        }
        catch(InterruptedException ie) {}
    }
}