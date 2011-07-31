import java.io.*;
import java.util.*;
import javax.swing.*;
import javax.swing.text.*;
import javax.swing.undo.*;
import javax.swing.event.*;

/**
 * This class is responsible for listening to the output of the
compiler and
 * buffering it
 */
class StreamReader extends Thread
{
    InputStream is;
    String type;
    OutputStream os;
        JTextArea output;

    StreamReader(InputStream is, String type, JTextArea output)
    {
        this(is, type, null, output);
    }

    StreamReader(InputStream is, String type, OutputStream redirect, JTextArea output)
    {
        this.is = is;
        this.type = type;
        this.os = redirect;
                this.output = output;
    }

    public void run()
    {
          // Clear the text area for the new compilation
          Document doc = output.getDocument();
          
          try
          {
          		doc.remove(0, doc.getLength());
          }
          catch (BadLocationException textCouldNotBeRemoved)
          {
             System.out.println("There was an error creating a new file");
          }
                //output.
          try
          {    
             InputStreamReader isr = new InputStreamReader(is);
             BufferedReader br = new BufferedReader(isr);
             String line=null;
                        // Compile the program
             while ( (line = br.readLine()) != null)
             {
                // Print out whether it was an error or whether it was output and then the actual output
             	output.append(line + "\n");
                System.out.println(type + ">" + line);    
            }
          } catch (IOException ioe)
            {
            	ioe.printStackTrace();  
            }
    }

}

public class JavaCompileThread
{
        // Class constructor
        public JavaCompileThread()
        {}

    	public void compile(File filename, JTextArea output)
    	{

        	try
        	{    
            	Runtime rt = Runtime.getRuntime();
            	// Run the readstring program that requires command line input
            	Process proc = rt.exec("java " + filename);
            	// any error message?
            	StreamReader errorReader = new
                	StreamReader(proc.getErrorStream(), "ERROR", output);

            	// any output?
            	StreamReader outputReader = new
                	StreamReader(proc.getInputStream(), "OUTPUT", /*fos*/ null, output);

            	// Start the threads
            	errorReader.start();
            	outputReader.start();

            	// Check for an error
            	int exitVal = proc.waitFor();
                        if (exitVal == 0)
                        {
                                output.append("The program compiled successfully");
                        }
            	System.out.println("ExitValue: " + exitVal);      
        	} catch (InterruptedException t){t.printStackTrace();}
              catch (IOException e)
          	  {
              	System.out.println("There was an IOException");
            	e.printStackTrace();
          	  }
    	}
} 