

import java.awt.*;
import java.awt.event.*;
import java.io.*;
import javax.swing.*;
import javax.swing.event.*;
import javax.swing.text.*;

public class ExampleGroupProject extends JFrame
{
        JSplitPane splitPane;
        
        JRadioButton whitebackRB;
        JRadioButton blackTextRB;
        JRadioButton arialRB;
        JCheckBox boldCB;
        JButton findBTN;
        JTextField findTF, resultTF;
        
        backColorRadioHandler backColorHandler;
        textRadioHandler textColorHandler;
        fontRadioHandler fontHandler;
        fontComboHandler fontCHandler;
        checkBoxHandler CBHandler;
        
        JPanel lPane, rPane;
        JPanel textColorPNL,backgroundPNL,textFormatPNL, fontPNL,
                sliderPNL, findPNL;
        JTextPane editorPane;
        JSlider fontSlider;


    public ExampleGroupProject()
        {
        // create panels
        lPane = new JPanel(new GridLayout(6,1));
        rPane = new JPanel(new GridLayout(1,1));

        //create background Radio buttons
        ButtonGroup backgroundBG = new ButtonGroup();
        backColorHandler = new backColorRadioHandler();
        whitebackRB = new JRadioButton("White");
        whitebackRB.setSelected(true);
        whitebackRB.addActionListener(backColorHandler);
        backgroundBG.add(whitebackRB);
        
        
        backgroundPNL = new JPanel(new GridLayout(1,1));
        backgroundPNL.add(whitebackRB);
        
        backgroundPNL.setBackground(Color.gray);
        backgroundPNL.setBorder(BorderFactory.createCompoundBorder(
                BorderFactory.createTitledBorder("Background color"),
                BorderFactory.createLoweredBevelBorder()));
        lPane.add(backgroundPNL);

        //Creating Text Radio Buttons
        ButtonGroup textcolorBG = new ButtonGroup();
        textColorHandler = new textRadioHandler();
        
        blackTextRB = new JRadioButton("Black");
        blackTextRB.setSelected(true);
        blackTextRB.addActionListener(textColorHandler);
        textcolorBG.add(blackTextRB);
        
        textColorPNL = new JPanel(new GridLayout(1,1));
        textColorPNL.add(blackTextRB);
        
        textColorPNL.setBackground(Color.gray);
        textColorPNL.setBorder(BorderFactory.createCompoundBorder
            (BorderFactory.createTitledBorder("Text color"),
             BorderFactory.createLoweredBevelBorder()));
        lPane.add(textColorPNL);

        // radio buttons font type
        ButtonGroup fontBG = new ButtonGroup();
        fontHandler = new fontRadioHandler();
        fontCHandler = new fontComboHandler();
        arialRB = new JRadioButton("Arial");
        arialRB.setSelected(true);
        arialRB.addActionListener(fontHandler);
        fontBG.add(arialRB);
        
        
       
        
        fontPNL = new JPanel(new GridLayout(1,1));
        fontPNL.add(arialRB);
        
        fontPNL.setBackground(Color.gray);
        fontPNL.setBorder(BorderFactory.createCompoundBorder(
                BorderFactory.createTitledBorder("Text font"),
                BorderFactory.createLoweredBevelBorder()));
        lPane.add(fontPNL);


        // check boxes text format
        CBHandler = new checkBoxHandler();
        boldCB = new JCheckBox("Bold");
        boldCB.addActionListener(CBHandler);
        
        textFormatPNL = new JPanel(new GridLayout(1,1));
        textFormatPNL.add(boldCB);
        
        textFormatPNL.setBackground(Color.gray);
        textFormatPNL.setBorder(BorderFactory.createCompoundBorder
            (BorderFactory.createTitledBorder("Text format"),
             BorderFactory.createLoweredBevelBorder()));
        lPane.add(textFormatPNL);

        // font size slider
        sliderPNL = new JPanel();
        fontSlider = new JSlider(SwingConstants.HORIZONTAL, 0, 50,20);
        fontSlider.setMajorTickSpacing(10);
        fontSlider.setMinorTickSpacing(2);
        fontSlider.setPaintTicks(true);
        fontSlider.setPaintLabels(true);
        fontSlider.setValue(12);
        fontSlider.addChangeListener(new fontSliderHandler());
        sliderPNL.add(fontSlider);
        sliderPNL.setBackground(Color.gray);
        sliderPNL.setBorder(BorderFactory.createCompoundBorder
            (BorderFactory.createTitledBorder("Text size"),
             BorderFactory.createLoweredBevelBorder()));
        lPane.add(sliderPNL);

        // find text panel
        findPNL = new JPanel();
        findTF=new JTextField("Enter text to find",12);
        findPNL.add(findTF);
        findBTN = new JButton("Find");
        findBTN.addActionListener(new findHandler());
        findPNL.add(findBTN);
        resultTF = new JTextField("Find results",18);
        resultTF.setEditable(false);
        findPNL.add(resultTF);
        findPNL.setBackground(Color.gray);
        findPNL.setBorder(BorderFactory.createCompoundBorder
            (BorderFactory.createTitledBorder("Find text"),
             BorderFactory.createLoweredBevelBorder()));
        lPane.add(findPNL);

        // menu bar
        JMenuBar menuBar = new JMenuBar();
        JMenu file = new JMenu("File");
        file.setMnemonic('F');
        
        JMenuItem openMI = new JMenuItem("Open");
        openMI.setMnemonic('O');
        openMI.setAccelerator(KeyStroke.getKeyStroke('O',Toolkit.
                    getDefaultToolkit().getMenuShortcutKeyMask(), false));
        
        menuBar.setBackground(Color.gray);
        
        openMI.addActionListener(new menuListener());
        
        menuBar.add(file);
        
        file.add(openMI);
        
        setJMenuBar(menuBar);

        // create editor pane and display program as text
        editorPane = new JTextPane();
        editorPane.setFont(new Font("Arial", Font.PLAIN, 12));
        try {
            editorPane.setText(getProgram());
        }
        catch(IOException e){
            editorPane.setText("Group project not found");
        }
        JScrollPane editorScrollPane = new JScrollPane(editorPane);
        editorScrollPane.setVerticalScrollBarPolicy(
                        JScrollPane.VERTICAL_SCROLLBAR_ALWAYS);
        rPane.add(editorScrollPane);

        // setup split pane
        splitPane = new JSplitPane(JSplitPane.HORIZONTAL_SPLIT,
                                   lPane, rPane);
        Toolkit tkit= getToolkit();
        Dimension wsize=tkit.getScreenSize();
        setBounds(wsize.width/8,wsize.height/8,wsize.width*3/4,wsize.height*3/4);
        splitPane.setDividerLocation(220);
        getContentPane().add(splitPane);
        
        setVisible(true);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        }

