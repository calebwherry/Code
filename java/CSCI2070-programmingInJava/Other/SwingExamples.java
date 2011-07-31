/*
 * Created on Jul 25, 2004
 */
import java.awt.*;
import java.awt.event.*;
import java.io.*;
import java.util.*;
import javax.swing.*;
import javax.swing.border.LineBorder;
import javax.swing.event.*;
import javax.swing.text.EditorKit;

/**
 * This program displays a number of Swing components. Each time a
 * component is acted upon in some way, this program reads its own
 * source code and displays a listing of the statements used to
 * implement that component.
 * 
 * Because this program reads its own source code, comments and blank
 * lines actually affect the correct operation of the program.
 * Information about a Swing component starts with a comment line
 * that begins with "//$ " and contains the name of the component,
 * and ends with a blank line.
 * 
 * @author David Matuszek
 * @version Jul 25, 2004
 */
public class SwingExamples extends JFrame {
    private static final long serialVersionUID = 1L;

    /*
    //$ To use a Swing GUI, you need a class that extends JFrame or JApplet
    public class SwingExamples extends JFrame {

*/
    SwingExamples enclosingJFrame;
    
    ArrayList sourceCode = new ArrayList();
    JPanel labelPanel;
    
    //$ Declare and define a JButton    
    private JButton myJButton = new JButton("This is a JButton");
    
    //$ Declare and define a JCheckBox
    private JCheckBox myJCheckBox = new JCheckBox("This is a JCheckBox");
    
    //$ Declare and define some JRadioButtons
    private JRadioButton myJRadioButton1 =
        new JRadioButton("These are JRadioButtons...");
    private JRadioButton myJRadioButton2 =
        new JRadioButton("...in a ButtonGroup");
    
    //$ Declare and define a ButtonGroup to hold the JRadioButtons
    private ButtonGroup myButtonGroup = new ButtonGroup();
    
    //$ Declare and define a JTextField
    private JTextField myJTextField = new JTextField("This is a JTextField");
    
    //$ Declare and define a JTextArea
    private JTextArea myJTextArea =
        new JTextArea("This is a JTextArea;\n"
                      + "hit 'Enter' to see code");
    
    //$ Declare and define a JLabel
    JLabel myJLabel = new JLabel("This is a JLabel");
    
    //$ Declare and define a JComboBox
    private JComboBox myJComboBox = new JComboBox(new String[]
         {"JComboBox", "JFrame", "JEditorPane", "JScrollPane",
          "Window closing"} );
    
    //$ Declare and define a JSlider
    private JSlider myJSlider =
        new JSlider(SwingConstants.HORIZONTAL, 0, 50, 20);
    
    //$ Declare and define a JColorChooser
    JColorChooser colorChooser = new JColorChooser();
    
    //---------------------
    
    //$ Declare and define a JEditorPane
    private JEditorPane myJEditorPane = new JEditorPane();
    
    //$ Declare a JScrollPane that will be used to hold the JEditorPane
    // JScrollPanes can be used to hold any large component that you might want to scroll
    JScrollPane myJScrollPane;
    
    //$ Declare and define a JMenuBar, a JMenu, and a JMenuItem
    JMenuBar myJMenuBar = new JMenuBar();
    JMenu myJMenu = new JMenu("Menu");
    JMenuItem myJMenuItem = new JMenuItem("Menu Item"); 
    
    // Create additional menu items (whose code will not be displayed)
    JMenu dialogsMenu = new JMenu("Dialogs");
    JMenuItem messageDialogItem = new JMenuItem("Message dialog");
    JMenuItem confirmDialogItem = new JMenuItem("Confirm dialog");
    JMenuItem inputDialogItem = new JMenuItem("Input dialog");
    JMenuItem optionDialogItem = new JMenuItem("Option dialog");
    JMenuItem colorChooserDialogItem = new JMenuItem("JColorChooser dialog");
    JMenuItem loadFileDialogItem = new JMenuItem("Load file dialog");
    JMenuItem saveFileDialogItem = new JMenuItem("Save file dialog");
    
