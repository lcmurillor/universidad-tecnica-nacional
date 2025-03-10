package Interfaz;

import static Interfaz.JDJuego.cdtNum;
import java.awt.event.KeyEvent;
import javax.swing.JOptionPane;

public class JDNumero extends javax.swing.JDialog {

    private boolean esValido(String numero) {
        boolean ban = true;
        if (numero.trim().equals("")) {
            ban = false;
        }
        char[] valor = numero.toCharArray();
        for (int i = 0; i < valor.length; i++) {
            if (!Character.isDigit(valor[i])) {
                ban = false;
                break;
            }
        }
        if (ban && valor.length <= 4) {
            ban = true;
        } else if (valor.length > 4) {
            JOptionPane.showMessageDialog(this, "El dato correspondiente a esta casilla \nEs muy grande");
            ban = false;
        } else if (!ban) {
            JOptionPane.showMessageDialog(this, "El dato correspondiente a esta casilla \nsolo puede ser numerico");
        }
        return ban;
    }

    private void leerMatriz() {
        for (int n = 0; n < FRMBingo.cantVentanas; n++) {
            for (int f = 0; f < 5; f++) {
                for (int c = 0; c < 5; c++) {
                    if (FRMBingo.misCartones[n].getMatrizEntera()[f][c] == Integer.parseInt(cdtNumero.getText())) {
                        FRMBingo.misCartones[n].cargarMatrizBFalse(f, c);

                    }
                }
            }
        }
    }

    public JDNumero(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        this.setLocationRelativeTo(null);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        cdtNumero = new javax.swing.JTextField();
        lblFondo = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("ELIMINAR");
        setMaximumSize(new java.awt.Dimension(200, 179));
        setMinimumSize(new java.awt.Dimension(200, 179));
        setPreferredSize(new java.awt.Dimension(200, 179));
        setResizable(false);
        setSize(new java.awt.Dimension(200, 179));
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jLabel1.setFont(new java.awt.Font("Century Gothic", 0, 18)); // NOI18N
        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setText("Ingrese el número");
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 11, 180, -1));

        cdtNumero.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        cdtNumero.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        cdtNumero.setToolTipText("Precione ENTER");
        cdtNumero.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cdtNumeroActionPerformed(evt);
            }
        });
        cdtNumero.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                cdtNumeroKeyPressed(evt);
            }
        });
        getContentPane().add(cdtNumero, new org.netbeans.lib.awtextra.AbsoluteConstraints(41, 52, 118, 36));

        lblFondo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagenes/Fondo desmarcar Numero.png"))); // NOI18N
        getContentPane().add(lblFondo, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 200, 150));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void cdtNumeroActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cdtNumeroActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_cdtNumeroActionPerformed

    private void cdtNumeroKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_cdtNumeroKeyPressed
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            if (this.esValido(cdtNumero.getText())) {
                this.leerMatriz();
                cdtNumero.setText("");
            }

        }
    }//GEN-LAST:event_cdtNumeroKeyPressed

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
            java.util.logging.Logger.getLogger(JDNumero.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(JDNumero.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(JDNumero.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(JDNumero.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                JDNumero dialog = new JDNumero(new javax.swing.JFrame(), true);
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
    private javax.swing.JTextField cdtNumero;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel lblFondo;
    // End of variables declaration//GEN-END:variables
}
