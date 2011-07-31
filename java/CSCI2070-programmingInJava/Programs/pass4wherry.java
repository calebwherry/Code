// Caleb Wherry
// 02-24-07
// pass4wherry.java
// Purpose: To calculate the cost of meals that were ordered from a catering service.

import javax.swing.*;
import java.awt.*;
import java.awt.Font;
import java.awt.Cursor;
import java.awt.event.*;
import java.text.DecimalFormat; 

public class pass4wherry extends JFrame
{
	JLabel mealL, quantityL, costL,
			 breakfastL, lunchL,
			 dinnerL, meal_totalL,
			 taxL, total_dueL, meal_costL,
			 tax_costL, total_due_costL, spaceL; 
			 			 
	JTextField breakfast_quantityTF, breakfast_costTF,
				  lunch_quantityTF, lunch_costTF,
				  dinner_quantityTF, dinner_costTF, 
				  meal_totalTF,taxTF, total_dueTF;
				  				  
	JButton calculateB, exitB;
	
	CalculateButtonHandler calculateHandler;
	ExitButtonHandler exitHandler;

	public pass4wherry()
	{
			// Create Labels
		mealL = new JLabel("Meal       ", SwingConstants.RIGHT);
		quantityL = new JLabel("Quantitity", SwingConstants.CENTER);
		costL = new JLabel("Cost", SwingConstants.CENTER);
		breakfastL = new JLabel("Breakfast  ", SwingConstants.RIGHT);
		lunchL = new JLabel("Lunch   ", SwingConstants.RIGHT);
		dinnerL = new JLabel("Dinner  ", SwingConstants.RIGHT);
		meal_totalL = new JLabel("Total   ", SwingConstants.RIGHT);
		meal_costL = new JLabel();		
		taxL = new JLabel("Tax    ", SwingConstants.RIGHT);
		tax_costL = new JLabel();
		total_dueL = new JLabel("Total Due   ", SwingConstants.RIGHT);			
		total_due_costL = new JLabel();
		spaceL = new JLabel();
						
			// Create Textfields
		breakfast_quantityTF = new JTextField(10);
		breakfast_costTF = new JTextField(10);
	    lunch_quantityTF = new JTextField(10);
	    lunch_costTF = new JTextField(10);
	    dinner_quantityTF = new JTextField(10);
	    dinner_costTF = new JTextField(10);
		meal_totalTF = new JTextField(10);
		taxTF = new JTextField(10);
	    total_dueTF = new JTextField(10);
	    
	    	// Create Calculate Button
	    calculateB = new JButton("Calculate");
        calculateHandler = new CalculateButtonHandler();
        calculateB.addActionListener(calculateHandler);
        
        	// Create Exit Button
        exitB = new JButton("Exit");
        exitHandler = new ExitButtonHandler();
        exitB.addActionListener(exitHandler);

		setTitle("Cost Calculations For A Catering Service");
		
	 	setLayout(new GridLayout(8,3));
				
		Container pane = getContentPane();
				
			pane.add(mealL);
			pane.add(quantityL);
			pane.add(costL);
			pane.add(breakfastL);
			pane.add(breakfast_quantityTF);
			pane.add(breakfast_costTF);
			pane.add(lunchL);
			pane.add(lunch_quantityTF);
			pane.add(lunch_costTF);
			pane.add(dinnerL);
			pane.add(dinner_quantityTF);
			pane.add(dinner_costTF);
			pane.add(meal_totalL);
			pane.add(meal_totalTF);
			pane.add(meal_costL);
			pane.add(taxL);
			pane.add(taxTF);
			pane.add(tax_costL);
			pane.add(total_dueL);
			pane.add(total_dueTF);
			pane.add(total_due_costL);
			pane.add(spaceL);
			pane.add(calculateB);
			pane.add(exitB);
							
		breakfast_costTF.setEditable(false);
		lunch_costTF.setEditable(false);
		dinner_costTF.setEditable(false);
		meal_totalTF.setEditable(false);
		taxTF.setEditable(false);
		total_dueTF.setEditable(false);
		
		Font myFont = new Font("Miriam Transparent", Font.BOLD + Font.ITALIC, 40);	
		total_dueTF.setFont(myFont);
		
		Toolkit theKit = pane.getToolkit();
		Dimension wndSize = theKit.getScreenSize();
		setBounds(wndSize.width/4, wndSize.height/4,
					 wndSize.width/2, wndSize.height/2);

		setDefaultCloseOperation(EXIT_ON_CLOSE);
		
		setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		
		setVisible(true);
	}
	
	private class CalculateButtonHandler implements ActionListener
   {
    	public void actionPerformed(ActionEvent e)
      {
		  		int breakfasts, lunches, dinners;		
				double breakfast_cost, lunch_cost, dinner_cost,
						 meal_cost, tax, total_due;
						 
				breakfasts = Integer.parseInt(breakfast_quantityTF.getText());
				lunches = Integer.parseInt(lunch_quantityTF.getText());
				dinners = Integer.parseInt(dinner_quantityTF.getText());
				
						// Breakfast Calculations
					if (breakfasts > 10)
					{
						breakfast_cost = breakfasts * 5.5 -
											  (breakfasts * 5.5) * .1;
					}
				
					else
							breakfast_cost = breakfasts * 5.5;
					
						// Lunch Calculations		
					if (lunches > 15)
					{
						lunch_cost = lunches * 9.5 -
										 (lunches * 9.5) *.15;
					}
					
					else
						lunch_cost = lunches * 9.5;
					
						// Dinner Calculations	
					if (dinners > 8)
					{
						dinner_cost = dinners * 16.5 -
										  (dinners * 16.5) * .12;
					}
					
					else
						dinner_cost = dinners * 16.5;
						 
				
				meal_cost = breakfast_cost + lunch_cost + dinner_cost;
				
				tax = meal_cost * .1;
				
				total_due = meal_cost + tax;
				
				DecimalFormat money = new DecimalFormat("$0.00");
				
				breakfast_costTF.setText(money.format(breakfast_cost));
				lunch_costTF.setText(money.format(lunch_cost));
				dinner_costTF.setText(money.format(dinner_cost));
				meal_totalTF.setText(money.format(meal_cost));
				taxTF.setText(money.format(tax));
				total_dueTF.setText(money.format(total_due));  
      }
   }
    
   private class ExitButtonHandler implements ActionListener
   {
   	public void actionPerformed(ActionEvent e)
      {
      	System.exit(0);
      }
   }

	public static void main( String args[] )
   {
   	pass4wherry Object = new pass4wherry();
   }
}