    JMenu helpMenu = new JMenu("Help");
    JMenuItem helpMenuItem = new JMenuItem("What does this program do?");
    JMenuItem sampleApplicationItem = new JMenuItem("Sample Swing application");
    JMenuItem sampleAppletItem = new JMenuItem("Sample Swing applet");
    
//$ What does this program do?
//
//   Various Swing components are shown in the upper window.
//   You can see the code that implements each Component by
//   clicking on it.
//
//   Only the most basic features of the various Swing components
//   are shown--just enough to get you started using them. Swing
//   has more components and many, many more features, which you
//   can find out about in the Java API.
//
//   The displayed code is freely available for your use. You can
//   copy the code and paste it into your own program, though you
//   will probably want to change the variable names (beginning
//   with "my") to something more appropriate. The program itself
//   is copyright 2004 by David Matuszek, and permission is hereby
//   granted for noncommercial educational uses.

    /**
     * Displays code for various (simple) Swing components.
     * @param args Not used.
     */
    public static void main(String[] args) {
//        String propertyString = System.getProperties().toString();
//        String properties = propertyString.replaceAll(",", "\n");
//        System.out.println(properties);
        SwingExamples mySwingExamples = new SwingExamples();
        mySwingExamples.enclosingJFrame = mySwingExamples;
        mySwingExamples.run();
        mySwingExamples.tellAbout("this program");
    }
    
    private void run() {
        readInThisProgramAsData();
        createTheGui();
        installTheListeners();
        
        //$ You can specify what to do when a JFrame is closed
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        // or HIDE_ON_CLOSE, DISPOSE_ON_CLOSE, or DO_NOTHING_ON_CLOSE
        // (the last of these requires you to handle window closings yourself)
        
    }

    /**
     * Reads the source code for this program. It is an error
     * if the source code is not in the same directory as the
     * executable.
     */
    private void readInThisProgramAsData() {
//        String separator = System.getProperty("file.separator");
//        char separatorCharacter = separator.charAt(0);
//        String pathToPackage = System.getProperty("user.dir");
//
//        // The following DOES NOT WORK on MS Windows!
////        String fileName = getClass().getName().replaceAll(".", separator);
//        
//        // This replacement code works on Windows
//        String fileName = getClass().getName();
//        StringBuffer buffer = new StringBuffer(fileName);
//        for (int i = 0; i < buffer.length(); i++) {
//            if (buffer.charAt(i) == '.') {
//                buffer.setCharAt(i, separatorCharacter); 
//            }
//        }
//        fileName = new String(buffer);
//        
//        String nameOfSourceFile = pathToPackage + separator + fileName + ".java";
        
        String nameOfSourceFile = "SwingExamples.java";
        
        try {
            BufferedReader in = getReader(nameOfSourceFile);
            String line = in.readLine();
            while (line != null) {
                sourceCode.add(line);
                line = in.readLine();
            }
        }
        catch (FileNotFoundException e) {
            JOptionPane.showMessageDialog(this, "Could not find file \""
                    + nameOfSourceFile + "\"\n"
                    + "Source code must be kept with executable. ");
            System.exit(1);
        }
        catch (IOException e) {
            e.printStackTrace();
        }
        finally {
            
        }
    }
    
    /**
     * Given the name of a file in the same directory <i>or jar file</i> as
     * this class, returns a BufferedReader for the file. The reader supports
     * the readLine() method. It is the caller's responsibility to close the
     * reader when finished.
     * 
     * @param fileName The name of a text file to read.
     * @return A reader for the file.
     */
    static BufferedReader getReader(String fileName) {
        InputStream inputStream;
        InputStreamReader streamReader;
        BufferedReader reader;
        
        inputStream = SwingExamples.class.getResourceAsStream(fileName);
        streamReader = new InputStreamReader(inputStream);
        reader = new BufferedReader(streamReader);

        return reader;
    }
    
