// Java 2070: Group #1 Project
//
// **********************
// Caleb Wherry
// Harshan Patel
// Joseph Larrew
// Christopher Cook
// **********************
//
// 3-22-07
/* Purpose: To create a single JFrame window with multipe panes that
             edits a file in many ways through implemetation of
             various Java tools and methods. */

import java.awt.*;
import java.awt.event.*;
import static java.awt.event.InputEvent.*;
import java.awt.print.*;
import java.io.*;
import java.util.*;
import javax.print.*;
import javax.swing.*;
import javax.swing.event.*;
import javax.swing.filechooser.FileFilter;
import javax.swing.text.*;
import javax.swing.text.html.HTMLDocument;


public class GroupProject extends JFrame
{
	 JMenuBar menuBar;
	 JMenu fileMenu;
	 JMenuItem newItem, openItem, closeItem, saveItem, printItem;
	 JMenu colorMenu;
	 JMenuItem redItem, orangeItem, yellowItem, greenItem, blueItem, cyanItem, whiteItem, blackItem; 
	 JMenu aboutMenu;
	 JMenuItem creatorsItem, versionItem, disclaimerItem;
	 JToolBar toolBar;
	 JButton compileB, runB;
	 File file;
	 JFileChooser chooser;
	 JSplitPane vpane; 
	 JSplitPane hpane;
	 JScrollPane scrollPane; 
	 JTextPane textPane;
	 JPanel labelPane;
	 JPanel firstLabel, secondLabel, thirdLabel, 
	 		fourthLabel, fifthLabel, sixthLabel;
	 ButtonGroup group1, group2, group3;
	 JRadioButton whitebackRB, greenbackRB, cyanbuttonRB, custombuttonRB;  // Background Color RadioButtons
	 JRadioButton blackfontRB, bluefontRB, redfontRB, customfontcolorRB;   // Text Color RadioButtons
	 JRadioButton arialfontRB, courierfontRB, timesfontRB;	       		   // Text Font RadioButtons
	 JCheckBox boldBox, italicBox;                                         // Text Format Check Boxes
	 JSlider myJSlider;										               // Text Size Slider
	 JButton TfindB;
	 JTextField TfindTF, foundTF;						
	
