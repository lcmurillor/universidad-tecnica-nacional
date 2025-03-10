package Interfaz;

import java.awt.event.KeyEvent;
import javax.swing.JOptionPane;
import Utilidades.tipoDeJuego;

public class JDJuego extends javax.swing.JDialog {

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
        boolean ban = true;
        for (int n = 0; n < FRMBingo.cantVentanas; n++) {
            for (int f = 0; f < 5; f++) {
                for (int c = 0; c < 5; c++) {
                    if (FRMBingo.misCartones[n].getMatrizEntera()[f][c] == Integer.parseInt(cdtNum.getText())) {
                      //  JOptionPane.showMessageDialog(rootPane, "Esta en el Carton " + FRMBingo.misCartones[n].getCodigo());
                        FRMBingo.misCartones[n].cargarMatrizBTrue(f, c);
                        ban = false;

                    }
                }
            }
        }
        if (JDTipo.on) {
            this.leerMatrizB();
        }

        if (ban) {
          //  JOptionPane.showMessageDialog(rootPane, "No esta");
        }
    }

    public void leerMatrizB() {
        if (JDTipo.btnCartonLleno.isSelected()) {
            for (int n = 0; n < FRMBingo.cantVentanas; n++) {
                if (tipoDeJuego.cartonLleno(FRMBingo.misCartones[n].matrizBooleana)) {
                    JOptionPane.showMessageDialog(null, "¡BINGO! en el cartón: " + FRMBingo.misCartones[n].getCodigo(), "¡BINGO!", JOptionPane.WARNING_MESSAGE);
                }
            }
        }
        if (JDTipo.btnCatroEsquinas.isSelected()) {
            for (int n = 0; n < FRMBingo.cantVentanas; n++) {
                if (tipoDeJuego.cartonEsquinas(FRMBingo.misCartones[n].matrizBooleana)) {
                    JOptionPane.showMessageDialog(null, "¡BINGO! en el cartón: " + FRMBingo.misCartones[n].getCodigo(), "¡BINGO!", JOptionPane.WARNING_MESSAGE);
                }
            }
        }
        if (JDTipo.btnDiagonal.isSelected()) {
            for (int n = 0; n < FRMBingo.cantVentanas; n++) {
                if (tipoDeJuego.cartonDiagonal(FRMBingo.misCartones[n].matrizBooleana)) {
                    JOptionPane.showMessageDialog(null, "¡BINGO! en el cartón: " + FRMBingo.misCartones[n].getCodigo(), "¡BINGO!", JOptionPane.WARNING_MESSAGE);
                }
            }
        }
        if (JDTipo.btnHorizontal.isSelected()) {
            for (int n = 0; n < FRMBingo.cantVentanas; n++) {
                if (tipoDeJuego.cartonHorizontal(FRMBingo.misCartones[n].matrizBooleana)) {
                    JOptionPane.showMessageDialog(null, "¡BINGO! en el cartón: " + FRMBingo.misCartones[n].getCodigo(), "¡BINGO!", JOptionPane.WARNING_MESSAGE);
                }
            }
        }
        if (JDTipo.btnVertical.isSelected()) {
            for (int n = 0; n < FRMBingo.cantVentanas; n++) {
                if (tipoDeJuego.cartonVertical(FRMBingo.misCartones[n].matrizBooleana)) {
                    JOptionPane.showMessageDialog(null, "¡BINGO! en el cartón: " + FRMBingo.misCartones[n].getCodigo(), "¡BINGO!", JOptionPane.WARNING_MESSAGE);
                }
            }
        }
    }

    public JDJuego(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        this.setLocationRelativeTo(null);

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        cdtNum = new javax.swing.JTextField();
        lblFondo = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("JUEGO");
        setMaximumSize(new java.awt.Dimension(200, 179));
        setMinimumSize(new java.awt.Dimension(200, 179));
        setPreferredSize(new java.awt.Dimension(200, 179));
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jLabel1.setFont(new java.awt.Font("Century Gothic", 1, 18)); // NOI18N
        jLabel1.setText("Ingrese los Números");
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 11, 184, -1));

        cdtNum.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        cdtNum.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        cdtNum.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cdtNumActionPerformed(evt);
            }
        });
        cdtNum.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                cdtNumKeyPressed(evt);
            }
        });
        getContentPane().add(cdtNum, new org.netbeans.lib.awtextra.AbsoluteConstraints(46, 62, 112, 37));

        lblFondo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagenes/Fondo de Juego.png"))); // NOI18N
        getContentPane().add(lblFondo, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, -1, 150));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void cdtNumActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cdtNumActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_cdtNumActionPerformed

    private void cdtNumKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_cdtNumKeyPressed
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            if (this.esValido(cdtNum.getText())) {
                this.leerMatriz();
                cdtNum.setText("");
            }

        }
    }//GEN-LAST:event_cdtNumKeyPressed

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
            java.util.logging.Logger.getLogger(JDJuego.class
                    .getName()).log(java.util.logging.Level.SEVERE, null, ex);

        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(JDJuego.class
                    .getName()).log(java.util.logging.Level.SEVERE, null, ex);

        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(JDJuego.class
                    .getName()).log(java.util.logging.Level.SEVERE, null, ex);

        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(JDJuego.class
                    .getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                JDJuego dialog = new JDJuego(new javax.swing.JFrame(), true);
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
    public static javax.swing.JTextField cdtNum;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel lblFondo;
    // End of variables declaration//GEN-END:variables
}
