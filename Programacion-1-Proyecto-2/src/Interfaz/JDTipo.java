
package Interfaz;

public class JDTipo extends javax.swing.JDialog {

    public static boolean on = false;
    
    public JDTipo(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        this.setLocationRelativeTo(null);
        on = true;
        
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        btnHorizontal = new javax.swing.JToggleButton();
        btnVertical = new javax.swing.JToggleButton();
        btnDiagonal = new javax.swing.JToggleButton();
        btnCatroEsquinas = new javax.swing.JToggleButton();
        btnCartonLleno = new javax.swing.JToggleButton();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        lblFondo = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("MODO DE JUEGO");
        setMaximumSize(new java.awt.Dimension(244, 153));
        setMinimumSize(new java.awt.Dimension(244, 153));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        btnHorizontal.setText("Horizontal");
        btnHorizontal.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnHorizontalActionPerformed(evt);
            }
        });
        getContentPane().add(btnHorizontal, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 38, 105, -1));

        btnVertical.setText("Vertical");
        btnVertical.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                btnVerticalKeyPressed(evt);
            }
        });
        getContentPane().add(btnVertical, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 79, 105, -1));

        btnDiagonal.setText("Diagonal");
        getContentPane().add(btnDiagonal, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 123, 105, -1));

        btnCatroEsquinas.setSelected(true);
        btnCatroEsquinas.setText("Catro Esquinas");
        getContentPane().add(btnCatroEsquinas, new org.netbeans.lib.awtextra.AbsoluteConstraints(129, 38, -1, -1));

        btnCartonLleno.setText("Carton Lleno");
        getContentPane().add(btnCartonLleno, new org.netbeans.lib.awtextra.AbsoluteConstraints(129, 94, 105, -1));

        jLabel1.setFont(new java.awt.Font("Century Gothic", 1, 14)); // NOI18N
        jLabel1.setText("Bingo Corriente");
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 11, -1, -1));

        jLabel2.setFont(new java.awt.Font("Century Gothic", 1, 14)); // NOI18N
        jLabel2.setText("Cuatro Esquinas");
        getContentPane().add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(133, 11, -1, -1));

        jLabel3.setFont(new java.awt.Font("Century Gothic", 1, 14)); // NOI18N
        jLabel3.setText("Carton Lleno");
        getContentPane().add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(133, 72, -1, -1));

        lblFondo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagenes/Fondo de Tipo de Juego.png"))); // NOI18N
        getContentPane().add(lblFondo, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 250, 160));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnHorizontalActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnHorizontalActionPerformed

    }//GEN-LAST:event_btnHorizontalActionPerformed

    private void btnVerticalKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_btnVerticalKeyPressed
        // TODO add your handling code here:
    }//GEN-LAST:event_btnVerticalKeyPressed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(JDTipo.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(JDTipo.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(JDTipo.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(JDTipo.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                JDTipo dialog = new JDTipo(new javax.swing.JFrame(), true);
                dialog.addWindowListener(new java.awt.event.WindowAdapter() {
                    @Override
                    public void windowClosing(java.awt.event.WindowEvent e) {
                        System.exit(0);
                    }
                });
                dialog.setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    public static javax.swing.JToggleButton btnCartonLleno;
    public static javax.swing.JToggleButton btnCatroEsquinas;
    public static javax.swing.JToggleButton btnDiagonal;
    public static javax.swing.JToggleButton btnHorizontal;
    public static javax.swing.JToggleButton btnVertical;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel lblFondo;
    // End of variables declaration//GEN-END:variables
}