	 public GroupProject()
	 {
     	labelPane = new JPanel(new GridLayout(6,1));
     	labelPane.setBackground(Color.gray);
		
			firstLabel = new JPanel(new GridLayout(4,1));
			firstLabel.setBorder(BorderFactory.createCompoundBorder
            					(BorderFactory.createTitledBorder("Background Color"),
             					 BorderFactory.createLoweredBevelBorder()));
   				group1 = new ButtonGroup();
   				
   				whitebackRB = new JRadioButton("White");
   				firstLabel.add(whitebackRB);
   				group1.add(whitebackRB);
   				
   				greenbackRB = new JRadioButton("Green");
   				firstLabel.add(greenbackRB);
   				group1.add(greenbackRB);
   				
   				cyanbuttonRB = new JRadioButton("Cyan");
   				firstLabel.add(cyanbuttonRB);
   				group1.add(cyanbuttonRB);
   				
   				custombuttonRB = new JRadioButton("Custom");
   				firstLabel.add(custombuttonRB);
   				group1.add(custombuttonRB);
   				
   				firstLabel.setBackground(Color.gray);	
   			labelPane.add(firstLabel);
   						
   			secondLabel = new JPanel(new GridLayout(4,1));
			secondLabel.setBorder(BorderFactory.createCompoundBorder
            					 (BorderFactory.createTitledBorder("Text Color"),
             					  BorderFactory.createLoweredBevelBorder()));
				group2 = new ButtonGroup();
				
				blackfontRB = new JRadioButton("Black");
				secondLabel.add(blackfontRB);
   				group2.add(blackfontRB);
   				
   				bluefontRB = new JRadioButton("Blue");
   				group2.add(bluefontRB);
   				secondLabel.add(bluefontRB);
   				
   				redfontRB = new JRadioButton("Red");
   				secondLabel.add(redfontRB);
   				group2.add(redfontRB);
   				
   				customfontcolorRB = new JRadioButton("Custom");
   				secondLabel.add(customfontcolorRB);
   				group2.add(customfontcolorRB);
   				
   				secondLabel.setBackground(Color.gray);
   			labelPane.add(secondLabel);	
   			
   									
			thirdLabel = new JPanel(new GridLayout(3,1));
			thirdLabel.setBorder(BorderFactory.createCompoundBorder
            				    (BorderFactory.createTitledBorder("Text Font"),
                                 BorderFactory.createLoweredBevelBorder()));
				group3 = new ButtonGroup();
   				
   				arialfontRB = new JRadioButton("Arial");
   				thirdLabel.add(arialfontRB);
   				group3.add(arialfontRB);
   				
   				courierfontRB = new JRadioButton("Courier");
   				thirdLabel.add(courierfontRB);
   				group3.add(courierfontRB);
   				
   				timesfontRB = new JRadioButton("Times");
   				thirdLabel.add(timesfontRB);
   				group3.add(timesfontRB);
   				
   				thirdLabel.setBackground(Color.gray);
   			labelPane.add(thirdLabel);
									
			fourthLabel = new JPanel(new GridLayout(2,1));
			fourthLabel.setBorder(BorderFactory.createCompoundBorder
            					 (BorderFactory.createTitledBorder("Text Format"),
             					  BorderFactory.createLoweredBevelBorder()));
				boldBox = new JCheckBox("Bold");
				fourthLabel.add(boldBox);
				italicBox = new JCheckBox("Italic");
				fourthLabel.add(italicBox);
				fourthLabel.setBackground(Color.gray);
			labelPane.add(fourthLabel);
			
			fifthLabel = new JPanel(new GridLayout());
			fifthLabel.setBorder(BorderFactory.createCompoundBorder
            					(BorderFactory.createTitledBorder("Text Size"),
             					 BorderFactory.createLoweredBevelBorder()));
				myJSlider = new JSlider(SwingConstants.HORIZONTAL, 0, 50, 20);
				myJSlider.setMajorTickSpacing(10);
				myJSlider.setMinorTickSpacing(2);
				myJSlider.setPaintTicks(true);
				myJSlider.setPaintLabels(true);
				myJSlider.setValue(12);
				fifthLabel.add(myJSlider);
				fifthLabel.setBackground(Color.gray);
			labelPane.add(fifthLabel);
			
			sixthLabel = new JPanel();
			sixthLabel.setBorder(BorderFactory.createCompoundBorder
            					(BorderFactory.createTitledBorder("Find Text"),
             					 BorderFactory.createLoweredBevelBorder()));
				TfindTF = new JTextField("Enter Text To Find", 12);
				sixthLabel.add(TfindTF);
				TfindB = new JButton("Find");
				sixthLabel.add(TfindB);
				foundTF = new JTextField("Found results",18);
        		foundTF.setEditable(false);
        		sixthLabel.add(foundTF);
				sixthLabel.setBackground(Color.gray);
			labelPane.add(sixthLabel);
						 
      	textPane = new JTextPane();
      	textPane.setBackground(Color.black);
      	textPane.setForeground(Color.white);
      	textPane.setFont(new Font("Arial", Font.PLAIN, 12));
      	try 
      	{
            textPane.setText(defaultProgram());
        }
        catch(IOException e)
        {
        	textPane.setText("Java Program Not Found");
        }
       			
		scrollPane = new JScrollPane(textPane);
     	
			// JMenu
		menuBar = new JMenuBar();
    	setJMenuBar(menuBar);
    	menuBar.setBackground(Color.gray);
    	
    	fileMenu = new JMenu("File");
    	fileMenu.setMnemonic('F');
   
   		newItem = fileMenu.add("New");
   		newItem.setMnemonic('N');
    	openItem = fileMenu.add("Open");
    	openItem.setMnemonic('O');
   		closeItem = fileMenu.add("Close");
   		closeItem.setMnemonic('C');
   		fileMenu.addSeparator();
   		saveItem = fileMenu.add("Save");
   		saveItem.setMnemonic('S');    	
  		fileMenu.addSeparator();
    	printItem = fileMenu.add("Print");
    	printItem.setMnemonic('P'); 
    	
       	newItem.setAccelerator(KeyStroke.getKeyStroke('N',CTRL_DOWN_MASK));
    	openItem.setAccelerator(KeyStroke.getKeyStroke('O',CTRL_DOWN_MASK));
    	closeItem.setAccelerator(KeyStroke.getKeyStroke('C', CTRL_DOWN_MASK));
    	saveItem.setAccelerator(KeyStroke.getKeyStroke('S',CTRL_DOWN_MASK));
    	printItem.setAccelerator(KeyStroke.getKeyStroke('P',CTRL_DOWN_MASK));
    	
    	menuBar.add(fileMenu);
    	
    	colorMenu = new JMenu("Color");
    	colorMenu.setMnemonic('L');
    	
    	redItem = colorMenu.add("Red");
    	orangeItem = colorMenu.add("Orange");
    	yellowItem = colorMenu.add("Yellow");
    	greenItem = colorMenu.add("Green");
    	blueItem = colorMenu.add("Blue");
    	cyanItem = colorMenu.add("Cyan");
    	whiteItem = colorMenu.add("White");
    	blackItem = colorMenu.add("Black");
    	
    	menuBar.add(colorMenu);
    	
    	aboutMenu = new JMenu("About");
    	aboutMenu.setMnemonic('B');
    	
    	creatorsItem = aboutMenu.add("Creators");
    	creatorsItem.setMnemonic('R');
    	versionItem = aboutMenu.add("Version");
    	versionItem.setMnemonic('V');
    	disclaimerItem = aboutMenu.add("Disclaimer");
    	disclaimerItem.setMnemonic('D');
    	
    	creatorsItem.setAccelerator(KeyStroke.getKeyStroke('R',CTRL_DOWN_MASK));
    	versionItem.setAccelerator(KeyStroke.getKeyStroke('V',CTRL_DOWN_MASK));
    	disclaimerItem.setAccelerator(KeyStroke.getKeyStroke('D',CTRL_DOWN_MASK));
    	
    	menuBar.add(aboutMenu);
  
    	toolBar = new JToolBar();
    	compileB = new JButton("Compile");
    	runB = new JButton("Run");
    	toolBar.add(compileB);
    	toolBar.addSeparator();
    	toolBar.add(runB);
    	toolBar.setFloatable(false);
  
			// Add Action Listeners to Menu Items
		newItem.addActionListener(new menuListener());
		openItem.addActionListener(new menuListener());
		closeItem.addActionListener(new menuListener());
     	saveItem.addActionListener(new menuListener());
     	printItem.addActionListener(new menuListener());
     	
     	creatorsItem.addActionListener(new aboutMenuListener());
     	versionItem.addActionListener(new aboutMenuListener());
     	disclaimerItem.addActionListener(new aboutMenuListener());
     		// Add Action Listener to Compile Button
     	compileB.addActionListener(new compileListener());
     	runB.addActionListener(new runListener());
     		// Add Action Listeners to Background Color Radio Buttons
     	whitebackRB.addActionListener(new backGroundListener());
     	greenbackRB.addActionListener(new backGroundListener());
     	cyanbuttonRB.addActionListener(new backGroundListener());
     	custombuttonRB.addActionListener(new backGroundListener());
     	
     	redItem.addActionListener(new backGroundListener());
     	orangeItem.addActionListener(new backGroundListener());
     	yellowItem.addActionListener(new backGroundListener());
     	greenItem.addActionListener(new backGroundListener());
     	blueItem.addActionListener(new backGroundListener());
     	cyanItem.addActionListener(new backGroundListener());
     	whiteItem.addActionListener(new backGroundListener());
     	blackItem.addActionListener(new backGroundListener());
     		// Add Action Listeners to Text Color Radio Buttons
     	blackfontRB.addActionListener(new textColorListener());
     	bluefontRB.addActionListener(new textColorListener());
     	redfontRB.addActionListener(new textColorListener());
     	customfontcolorRB.addActionListener(new textColorListener());
     		// Add Action Listeners to Text Font Radio Buttons
     	arialfontRB.addActionListener(new textFontListener());
     	courierfontRB.addActionListener(new textFontListener());
     	timesfontRB.addActionListener(new textFontListener());
     		// Add Action Listener to Text Format Check Boxes
     	boldBox.addItemListener(new textFormatListener());
     	italicBox.addItemListener(new textFormatListener());
     		// Add Action Listener to Text Size Slider
     	myJSlider.addChangeListener(new textSizeListener());
     		// Add Action Listener to Text Find Button
     	TfindB.addActionListener(new textFindListener());
     	
     	hpane = new JSplitPane(JSplitPane.HORIZONTAL_SPLIT, labelPane, scrollPane);
        hpane.setDividerLocation(225);
     	
     	vpane = new JSplitPane(JSplitPane.VERTICAL_SPLIT, toolBar, hpane);
     	vpane.setDividerLocation(25);
     	
		setTitle("Java Program Editor");
	
		setContentPane(vpane);
		
		setVisible(true);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
	 }
	