    /**
     * 
     */
    private void createTheGui() {
        int numberOfSubPanels = 9;
        
        //$ You can use JPanels as components of your JFrame or JApplet
        JPanel controlPanel = new JPanel();
        JPanel myJPanelForResults = new JPanel();
        JPanel[] panels = new JPanel[numberOfSubPanels];
        
        //$ Define a JScrollPane to hold the JPanel that contains a JEditorPane
        myJScrollPane = new JScrollPane(myJPanelForResults);
        
        //$ Set the initial size of the JScrollPane
        myJScrollPane.setPreferredSize(new Dimension(600, 600));
        
        myJPanelForResults.setBackground(Color.WHITE);
        
        //$ You do all your work with the <b>content pane</b> of the JFrame
        //$ For example, you can change the layout of the JFrame
        getContentPane().setLayout(new BorderLayout());
        
        //$ You add components to the content pane, not to the JFrame
        getContentPane().add(controlPanel, BorderLayout.NORTH);
        
        controlPanel.setLayout(new GridLayout(3, 3));
        for (int i = 0; i < numberOfSubPanels; i++) {
            panels[i] = new JPanel();
            panels[i].setBorder(new LineBorder(Color.LIGHT_GRAY));
            controlPanel.add(panels[i]);
        }
        
        //$ Set up the JMenuBar with the JMenu and JMenuItem
        // Very similar code (not shown) is used for the other JMenus
        myJMenuBar.add(myJMenu);
        myJMenuBar.add(dialogsMenu); // don't show
        myJMenuBar.add(helpMenu); // don't show
        myJMenu.add(myJMenuItem);
        
        dialogsMenu.add(messageDialogItem);
        dialogsMenu.add(confirmDialogItem);
        dialogsMenu.add(inputDialogItem);
        dialogsMenu.add(optionDialogItem);
        dialogsMenu.add(colorChooserDialogItem);
        dialogsMenu.add(new JSeparator());
        dialogsMenu.add(loadFileDialogItem);
        dialogsMenu.add(saveFileDialogItem);
        
        helpMenu.add(helpMenuItem);
        helpMenu.add(sampleApplicationItem);
        helpMenu.add(sampleAppletItem);
        
        //$ Add the JMenuBar (with the JMenu and JMenuItem) to the window
        this.setJMenuBar(myJMenuBar);
        
        int panelNumber = 0;
        JPanel someJPanel;
        
        someJPanel = panels[panelNumber++];
        //$ Add the JButton to a panel, so it can be displayed
        someJPanel.add(myJButton);
        
        //$ Add the JRadioButtons to a ButtonGroup
        // The purpose of a ButtonGroup is to allow only one JButton to be selected at a time
        myButtonGroup.add(myJRadioButton1);
        myButtonGroup.add(myJRadioButton2);

        someJPanel = panels[panelNumber++];
        //$ Add the JTextField to a panel, so it can be displayed
        someJPanel.add(myJTextField);
        
        //$ You can add a JToolTip to a JTextField (or any other JComponent)
        myJTextField.setToolTipText("Click here and hit enter to see code");
        
        someJPanel = panels[panelNumber++];
        //$ Add the JTextArea to a panel, so it can be displayed
        someJPanel.add(myJTextArea);
        
        // Not shown
        myJTextArea.setToolTipText("Click here and hit enter to see code");
        
        someJPanel = panels[panelNumber++];
        //$ Add the JCheckBox to a panel, so it can be displayed
        someJPanel.add(myJCheckBox);
        
        someJPanel = panels[panelNumber++];
        //$ Add the JRadioButtons to a panel, so they can be displayed
        someJPanel.setLayout(new GridLayout(2, 1));
        someJPanel.add(myJRadioButton1);
        someJPanel.add(myJRadioButton2);
        
        labelPanel = panels[panelNumber++];
        //$ Add the JLabel to a panel, so it can be displayed
        labelPanel.add(myJLabel);
        
        someJPanel = panels[panelNumber++];
        //$ Add the JComboBox to a panel, so it can be displayed
        someJPanel.add(myJComboBox);        

        someJPanel = panels[panelNumber++];
        //$ Add the JSlider to a panel, so it can be displayed
        someJPanel.add(myJSlider);
        
        //$ Set some characteristics of the JSlider
        myJSlider.setMajorTickSpacing(10);
        myJSlider.setMinorTickSpacing(2);
        myJSlider.setPaintTicks(true);
        myJSlider.setPaintLabels(true);
        
        for (int i = panelNumber; i < numberOfSubPanels; i++) {
            panels[i].add(new JLabel("unused"));
        }
        
        //------------------------------------------------------
        
        //$ Set myJEditorPane to display HTML
        EditorKit kit = JEditorPane.createEditorKitForContentType("text/html");
        myJEditorPane.setEditorKit(kit);
        
        //$ Add the JScrollPane to a panel, so its contents (a JEditorPane) can be displayed
        myJPanelForResults.add(myJEditorPane);
        getContentPane().add(myJScrollPane, BorderLayout.CENTER);

        //$ Cause the JFrame to be sized and laid out, then make it visible
        pack();
        setVisible(true);
    }

