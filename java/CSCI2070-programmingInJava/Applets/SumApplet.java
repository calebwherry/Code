import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.JApplet;

public class SumApplet extends JApplet implements ActionListener
{
	JLabel int1L, int2L, sumL;
	JTextField int1TF, int2TF, sumTF;
	JButton calculateB;
	
	public void init()
	{
		int1L = new JLabel("Enter First Integer", SwingConstants.RIGHT);
		int2L = new JLabel("Enter Second Integer", SwingConstants.RIGHT);
		sumL = new JLabel("Sum", SwingConstants.RIGHT);
		
		int1TF = new JTextField(10); 
		int2TF = new JTextField(10);
		sumTF = new JTextField(10);
		sumTF.setEditable(false);
		
		calculateB = new JButton("Calculate Sum");
		calculateB.addActionListener(this);
		
		Container applet_pane = getContentPane();
		
		applet_pane.setLayout(new GridLayout(4,2));
			applet_pane.add(int1L);
			applet_pane.add(int1TF);
			applet_pane.add(int2L);
			applet_pane.add(int2TF);
			applet_pane.add(sumL);
			applet_pane.add(sumTF);
			applet_pane.add(calculateB);
			
		 setSize(WIDTH,HEIGHT);
         setVisible(true);
	}
	
    public void actionPerformed(ActionEvent e)
    {
    	int integer1, integer2, int_sum;
    	
    	integer1 = Integer.parseInt(int1TF.getText());
    	integer2 = Integer.parseInt(int2TF.getText());
    	
    	int_sum = integer1 + integer2;
    	
    	sumTF.setText("" + int_sum);
    }
}