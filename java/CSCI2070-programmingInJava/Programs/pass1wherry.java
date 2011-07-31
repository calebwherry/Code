// Caleb Wherry
// Due Date: 1-26-07
// Name: pass1wherry.java
// Purpose: To calculuate the total cost owed by a customer to a rental car company.

import java.util.*;

public class pass1wherry
{
	static Scanner console = new Scanner (System.in);

	static final double SALES_TAX = .095;
	
	public static void main (String[] args)
	{
		int days_driven;
		double miles_driven;
		double weekly_rate = 0;
		double daily_rate = 0;
		double miles_rate = 0;
		double car_rental_rate;
		double total_rate;
		double tax;
		double total_cost;
		
		System.out.printf("Please enter the amount of days driven: ");
		System.out.flush();
		days_driven = console.nextInt();
		System.out.printf("Please enter the amount of miles driven: ");
		System.out.flush();
		miles_driven = console.nextDouble();
		System.out.printf("%n");
		
		if (days_driven >= 7)
		{
			weekly_rate = (days_driven / 7) * 300.00;
			daily_rate = (days_driven % 7) * 50.00;
		}
		
		else
		{
			weekly_rate = 0;
			daily_rate = (days_driven * 50.00);
		}
		
		if ((miles_driven / days_driven) > 50)
		{
			miles_rate = (((miles_driven / days_driven) - 50) * days_driven) * .25;
		}
		
		else
		{
			miles_rate = 0;
		}
		
		car_rental_rate = weekly_rate + daily_rate;
		
		total_rate = weekly_rate + daily_rate + miles_rate;
		
		tax = total_rate * SALES_TAX;
		
		total_cost = total_rate + tax;
		
		System.out.printf("The total rental car charge is: $%.2f %n", car_rental_rate);
		System.out.printf("The total miles charge is: $%.2f %n", miles_rate);
		System.out.printf("The total before taxes is: $%.2f %n", total_rate);
		System.out.printf("The tax is: $%.2f %n", tax);
		System.out.printf("%n");
		System.out.printf("The total cost is: $%.2f %n", total_cost);
	}
}
		