    private void installTheListeners() {
        //$ Add a listener to the JMenuItem
        myJMenuItem.addActionListener(new JMenuItemListener());
        
        // Add listeners for the Dialogs menu items
        messageDialogItem.addActionListener(new MessageDialogMenuListener());
        confirmDialogItem.addActionListener(new ConfirmDialogMenuListener());
        inputDialogItem.addActionListener(new InputDialogMenuListener());
        optionDialogItem.addActionListener(new OptionDialogMenuListener());
        colorChooserDialogItem.addActionListener(new ColorChooserDialogMenuListener());
        loadFileDialogItem.addActionListener(new LoadFileDialogMenuListener());
        saveFileDialogItem.addActionListener(new SaveFileDialogMenuListener());
        
        // Add a listener for the help menu items
        helpMenuItem.addActionListener(new HelpMenuListener());
        sampleApplicationItem.addActionListener(new SampleApplicationListener());
        sampleAppletItem.addActionListener(new SampleAppletListener());
        
        //$ Add a listener to the JButton
        myJButton.addActionListener(new MyJButtonListener()); 
        
        //$ Add a listener to the JCheckBox
        // (It's usually better to test <code>myJCheckBox.isSelected()</code> when needed)
        myJCheckBox.addItemListener(new MyJCheckBoxListener());
        
        //$ Add listeners for each of the JRadioButtons
        myJRadioButton1.addItemListener(new MyJRadioButtonListener());
        myJRadioButton2.addItemListener(new MyJRadioButtonListener());
        
        //$ Add a listener to the JMenuItem
        myJMenuItem.addActionListener(new JMenuItemListener());
        
        //$ Add a listener to the JTextField
        // Note: It's usually better to use <code>getText()</code> when the text is needed
        myJTextField.addActionListener(new MyJTextFieldListener()); 
        
        //$ Add a listener to the <b>Document</b> associated with the JTextArea
        // Note: It's usually better to use <code>getText()</code> when the text is needed
        myJTextArea.getDocument().addDocumentListener(new MyJTextAreaListener());
        
        //$ You <b><i>cannot</i></b> attach a listener to a JLabel
        // The workaround I have used in this program is to attach a
        // <i>mouse</i> listener to the Panel that contains the JLabel.
        // Like so:
        labelPanel.addMouseListener(new MouseAdapter() {
            public void mouseClicked(MouseEvent e) {
                tellAbout("JLabel");
            }
        });
        
        //$ Add a listener to the JComboBox
        myJComboBox.addActionListener(new MyJComboBoxListener());

        //$ Add a listener to the JSlider
        myJSlider.addChangeListener(new MyJSliderListener());

   }
    
    private void randomOtherStatements1() {
        //$ You can set the contents of a JTextField
        myJTextField.setText("New text for the JTextField");
        
        {
        //$ You can get the contents of a JTextField
        String myText = myJTextField.getText();
        
        }
        
        //$ You can set the value of a JSlider
        myJSlider.setValue(45);
        
        {
        //$ You can get the value of a JSlider
        int temp = myJSlider.getValue();
        
        }
        {
        //$ You can set and get the text of a JEditorPane 
        myJEditorPane.setText("This is &lt;i&gt;sample&lt;/i&gt; text");
        String myText = myJEditorPane.getText();
        
        }
        
        //$ You can find out if a JCheckBox is checked
        boolean checked = myJCheckBox.isSelected();
        
        //$ You can find out which JRadioButton is selected
        boolean selected1 = myJRadioButton1.isSelected();
        boolean selected2 = myJRadioButton2.isSelected();
        
    }
    
