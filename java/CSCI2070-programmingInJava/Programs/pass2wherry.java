// Caleb Wherry
// 02-05-07
// pass2wherry.java
// Purpose: To display the information of a vehicle for a rental car company.

import java.util.*;

class rentalCar
{
	static String car_id;
	static String car_make;
	static String car_model;
	static String car_class;
	static double rental_per_day;
	static int miles;
	
	rentalCar()
	{}
	
	rentalCar(String car_id_in, String car_make_in, String car_model_in, String car_class_in, double rental_per_day_in, int miles_in)
	{
		car_id = car_id_in;
		car_make = car_make_in;
		car_model = car_model_in;
		car_class = car_class_in;
		rental_per_day = rental_per_day_in;
		miles = miles_in;	
	}
	
	static void print()
	{
		System.out.printf("Vehicle Information \n");
		System.out.printf("*******************\n");
		System.out.printf("ID Number: %s\n",car_id);
		System.out.printf("Make: %s\n", car_make);
		System.out.printf("Model: %s\n", car_model);
		System.out.printf("Class: %s\n", car_class);
		System.out.printf("Rental Per Day: %.2f\n", rental_per_day);
		System.out.printf("Miles: %d\n", miles);
	}
	
	static void setmiles(int miles_in)
	{
		miles = miles_in;
	}
	
	static int getmiles()
	{
		return miles;
	}
	
}

class rentalCarTest
{
	static Scanner console = new Scanner (System.in);
	
	static void print()
	{
		System.out.printf("Enter the Vehicle's ID Number: ");
		System.out.flush();
		rentalCar.car_id = console.next();
		
		System.out.printf("Enter the Vehicle's Make: ");
		System.out.flush();
		rentalCar.car_make = console.next();
		
		System.out.printf("Enter the Vehicle's Model: ");
		System.out.flush();
		rentalCar.car_model = console.next();
		
		System.out.printf("Enter the Vehicle's Class: ");
		System.out.flush();
		rentalCar.car_class = console.next();
		
		System.out.printf("Enter the Vehicle's Rental Per Day: ");
		System.out.flush();
		rentalCar.rental_per_day = console.nextDouble();
		
		System.out.printf("Enter the Vehicle's Miles: ");
		System.out.flush();
		rentalCar.miles = console.nextInt();
	}
}

public class pass2wherry 
{
	public static void main(String[] args)
	{
		rentalCar carz = new rentalCar("VN45872", "Toyota", "Camry", "H", 55.0, 154479);
		rentalCar.print();
		System.out.printf("\n");
		
		System.out.printf("Testing Methods\n");
		rentalCar.setmiles(158741);
		System.out.printf("New Miles: %d\n\n", rentalCar.getmiles());
		
		rentalCarTest.print();
		System.out.printf("\n");
		
		rentalCar.print();		
	}
}