	 public class menuListener implements ActionListener, Printable
	 {
	 	public void actionPerformed(ActionEvent e)
	 	{
	 		if (e.getActionCommand().equals("New"))
	 			NewFile();
	 		if (e.getActionCommand().equals("Open"))
	 			OpenFile();
	 		if (e.getActionCommand().equals("Close"))
	 			CloseFile();
	 		if (e.getActionCommand().equals("Save"))
	 			SaveFile();
	 		if (e.getActionCommand().equals("Print"))
	 		{ 
	 			PrinterJob printJob = PrinterJob.getPrinterJob();
         		printJob.setPrintable(this);
         		textPane.getDocument();
         		
         		boolean ok = printJob.printDialog();
         		
         		if (ok)
         		{
             		try
             		{
                  		printJob.print();
             		} 
             		
             		catch (PrinterException ex)
             		{
                   		throw new RuntimeException(ex);
             		}
         		}				
    		}
	 	}
	 	
	 	public int print(Graphics g, PageFormat pf, int page) throws PrinterException
	 	{
	 		if (page > 0)
	 			return NO_SUCH_PAGE;
        	Graphics2D g2d = (Graphics2D)g;
        	g2d.translate(pf.getImageableX(), pf.getImageableY());
        	textPane.printAll(g);
        	return PAGE_EXISTS;
    	}
	 }
	 