    private void randomOtherStatements2() {
        //$ You can set the contents of a JTextArea
        myJTextArea.setText("This is new text for the JTextArea,\n" +
                            " and it may contain newlines.");
        
        //$ You can add to the contents of a JTextArea
        myJTextArea.append("Ehh...that's all, folks!");
        
        //$ You can get the contents of a JTextArea
        String myText = myJTextArea.getText();
        
    }
    
    //$ Provide the listener (as an inner class) for the JButton    
    public class MyJButtonListener implements ActionListener {
        public void actionPerformed(ActionEvent arg0) {
            tellAbout("JButton");
        }
    }
    
    //$ Provide the listener (as an inner class) for the JCheckBox    
    public class MyJCheckBoxListener implements ItemListener {
        public void itemStateChanged(ItemEvent arg0) {
            tellAbout("JCheckBox");
        }
    }
    
    //$ Provide the listener (as an inner class) for the JRadioButtons
    // This listener listens to more than one JRadioButton
    public class MyJRadioButtonListener implements ItemListener {
        public void itemStateChanged(ItemEvent arg0) {
            if (arg0.getSource() == myJRadioButton1) {
                tellAbout("JRadioButton");
            } else {
                tellAbout("ButtonGroup");
            }
        }
    }
    
    //$ Provide the listener (as an inner class) for the JTextField
    public class MyJTextFieldListener implements ActionListener {
        public void actionPerformed(ActionEvent arg0) {
            tellAbout("JTextField");
        }
    }
    
    //$ Provide the listener (as an inner class) for the JTextArea's <b>Document</b>
    // Note: You can't attach a listener to the JTextArea itself
    public class MyJTextAreaListener implements DocumentListener {
        public void insertUpdate(DocumentEvent arg0) {
            tellAbout("JTextArea");
        }
        public void removeUpdate(DocumentEvent arg0) {
            tellAbout("JTextArea");
        }
        public void changedUpdate(DocumentEvent arg0) {
            tellAbout("JTextArea");
        }
    }
    
    //$ Provide the listener (as an inner class) for the JComboBox    
    public class MyJComboBoxListener implements ActionListener {
        public void actionPerformed(ActionEvent e) {
            String selection = (String) myJComboBox.getSelectedItem();
            tellAbout(selection);
        }
    }
    
    //$ Provide the listener (as an inner class) for the JSlider    
    public class MyJSliderListener implements ChangeListener {
        public void stateChanged(ChangeEvent e) {
            tellAbout("JSlider");
        }
    }
    
    //$ Provide the listener (as an inner class) for the JMenuItem    
    public class JMenuItemListener implements ActionListener {
        public void actionPerformed(ActionEvent arg0) {
            tellAbout("JMenuItem");           
        }
    }

    // Provide the listener for the message dialog menu item
    public class MessageDialogMenuListener implements ActionListener {
        public void actionPerformed(ActionEvent arg0) {
            tellAbout("message dialog");
            
    //$ Display a JOptionPane message dialog
    JOptionPane.showMessageDialog(enclosingJFrame,
            "This is a JOptionPane \"message\" dialog.");
            
        }
    }
    
    // Provide the listener for the confirm dialog menu item
    public class ConfirmDialogMenuListener implements ActionListener {
        public void actionPerformed(ActionEvent arg0) {
            tellAbout("confirm dialog");
            
    //$ Display a JOptionPane confirm dialog
    int yesNo = JOptionPane.showConfirmDialog(enclosingJFrame,
            "Is this what you wanted to see?");
    if (yesNo == JOptionPane.YES_OPTION) {
        //      Your code goes here...
    }
            
        }
    }
    
    // Provide the listener for the input dialog menu item
    public class InputDialogMenuListener implements ActionListener {
        public void actionPerformed(ActionEvent arg0) {
            tellAbout("input dialog");
            
    //$ Display a JOptionPane input dialog
    String userName =
        JOptionPane.showInputDialog(enclosingJFrame,
                                    "What is your name?");
            
        }
    }
    
