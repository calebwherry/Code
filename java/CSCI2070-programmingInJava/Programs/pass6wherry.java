// Caleb Wherry
// 4-05-2007
// pass6wherry.java
/* Purpose: To organize and calculate information of the customers at a hotel for their 
			room reservations. */

import java.awt.*;
import java.awt.event.*;
import java.util.*;
import java.text.*;			
import javax.swing.*;
import javax.swing.JApplet.*;

public class pass6wherry extends JApplet
{
		// Left Pane
	JPanel leftPane, pane1, pane2;
	JLabel oneL, twoL, threeL, blankL1, blankL2, blankL3, blankL4;
	JTextField oneTF, twoTF, threeTF;
	JComboBox oneCB, twoCB;
	JRadioButton oneRB, twoRB, threeRB, fourRB, fiveRB;
	ButtonGroup group1, group2;
	Button calculate_costB, reserveB;
	
		// Right Pane
	JPanel rightPane;
	JLabel one1L, two1L, three1L, four1L, five1L, six1L, seven1L, eight1L;
	JTextField one1TF, two1TF, three1TF, four1TF, five1TF, six1TF, seven1TF, eight1TF;
	
	int nights, people_price = 0;
	double total_cost, room_price, tax;
	
	public void init()
	{	
			// Left Pane
		leftPane = new JPanel(new GridLayout(8,2));
		leftPane.setBorder(BorderFactory.createTitledBorder("Input Information"));
		
		pane1 = new JPanel(new GridLayout(2,1));
		pane1.setBorder(BorderFactory.createTitledBorder("Bed Type"));
		
		pane2 = new JPanel(new GridLayout(3,1));
		pane2.setBorder(BorderFactory.createTitledBorder("Smoking Preference"));
		
			oneL = new JLabel("Today's Date");
			twoL = new JLabel("Arrival Date");
			threeL = new JLabel("Number of Nights");
			blankL1 = new JLabel();
			blankL2 = new JLabel();
			blankL3 = new JLabel();
			blankL4 = new JLabel();
			
			oneTF = new JTextField(10);
			oneTF.setEditable(false);
			oneTF.setText(easyDateFormat("MM/dd/yy"));
			twoTF = new JTextField(10);
			threeTF = new JTextField(10);
			
			oneCB = new JComboBox(new String[]{"# of Occupants", "1", "2", "3", "4"});
			twoCB = new JComboBox(new String[]{"Room Style", "Regular", "Deluxe", "Suite"});
			
			oneRB = new JRadioButton("1 King Size");
			twoRB = new JRadioButton("2 Queen Size");
			threeRB = new JRadioButton("Smoking");
			fourRB = new JRadioButton("Non-Smoking");
			fiveRB = new JRadioButton("No Preference");
			
			calculate_costB = new Button("Check Availability");
			calculate_costB.addActionListener(new check_availability());
			
			reserveB = new Button("Reserve Room");
			reserveB.addActionListener(new reserve_room());
			
			leftPane.add(oneL);
			leftPane.add(oneTF);
			leftPane.add(twoL);
			leftPane.add(twoTF);
			leftPane.add(threeL);
			leftPane.add(threeTF);
			leftPane.add(oneCB);
			leftPane.add(twoCB);
			pane1.add(oneRB);
			pane1.add(twoRB);
			pane2.add(threeRB);
			pane2.add(fourRB);
			pane2.add(fiveRB);
			leftPane.add(pane1);
			leftPane.add(pane2);
			leftPane.add(blankL1);
			leftPane.add(blankL2);
			leftPane.add(blankL3);
			leftPane.add(blankL4);
			leftPane.add(calculate_costB);
			leftPane.add(reserveB);
			
			group1 = new ButtonGroup();
			
			group1.add(oneRB);
			group1.add(twoRB);
			
			group2 = new ButtonGroup();
			
			group2.add(threeRB);
			group2.add(fourRB);
			group2.add(fiveRB);
		
			// Right Pane
		rightPane = new JPanel(new GridLayout(8,1));
		rightPane.setBorder(BorderFactory.createTitledBorder("Customer Information"));
		
			one1L = new JLabel("Price");
			two1L = new JLabel("Confimation #");
			three1L = new JLabel("Arrival Date");
			four1L = new JLabel("# of Nights");
			five1L = new JLabel("# of Occupants");
			six1L = new JLabel("Room Style");
			seven1L = new JLabel("Bed Type");
			eight1L = new JLabel("Smoking Preference");
			
			one1TF = new JTextField(10);
			one1TF.setEditable(false);
			two1TF = new JTextField(10);
			two1TF.setEditable(false);
			three1TF = new JTextField(10);
			three1TF.setEditable(false);
			four1TF = new JTextField(10);
			four1TF.setEditable(false);
			five1TF = new JTextField(10);
			five1TF.setEditable(false);
			six1TF = new JTextField(10);
			six1TF.setEditable(false);
			seven1TF = new JTextField(10);
			seven1TF.setEditable(false);
			eight1TF = new JTextField(10);
			eight1TF.setEditable(false);
			
			rightPane.add(one1L);
			rightPane.add(one1TF);
			rightPane.add(two1L);
			rightPane.add(two1TF);
			rightPane.add(three1L);
			rightPane.add(three1TF);
			rightPane.add(four1L);
			rightPane.add(four1TF);
			rightPane.add(five1L);
			rightPane.add(five1TF);
			rightPane.add(six1L);
			rightPane.add(six1TF);
			rightPane.add(seven1L);
			rightPane.add(seven1TF);
			rightPane.add(eight1L);
			rightPane.add(eight1TF);
			
		Container pane = getContentPane();
			pane.setLayout(new GridLayout(1,1));
			pane.add(leftPane);
			pane.add(rightPane);
		
		setSize(WIDTH,HEIGHT);
		setVisible(true);
	} 
	