	 private class aboutMenuListener implements ActionListener
	 {
	 	public void actionPerformed(ActionEvent e)
	 	{
	 		if (e.getActionCommand().equals("Creators"))
	 		{
	 			String output_str;
	 			
	 			output_str = String.format("Caleb Wherry %n"
	 										+ "Harshan Patel %n"
	 										+ "Joseph Larrew %n"
	 										+ "Christopher Cook");
	 			
	 			JOptionPane.showMessageDialog(null, output_str, 
	 											"Creators of JPE", JOptionPane.INFORMATION_MESSAGE);
	 		}
	 		
	 		if (e.getActionCommand().equals("Version"))
	 		{
	 			JOptionPane.showMessageDialog(null, "Java Program Editor version 1.0",
	 											"Version", JOptionPane.INFORMATION_MESSAGE);
	 		}
	 		
	 		if (e.getActionCommand().equals("Disclaimer"))
	 		{
	 			String output_str;
	 			
	 			output_str = String.format("We, the creators of JPE, hold no responsibility %n"
											+ "in the actions of this program. Any problems %n"
											+ "occurring during the operation of this program %n"
											+ "are purely coincidental and have no correlation to %n"
											+ "the functions of this program. This may include, %n"
											+ "but are not are not limited to: the selling of your %n"
											+ "house, your taxes being filed, your children %n"
											+ "getting abducted by aliens, your cat, dog, horse, %n"
											+ "turtle, pet rock, or pig being sold, your car catching %n"
											+ "on fire, or any other event that occurs during the %n"
											+ "operation of this program! %n");

	 			JOptionPane.showMessageDialog(null, output_str, 
	 											"Disclaimer", JOptionPane.INFORMATION_MESSAGE);
	 		}	
	 	}
	 }
	 
	 private class compileListener implements ActionListener
	 {
	 	public void actionPerformed(ActionEvent e)
	 	{
	 		try
	 		{
	 			Runtime rt = Runtime.getRuntime();
	 			Process prcs = rt.exec("javac " + file);
	 		}
	 		
	 		catch (Exception arg)
	 		{
	 			JOptionPane.showMessageDialog(null, "Error Compiling Program!", 
	 											"Error", JOptionPane.INFORMATION_MESSAGE);
	 		}
        }
	 }
	 
	 private class runListener implements ActionListener
	 {
	 	public void actionPerformed(ActionEvent e)
	 	{
	 		try
	 		{
	 			Runtime rt = Runtime.getRuntime();
	 			Process prcs = rt.exec("java " + file);
	 		}
	 		
	 		catch (Exception arg)
	 		{
	 			JOptionPane.showMessageDialog(null, "Error Running Program!", 
	 											"Error", JOptionPane.INFORMATION_MESSAGE);
	 		}
        }
	 }
	 