    // Provide the listener for the option dialog menu item
    public class OptionDialogMenuListener implements ActionListener {
        public void actionPerformed(ActionEvent arg0) {
            tellAbout("option dialog");
            
    //$ Display a JOptionPane option dialog
    Object[] options = new String[] {"English", "Chinese", "French", "German" };
    int option = JOptionPane.showOptionDialog(enclosingJFrame,
            "Choose an option:",
            "Option Dialog",
            JOptionPane.YES_NO_OPTION,    // Or JOptionPane.YES_NO_CANCEL_OPTION
            JOptionPane.QUESTION_MESSAGE, // Choose an icon, or...
            null,                         // ...you can use a custom Icon here
            options,
            options[0]);
            
        }
    }
    
    // Provide the listener for the color chooser dialog menu item
    public class ColorChooserDialogMenuListener implements ActionListener {
        public void actionPerformed(ActionEvent arg0) {
            tellAbout("JColorChooser");
            
    //$ Display a JColorChooser dialog
    Color chosenColor =
        colorChooser.showDialog(enclosingJFrame,
                                "Choose a color:",
                                Color.WHITE);
    
        }
    }
            
    
    // Provide the listener for a JChooser load file dialog menu item
    public class LoadFileDialogMenuListener implements ActionListener {
        public void actionPerformed(ActionEvent arg0) {
            tellAbout("JChooser load file");
            
            BufferedReader myBufferedFileReader;
            
            //$ Display a JChooser load file dialog
            JFileChooser chooser = new JFileChooser();
            chooser.setDialogTitle("Load which file?");
            
            //$ Get the file chosen in a JChooser load file dialog
            int result = chooser.showOpenDialog(enclosingJFrame);
            if (result == JFileChooser.APPROVE_OPTION) {
                File file = chooser.getSelectedFile();
                // ...and prepare to use the file
                try {
                    if (file != null) {
                        String fileName = file.getCanonicalPath();
                        myBufferedFileReader =
                            new BufferedReader(new FileReader(fileName));
                    }
                }
                catch (IOException e) { }
            }
            
        }
    }
    
    // Provide the listener for a JChooser save file dialog menu item
    public class SaveFileDialogMenuListener implements ActionListener {
        public void actionPerformed(ActionEvent arg0) {
            tellAbout("JChooser save file");
            
            PrintWriter myPrintWriter;
            
            //$ Display a JChooser save file dialog
            JFileChooser chooser = new JFileChooser();
            chooser.setDialogTitle("Save file as? (Nothing is really saved)");
            
            //$ Get the file chosen in a JChooser save file dialog
            int result = chooser.showSaveDialog(enclosingJFrame);
            if (result == JFileChooser.APPROVE_OPTION) {
                File file = chooser.getSelectedFile();
                // ...and prepare to use the file
                String fileName;
                try {
                    if (file != null) {
                        fileName = file.getCanonicalPath();
                        myPrintWriter =
                            new PrintWriter(new FileOutputStream(fileName), true);
                    }
                }
                catch (IOException e) { }       
            }
            
        }
    }
    
    // Provide the listener for the help menu item
    public class HelpMenuListener implements ActionListener {
        public void actionPerformed(ActionEvent arg0) {
            tellAbout("this program");
        }
    }

    // Provide the listener for the Sample Swing Application menu item
    public class SampleApplicationListener implements ActionListener {
        public void actionPerformed(ActionEvent arg0) {
            tellAbout("Swing application");
        }
    }

    // Provide the listener for the Sample Swing Applet menu item
    public class SampleAppletListener implements ActionListener {
        public void actionPerformed(ActionEvent arg0) {
            tellAbout("Swing applet");
        }
    }