    //Handler for background colors
    private class backColorRadioHandler implements ActionListener
    {
        public void actionPerformed(ActionEvent e)
        {
            if (e.getSource() == whitebackRB)
                editorPane.setBackground(Color.white);
            
        }
    }

    //Handler for text Colors
    private class textRadioHandler implements ActionListener
    {
        public void actionPerformed(ActionEvent e)
        {
            if(e.getSource() == blackTextRB)
                editorPane.setForeground(Color.black);
            
        }
    }

    //Handler for fonts
   private class fontRadioHandler implements ActionListener
   {
       public void actionPerformed(ActionEvent e)
       {
            if (e.getSource() == arialRB)
            {
                
                editorPane.setFont(new Font("Arial",
                    editorPane.getFont().getStyle(),fontSlider.getValue()));
            }
            
       }
   }
   // handler for combo box font selection
   private class fontComboHandler implements ActionListener
   {
       public void actionPerformed(ActionEvent e)
       {
           
           
       }
   }

   // handler for menu items
   private class menuListener implements ActionListener
   {
       public void actionPerformed(ActionEvent e)
       {
           String Cmd = e.getActionCommand();
           if(Cmd.equals("Open"))
               doOpen();
           
       }
   }

    //Handler for text enhancements
    private class checkBoxHandler implements ActionListener
    {
        public void actionPerformed(ActionEvent e)
        {
            Font f1,f2;
            if (boldCB.isSelected())
                f1=new Font(editorPane.getFont().getFamily(),
                    Font.BOLD,fontSlider.getValue());
            else
                f1=new Font(editorPane.getFont().getFamily(),
                    Font.PLAIN,fontSlider.getValue());
          
            editorPane.setFont(new Font(editorPane.getFont().getFamily(),
                   f1.getStyle() ,fontSlider.getValue()));
            
          
            
        }
    }

