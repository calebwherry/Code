// Caleb Wherry
// 02-17-07
// pass3wherry.java
// Purpose: To calculate the cost of a catered day of food provided by a catering service.

import javax.swing.JOptionPane;

public class pass3wherry
{
	public static void main (String[] args)
	{
		int breakfasts;
		int lunches;
		int dinners;
		double breakfast_cost, breakfast_discount, breakfast_total;
		double lunch_cost, lunch_discount, lunch_total;
		double dinner_cost, dinner_discount, dinner_total;
		double total;
		final double tax = .1;
		double total_due;
		
		String breakfast_str;
		String lunch_str;
		String dinner_str;
		String output_str;
		
		breakfast_str = JOptionPane.showInputDialog("Enter the Number of Breakfasts Ordered");
		breakfasts = Integer.parseInt(breakfast_str);
		
		lunch_str = JOptionPane.showInputDialog("Enter the Number of Lunches Ordered");
		lunches = Integer.parseInt(lunch_str);
		
		dinner_str = JOptionPane.showInputDialog("Enter the Number of Dinners Ordered");
		dinners = Integer.parseInt(dinner_str);
		
		
		breakfast_cost = breakfasts * 5.50;
		
			if (breakfasts > 10)
			{
				breakfast_discount = breakfast_cost * .1;
			}
		
			else
				breakfast_discount = 0.0;
			
			breakfast_total = breakfast_cost - breakfast_discount;
			
		
		lunch_cost = lunches * 9.5;
		
			if (lunches > 15)
			{
				lunch_discount = lunch_cost * .15;
			}
			
			else
				lunch_discount = 0.0;
			
			lunch_total = lunch_cost - lunch_discount;
			
		  
		dinner_cost = dinners * 16.5;
		
			if (dinners > 8)
			{
				dinner_discount = dinner_cost * .12;
			}
			
			else
				dinner_discount = 0.0;
			
		dinner_total = dinner_cost - dinner_discount;
		
		
		total = breakfast_total + lunch_total + dinner_total;
		
		total_due = total * tax + total;
		
		
		output_str = String.format(" Meal           Quantity       Cost"
											 + "      Discount     Cost After Discount %n"
											 + "Breakfast %9d %16.2f %11.2f %23.2f %n"
											 + "Lunch %16d %16.2f %11.2f %23.2f %n"
											 + "Dinner %15d %16.2f %11.2f %24.2f %n%n%n"
											 + "Total %87.2f %n"
											 + "Sales Tax %78.2f %n"
											 + "Total Due %78.2f",
											 + breakfasts, breakfast_cost, breakfast_discount,
											 + breakfast_total, lunches, lunch_cost, lunch_discount,
											 + lunch_total, dinners, dinner_cost, dinner_discount,
											 + dinner_total, total, total * tax, total_due); 
											 
											 		
		JOptionPane.showMessageDialog(null, output_str, "Catering Service Cost",
												+ JOptionPane.INFORMATION_MESSAGE); 
		
		
		System.exit(0);
		
	}
}

