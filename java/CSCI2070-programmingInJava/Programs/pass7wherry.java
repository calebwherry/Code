// Caleb Wherry
// pass7wherry.java
// 04/18/07
/* Purpose: To read in names from a file, sort them, and display them to the moniter using multiple threads.*/

import java.io.*;
import java.util.Arrays;

public class pass7wherry implements Runnable
{
	String[] names = new String[60];
	
	pass7wherry()
	{
		Thread read = Thread.currentThread();
		read.setName("Read Thread");
		Thread sort = new Thread(this, "Sort");
		Thread display = new Thread(this, "Display");
		
		sort.start();
		display.start();
	
		try
		{
			FileReader fr = new FileReader("names.txt");
			BufferedReader br = new BufferedReader(fr); 
				
			String name = null;
			
			int i = 0;
     	 	while((name = br.readLine()) != null)
     	 	{	
     	 		names[i] = name;
     	 		i++;
     	 	}
        	
			fr.close();
		}
		catch (Exception e) {System.out.println("Exception: " + e);}
	}
    
    public void run()
    {
    	Thread cur = Thread.currentThread();
    	
    	if ((cur.getName()).compareTo("Sort") == 0)
    	{
    		try
    		{
    			Arrays.sort(names);
    		}
    		catch (Exception e) {System.out.println("Exception: " + e);}
    	}
    	
    	if ((cur.getName()).compareTo("Display") == 0)
    	{
    		try
    		{
    			for (int i=0; i<20; i++)
    				System.out.println(names[i]);
    				
    			Thread.sleep(1000);
    			
    			for (int i=20; i<40; i++)
    				System.out.println(names[i]);
    				
    			Thread.sleep(1000);
    			
    			for (int i=40; i<60; i++)
    				System.out.println(names[i]);	
    		}
    		catch (Exception e) {System.out.println("Exception: " + e);}
    	}
    }
    
    public static void main (String args[])
	{
		new pass7wherry();
	} 
}