	 private class backGroundListener implements ActionListener
	 {
	 	public void actionPerformed(ActionEvent e)
	 	{
            if (e.getActionCommand().equals("White"))
                textPane.setBackground(Color.white);
            if (e.getActionCommand().equals("Green"))
            	textPane.setBackground(Color.green);
            if (e.getActionCommand().equals("Cyan"))
            	textPane.setBackground(Color.cyan);
			if (e.getActionCommand().equals("Custom"))	
	 		{
	 			JColorChooser colorChooser = new JColorChooser();
	 			Color chosenColor = colorChooser.showDialog(null,
                                "Choose a color:",
                                Color.WHITE);           
                textPane.setBackground(chosenColor);
	 		}
	 		if (e.getSource() == redItem)
	 			textPane.setBackground(Color.red);
	 		if (e.getSource() == orangeItem)
	 			textPane.setBackground(Color.orange);
	 		if (e.getSource() == yellowItem)
	 			textPane.setBackground(Color.yellow);
	 		if (e.getSource() == greenItem)
	 			textPane.setBackground(Color.green);	
	 		if (e.getSource() == blueItem)
	 			textPane.setBackground(Color.blue);	
	 		if (e.getSource() == cyanItem)
	 			textPane.setBackground(Color.cyan);	
	 		if (e.getSource() == whiteItem)
	 			textPane.setBackground(Color.white);	
	 		if (e.getSource() == blackItem)
	 			textPane.setBackground(Color.black);						
	 	}
	 }
	 
	 private class textColorListener implements ActionListener
	 {
	 	public void actionPerformed(ActionEvent e)
	 	{
	 		if(e.getActionCommand().equals("Black"))
                textPane.setForeground(Color.black);		 
            if(e.getActionCommand().equals("Blue"))
                textPane.setForeground(Color.blue);	
            if(e.getActionCommand().equals("Red"))
                textPane.setForeground(Color.red);
			if (e.getActionCommand().equals("Custom"))	
	 		{
	 			JColorChooser colorChooser = new JColorChooser();
	 			Color chosenColor = colorChooser.showDialog(null,
                                "Choose a color:",
                                Color.WHITE);           
                textPane.setForeground(chosenColor);
	 		}		       
	 	}
	 }
	 
	 private class textFontListener implements ActionListener
	 {
	 	public void actionPerformed(ActionEvent e)
	 	{
	 		if(e.getActionCommand().equals("Arial"))
	 			textPane.setFont( new Font("Arial", textPane.getFont().getStyle(), myJSlider.getValue()));
	 			
	 		if(e.getActionCommand().equals("Courier"))
	 			textPane.setFont( new Font("Courier", textPane.getFont().getStyle(), myJSlider.getValue()));
	 			
	 		if(e.getActionCommand().equals("Times"))
	 			textPane.setFont( new Font("TimesRoman", textPane.getFont().getStyle(), myJSlider.getValue()));
	 	}
	 }
	 
	 private class textFormatListener implements ItemListener
	 {
	 	public void itemStateChanged (ItemEvent e)
	 	{
	 		int bold = Font.PLAIN;
			int italic = Font.PLAIN;
			
			if (e.getSource() == boldBox)
			{
				if (e.getStateChange() == ItemEvent.SELECTED) 
				{
		    		bold = Font.BOLD;
				}
				else
				{
		    		bold = Font.PLAIN;
				}
	    	} 
	    		
	    	if (e.getSource() == italicBox)
	    	{
				if (e.getStateChange() == ItemEvent.SELECTED )
				{
		    		italic = Font.ITALIC;
				} 
				else
				{
		    		italic = Font.PLAIN;
				}
	 		}
	 		
	 		textPane.setFont( new Font(textPane.getFont().getFamily(), bold + italic, myJSlider.getValue()));	
	    }
	 }
	 
	 private class textSizeListener implements ChangeListener
	 {
	 	public void stateChanged(ChangeEvent e)
	 	{
        	textPane.setFont(new Font(textPane.getFont().getFamily(), 
        							  textPane.getFont().getStyle(), myJSlider.getValue()));	
	 	}
	 }
	 
	 private class textFindListener implements ActionListener
	 {
	 	public void actionPerformed(ActionEvent e)
        {
  			Highlighter hilite_text = textPane.getHighlighter();
            Highlighter.Highlight[] hilites = hilite_text.getHighlights();
            for (int i=0; i<hilites.length; i++)
            	hilite_text.removeHighlight(hilites[i]);
            try
            {
            	hilite_text = textPane.getHighlighter();
                Document doc = textPane.getDocument();
                String text = doc.getText(0, doc.getLength());
                int pos = 0;
                int finds = 0;
                String pattern = TfindTF.getText();
                
                while ((pos = text.indexOf(pattern, pos)) >= 0)
                {
                    hilite_text.addHighlight(pos, pos+pattern.length(),
                    new DefaultHighlighter.DefaultHighlightPainter(Color.red));
                    pos += pattern.length();
                    finds++;
                } 
                foundTF.setText("There were "+finds+" matches found.");
            } 
            catch (BadLocationException arg0){} 
        } 
	 }
	 