    //Hnadler for font slider
    public class fontSliderHandler implements ChangeListener
    {
       public void stateChanged(ChangeEvent e)
       {
           int sl = fontSlider.getValue();
           //editorPane.append(""+sl);
           editorPane.setFont(new Font(editorPane.getFont().getFamily(),
                    editorPane.getFont().getStyle(),sl));
       }
   }

   //Hnadler for finding text
    public class findHandler implements ActionListener
    {
       public void actionPerformed(ActionEvent e)
       {
               // First remove all old highlights
               Highlighter hilite = editorPane.getHighlighter();
               Highlighter.Highlight[] hilites = hilite.getHighlights();
               for (int i=0; i<hilites.length; i++)
                       hilite.removeHighlight(hilites[i]);
            try
            {
                hilite = editorPane.getHighlighter();
                Document doc = editorPane.getDocument();
                String text = doc.getText(0, doc.getLength());
                int pos = 0;
                int count = 0;
                String pattern = findTF.getText();
                // Search for pattern
                while ((pos = text.indexOf(pattern, pos)) >= 0)
                {
                    // Create highlighter apply around pattern
                    hilite.addHighlight(pos, pos+pattern.length(),
                    new DefaultHighlighter.DefaultHighlightPainter(Color.pink));
                    pos += pattern.length();
                    count++;
                } // while
                resultTF.setText("There were "+count+" matches found.");
            } // try
            catch (BadLocationException arg0){}// catch
        } // action performed
    } // event

    // main set appearance
    public static void main(String[] args)
        {
            setDefaultLookAndFeelDecorated(true);
            ExampleGroupProject gp = new ExampleGroupProject();
        }

        // save text method
        private void doSave()
        {
            File file;
            JFileChooser Save = new JFileChooser(new File("."));
            Save.setDialogTitle("Save File As...");
            int action = Save.showSaveDialog(this);
            if(action != JFileChooser.APPROVE_OPTION)
            {
                return;
            }
            file = Save.getSelectedFile();
            if(file.exists())
            {
                action = JOptionPane.showConfirmDialog
                         (this, "Replace existing file?");
                if(action != JOptionPane.YES_OPTION)
                    return;
            }
            try
              {
              PrintWriter out = new PrintWriter(new FileWriter(file));
              String contents = editorPane.getText();
              out.println(contents);
              if(out.checkError())
              throw new IOException("Error while writing file to disk");
              out.close();
              }
            catch(IOException e)
            {
              JOptionPane.showMessageDialog
                      (this, "Sorry, an error has occurred: \n" +
              e.getMessage());
            }
        }

        // open file method
        private void doOpen()
        {
            File file;
            JFileChooser chooser = new JFileChooser(new File("."));
            chooser.setDialogTitle("Open file...");
            int actionOpen = chooser.showOpenDialog(this);
            if(actionOpen != JFileChooser.APPROVE_OPTION)
            {
                return;
            }
            file = chooser.getSelectedFile();
            String line;
            editorPane.setText("");
            try
               {
               BufferedReader in = new BufferedReader(new FileReader(file));
               JTextArea pane = new JTextArea();
               while ((line = in.readLine()) != null)
               {
               pane.append(line + '\n');
               }
               in.close();
               editorPane.setText(pane.getText());
               }
               catch(Exception e)
               {
               JOptionPane.showMessageDialog
               (this, "Sorry, some error has occurred: \n" + e.getMessage());
               }
           }
           // quit method
           private void doQuit()
           {
               doSave();
               System.exit(0);
           }
           // new method
           private void doNew()
           {
               doSave();
               editorPane.setText("");
           }

      private String getProgram()throws IOException
       {
       // opens file from current location if useing JCreater
       // or from scr/ if using JBuilder
       // and returns as string
       JTextArea pane = new JTextArea("");
       String input;
       BufferedReader inFile;
       try {
           inFile = new BufferedReader
                               (new FileReader("SwingExamples.java"));
       }
       catch (IOException e){
           inFile = new BufferedReader
                               (new FileReader("SwingExamples.java"));
       }
       while ((input  = inFile.readLine()) != null)
           pane.append(input+"\n");
       return pane.getText();
   }
   
}
//######################### END PROGRAM#################################