    /**
     * Searches the source code for this program for information about the thing
     * passed in as a parameter, and displays it in the JEditorPane in the lower
     * half of the GUI.
     * <p>
     * Lines that begin with the "//$ " flag and contain the string given as a
     * parameter are displayed as headers. Subsequent lines, up to a blank line,
     * are added to the display, unless they end with "// don't show". Code
     * lines are added in a monospced font, while comment lines beginning with
     * "//" are displayed in a different font.
     * 
     * @param widget
     *        The string to be searched for.
     */
    private void tellAbout(String widget) {
        String flag = "//$ ";
        int flagLength = flag.length();
        StringBuffer buffer = new StringBuffer();
        boolean copying = false;
        int spacesToRemove = 0;
        String manySpaces = "                            ";
        String normalizedLine;
        
        myJEditorPane.setText("");
        for (Iterator iter = sourceCode.iterator(); iter.hasNext();) {
            String line = (String) iter.next();
            if (copying) {
                String trimmedLine = line.trim();
                
                normalizedLine = line;
                if (line.length() > spacesToRemove) {
                    normalizedLine = "    " + line.substring(spacesToRemove);
                }
                
                if (trimmedLine.length() > 0) {
                    if (trimmedLine.endsWith("// don't show")) {
                        continue;
                    } else if (trimmedLine.startsWith("//")) {
                        assert line.trim().length() >= 2;
                        if (!trimmedLine.startsWith(flag)) {
                            buffer.append("<font color='#6600FF'" +
                                          " face='Ariel,Verdana,sans-serif'" +
                                          " size='-1'>"
                                          + "    " + line.trim().substring(2)
                                          + "</font><br>");
                        }
                    } else {
                        buffer.append(normalizedLine + "\n");
                    }
                } else {
                    // blank line--stop copying source code
                    buffer.append("</pre><br>");
                    copying = false;
                    continue;
                }
            }
//            if (!copying && line.indexOf("//") < 0 && line.indexOf(widget) >= 0) {
//                buffer.append("<font color='#FF0000'>" + line + "</font><br>");
//            }
            if (line.trim().startsWith(flag)
                    && line.indexOf(widget) >= 0) {
                copying = true;
                assert line.trim().length() > flagLength;
                spacesToRemove = line.indexOf(flag);
                buffer.append("<font color='#0000FF' face='Ariel,Verdana,sans-serif'>"
                              + line.trim().substring(flagLength)
                              + "</font><pre>");
            }
        }
        myJEditorPane.setText(buffer.toString());
        
        //$ Your program can cause the JScrollPane to scroll to a particular position
        // (Note that the following is a message to the component <i>contained in</i> the JScrollPane)
        myJEditorPane.setCaretPosition(0);
        
    }
    
/*
STUFF NOT ACTUALLY PART OF THIS PROGRAM

    //$ Window closing can be handled by a listener that you write
    addWindowListener(new Closer());
    //
    private class Closer extends WindowAdapter {
        public void windowClosing(WindowEvent we) {
            update();
        }
    }
    //
    // If you just want to quit the program when the window is closed,
    // see the description of JFrame for a simpler method. 

//$ Here is a complete (but very small) Swing application
import javax.swing.*;
import javax.swing.event.*;
import java.awt.*;
import java.awt.event.*;
import java.util.Random;
//
public class DiceRoller extends JFrame {
    static Random rand = new Random();
    javax.swing.JButton rollButton;
    JTextField result;
//   
    public static void main(String[] args) {
        new DiceRoller().run();
    }
//    
    void run() {
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
//        
        rollButton = new JButton("Roll 'em!");
        getContentPane().add(rollButton, BorderLayout.NORTH);
        result = new JTextField("You haven't rolled yet.");
        getContentPane().add(result, BorderLayout.SOUTH);
        pack();
        setVisible(true);
//
        rollButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                int number = rand.nextInt(6) + 1;
                result.setText("You rolled a " + number);
        }});
    }
}

//$ Here is a complete (but very small) Swing applet
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.Random;
//
public class DiceRoller extends JApplet {
    static Random rand = new Random();
    javax.swing.JButton rollButton;
    JTextField result;
//
    public void init() {
        getContentPane().setLayout(new GridLayout(2, 1));
        rollButton = new JButton("Roll 'em!");
        getContentPane().add(rollButton);
        result = new JTextField("You haven't rolled yet.");
        getContentPane().add(result);
//
        rollButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                int number = rand.nextInt(6) + 1;
                result.setText("You rolled a " + number);
        }});
    }
}
// Here is an HTML file that will display the applet
&lt;html&gt;
  &lt;head&gt;
    &lt;title&gt;DiceRoller Applet&lt;/title&gt;
  &lt;/head&gt;
  &lt;body&gt;
    &lt;h1&gt;DiceRoller Applet&lt;/h1&gt;
    &lt;hr&gt;
    &lt;applet code="DiceRoller.class" width=150 height=75&gt;&lt;/applet&gt;
    &lt;hr&gt;
  &lt;/body&gt;
&lt;/html&gt;

 */
}