	 public class ExtensionFilter extends FileFilter
	 {
	 	String description, extension;
	 	
	 	public ExtensionFilter(String ext, String descr)
	 	{
	 		extension = ext.toLowerCase();
	 		description = descr;
	 	}
	 	
	 	public boolean accept(File file)
	 	{
	 		return (file.isDirectory()||file.getName().toLowerCase().endsWith(extension));
	 	}
	 	
	 	public String getDescription()
	 	{
	 		return description;
	 	}
	 }
	 
	 private void NewFile()
	 {
	 	SaveFile();
	 	textPane.setText("");	
	 }

	 private void OpenFile()
     {
     	chooser = new JFileChooser();
        chooser.setDialogTitle("Open File");
        chooser.setFileSelectionMode(chooser.FILES_ONLY);
        chooser.setAcceptAllFileFilterUsed(false);
        
        ExtensionFilter programFilter = new ExtensionFilter(".java", "Java Files (*.java)");
        chooser.addChoosableFileFilter(programFilter);
        chooser.setFileFilter(programFilter);
            
        int result = chooser.showOpenDialog(null);
        if (result == JFileChooser.APPROVE_OPTION) 
        {
        	 file = chooser.getSelectedFile();
             textPane.setText("");
             String line;
                
             try 
             {
              	BufferedReader myBufferedFileReader =
                         new BufferedReader(new FileReader(file));
                JTextArea pane = new JTextArea();

                while ((line = myBufferedFileReader.readLine()) != null)
      			{
               		pane.append(line + '\n');
               	}
               	myBufferedFileReader.close();
               	textPane.setText(pane.getText());
              }
              catch (IOException e) {}
         }
     }
     
     private void CloseFile()
     {
     	SaveFile();
     	System.exit(0);
     }
     
     private void SaveFile()
     {
        JFileChooser chooser = new JFileChooser(new File("."));
        chooser.setDialogTitle("Save File");
        
        chooser.setFileSelectionMode(chooser.FILES_ONLY);
        chooser.setAcceptAllFileFilterUsed(false);
        
        ExtensionFilter programFilter = new ExtensionFilter(".java", "Java Files (*.java)");
        chooser.addChoosableFileFilter(programFilter);
        chooser.setFileFilter(programFilter);
        
        int event = chooser.showSaveDialog(this);
        if(event != JFileChooser.APPROVE_OPTION)
        {
    	    return;
        }
        
        file = chooser.getSelectedFile();
        
        if(file.exists())
        {
    	    event = JOptionPane.showConfirmDialog(this, "Replace existing file?");
            if(event != JOptionPane.YES_OPTION)
            	return;
        }
        
        try
        {
        	PrintWriter output = new PrintWriter(new FileWriter(file));
            String text = textPane.getText();
            output.println(text);
            if(output.checkError())
            	throw new IOException("Error while writing file to disk");
            output.close();
        }
        
        catch(IOException e)
        {
      		JOptionPane.showMessageDialog(this, "Sorry, an error has occurred: \n" + e.getMessage());
        }
     }
     
     private String defaultProgram() throws IOException
     {
     	JTextArea program = new JTextArea("");
        String program_text;
        BufferedReader file;
        try 
        {
            file = new BufferedReader(new FileReader("GroupProject.java"));
        }
        catch (IOException e)
        {
            file = new BufferedReader(new FileReader("GroupProject.java"));
        }
        while ((program_text = file.readLine()) != null)
            program.append(program_text+"\n");
     	return program.getText();
     }
     
     //*******************************************************
	 //*******************************************************
	 
	 public static void main (String[] args)
	 {	 
	 	setDefaultLookAndFeelDecorated(true);
	 	GroupProject window = new GroupProject();
	 		
	 	Toolkit theKit = window.getToolkit();
		Dimension wndSize = theKit.getScreenSize();
	    window.setBounds(wndSize.width/8, wndSize.height/8,wndSize.width*3/4, wndSize.height*3/4);
	 }
	 
     //*******************************************************
	 //*******************************************************	 
}	