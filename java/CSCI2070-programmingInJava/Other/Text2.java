import java.awt.*;
import java.awt.event.*;
import java.io.*;
import javax.imageio.*;
import javax.swing.*;
import java.awt.image.*;
 
 
public class ImFrame extends JFrame implements ActionListener {
    
    ImageJPanel imgPanel = new ImageJPanel();
    ImageJPanel leftPanel = new ImageJPanel();
    ImageJPanel rightPanel = new ImageJPanel();
    JScrollPane imageScrollPane = new JScrollPane();
    JScrollPane leftPane = new JScrollPane();
    JScrollPane rightPane = new JScrollPane();
    private JSplitPane split;
    
    public ImFrame(){
        super("Image Display Frame");
        
        setDefaultCloseOperation( JFrame.EXIT_ON_CLOSE);
 
        JMenu fileMenu = new JMenu("File");
        fileMenu.add(makeMenuItem("Open"));
        fileMenu.add(makeMenuItem("Save Analysis Data"));
        fileMenu.add(makeMenuItem("Quit"));
        
        JMenu analyzeMenu = new JMenu("Analyze");
        analyzeMenu.add(makeMenuItem("Smooth"));
        analyzeMenu.add(makeMenuItem("Display RGB and HSV"));
        analyzeMenu.add(makeMenuItem("Display Second Image for Comparison"));
        
        JMenuBar menuBar = new JMenuBar();
        menuBar.add(fileMenu);
        menuBar.add(analyzeMenu);
        setJMenuBar(menuBar);
        split = new JSplitPane(JSplitPane.HORIZONTAL_SPLIT, 
                                leftPanel, rightPanel);
        split.setDividerLocation(150);
        split.setSize(300, 300);
             
        
        split.setRightComponent(rightPane);
        split.setLeftComponent(leftPane);
        
        setContentPane(split);
        
        setSize(300, 300);
                
        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.CENTER)
            .addComponent(imageScrollPane, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, 400, Short.MAX_VALUE)
            
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(imageScrollPane, javax.swing.GroupLayout.DEFAULT_SIZE, 296, Short.MAX_VALUE)
        );
        imageScrollPane.setViewportView(imgPanel);
        pack();
        //setVisible(true);
        
    }
    
    public void actionPerformed(ActionEvent e){
        String command = e.getActionCommand();
        if(command.equals("Quit")) System.exit(0);
        else if (command.equals("Open")) loadFile();
    }
    
    private void loadFile(){
        
        JFileChooser chooser = new JFileChooser();
        int result = chooser.showOpenDialog(this);
        if (result == JFileChooser.CANCEL_OPTION) return;
        try{
            File file = chooser.getSelectedFile();
            System.out.println("Loading..." + file.getAbsolutePath());
            BufferedImage buffImage = ImageIO.read(file);
            if (buffImage != null) {
            leftPanel.setImage(buffImage);
            imageScrollPane.setViewportView(leftPanel);
            } else {
                System.out.println("Problem loading image file.");
            }
            
        } catch(Exception e){
            System.out.println("File error:" + e);
        }
    }
    
    
    private JMenuItem makeMenuItem(String name){
        JMenuItem m = new JMenuItem(name);
        m.addActionListener(this);
        return m;
    }
    
    
    
    
    public static void main(String[] s){
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ImFrame().setVisible(true);
            }
        });
    }
    
}