	public String easyDateFormat (String format)
	{
    	Date today = new Date();
    	SimpleDateFormat formatter = new SimpleDateFormat(format);
    	String datenewformat = formatter.format(today);
    	return datenewformat;
    }
	
	private class check_availability implements ActionListener
	{
		public void actionPerformed(ActionEvent e)
        {
        	nights = Integer.parseInt(threeTF.getText());
        	
        	if (twoCB.getSelectedItem().equals("Regular"))
        		room_price = 110 * nights;
        	if (twoCB.getSelectedItem().equals("Deluxe"))
        		room_price = 120 * nights;
        	if (twoCB.getSelectedItem().equals("Suite"))
        		room_price = 150 * nights;
        		
			if (oneCB.getSelectedItem().equals("1"))
        		people_price = 0;
        	if (oneCB.getSelectedItem().equals("2"))
        		people_price = 0;
        	if (oneCB.getSelectedItem().equals("3"))
        		people_price = 15;
        	if (oneCB.getSelectedItem().equals("4"))
        		people_price = 30;
        		
        	tax = (room_price + people_price) * .135;
        	
        	total_cost = room_price + people_price + tax;
        	
        	one1TF.setText(total_cost + "");		
        }
	}
	
	private class reserve_room implements ActionListener
	{
		public void actionPerformed(ActionEvent e)
        {
    		String selected = (String)oneCB.getSelectedItem();
    		String selected2 = (String)twoCB.getSelectedItem();
    		
    		nights = Integer.parseInt(threeTF.getText());
        	
        	if (twoCB.getSelectedItem().equals("Regular"))
        		room_price = 110 * nights;
        	if (twoCB.getSelectedItem().equals("Deluxe"))
        		room_price = 120 * nights;
        	if (twoCB.getSelectedItem().equals("Suite"))
        		room_price = 150 * nights;
        		
        	if (oneCB.getSelectedItem().equals(1))
        		people_price = 0; 
        	if (oneCB.getSelectedItem().equals(2))
        		people_price = 0; 
        	if (oneCB.getSelectedItem().equals(3))
        		people_price = 15;
        	if (oneCB.getSelectedItem().equals(4))
        		people_price = 30;
        		
        	tax = (room_price + people_price) * .135;
        	
        	total_cost = room_price + people_price + tax;		
        	
        	one1TF.setText(total_cost + "");
        	two1TF.setText("6498527");
        	three1TF.setText(twoTF.getText());
        	four1TF.setText(threeTF.getText());
    		five1TF.setText(selected);
        	six1TF.setText(selected2);
        	
        	if (oneRB.isSelected())
    			seven1TF.setText("1 King Size Bed");
    		if (twoRB.isSelected())
    			seven1TF.setText("2 Queen Size Beds");
    			
    		if (threeRB.isSelected())
    			eight1TF.setText("Smoking");
    		if (fourRB.isSelected())
    			eight1TF.setText("Non-Smoking");
   			if (fiveRB.isSelected())
   				eight1TF.setText("No Preference");
        }
	}
}