
package interfaz;

import com.sun.glass.events.KeyEvent;
import static conversion.morse.*;
import javax.swing.JOptionPane;

/**
 *
 * @author Yordan Meneses, Juan Varela y Luis Murillo.
 */
public class frmMorse extends javax.swing.JDialog {

    public frmMorse(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        this.setLocationRelativeTo(null);
        leb1.setText("Alfanumérico");
        leb2.setText("Morse");
    }

    /**
     * Según la selección de botones, convirte un String Alfanumérico a Morse o
     * viceversa.
     */
    private void Morse() {
        try {
            if (btnA.isSelected()) {
                cdt2.setText(textoAMorse(cdt1.getText()));
                if (!condicion()) {
                     this.mensError();
                    cdt2.setText("");
                } 
            } else if (btnM.isSelected()) {
                if (condicion()) {
                    cdt2.setText(morseATexto(cdt1.getText()));
                } else {
                    this.mensError();
                    cdt2.setText("");
                }
            }
        } catch (Exception e) {
            this.mensError();
            cdt2.setText("");
        }
    }

    /**
     * Evalúa diversas condiciones para afirmar o denegar al usario la converción a código morse,
     * estas condiciones pueden ser: pasar de código morse a código morse, o un caracter
     * que no se puede convertir, o si al pasar de código morse a alfanumérico se están usando 
     * caracteres que no son los usados para morse.
     * @return booleam
     */
    private boolean condicion() {
        boolean band = true;
        if (btnA.isSelected()) {
            for (int i = 0; i < cdt2.getText().length(); i++) {
                if (cdt2.getText().charAt(i) != ' ' & cdt2.getText().charAt(i) != '.' & cdt2.getText().charAt(i) != '-') {
                    band = false;
                }
            }
            for (int i = 0; i < cdt1.getText().length(); i++) {
                if (cdt1.getText().charAt(i) == '.' || cdt1.getText().charAt(i) == '-') {
                    band = false;
                }
            }
        } else if (btnM.isSelected()) {
            for (int i = 0; i < cdt1.getText().length(); i++) {
                if (cdt1.getText().charAt(i) != ' ' & cdt1.getText().charAt(i) != '.' & cdt1.getText().charAt(i) != '-') {
                    band = false;
                }
            }
        }
        return band;
    }

    /**
     * Mensaje de Error general.
     */
    private void mensError() {
        JOptionPane.showMessageDialog(rootPane, "Error: \n No a Ingresado los datos correctamente", "Error", JOptionPane.WARNING_MESSAGE);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        gdb = new javax.swing.ButtonGroup();
        jPanel1 = new javax.swing.JPanel();
        btnA = new javax.swing.JToggleButton();
        btnM = new javax.swing.JToggleButton();
        cdt1 = new javax.swing.JTextField();
        cdt2 = new javax.swing.JTextField();
        btn = new javax.swing.JButton();
        leb1 = new javax.swing.JLabel();
        leb2 = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Morse");
        setAlwaysOnTop(true);

        gdb.add(btnA);
        btnA.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btnA.setSelected(true);
        btnA.setText("Alfanumérico");
        btnA.setToolTipText(""
            + "<html><body><pre>"
            + "Use solamente letas de la A a la Z \ny números del 0 al 9"
            + "</pre></body></html> ");
        btnA.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAActionPerformed(evt);
            }
        });

        gdb.add(btnM);
        btnM.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btnM.setText("Morse");
        btnM.setToolTipText(""
            + "<html><body><pre>"
            + "Use solamente punto . \ny guión medio - "
            + "</pre></body></html> ");
        btnM.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMActionPerformed(evt);
            }
        });

        cdt1.setFont(new java.awt.Font("Century Gothic", 3, 18)); // NOI18N
        cdt1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cdt1ActionPerformed(evt);
            }
        });
        cdt1.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                cdt1KeyPressed(evt);
            }
            public void keyReleased(java.awt.event.KeyEvent evt) {
                cdt1KeyReleased(evt);
            }
        });

        cdt2.setFont(new java.awt.Font("Century Gothic", 3, 18)); // NOI18N

        btn.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btn.setText("Convertir");
        btn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnActionPerformed(evt);
            }
        });

        leb1.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        leb1.setText("Texto 1");

        leb2.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        leb2.setText("Texto 2");

        jLabel1.setFont(new java.awt.Font("Century Gothic", 0, 24)); // NOI18N
        jLabel1.setText("Código Morse");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(leb1, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(leb2, javax.swing.GroupLayout.Alignment.CENTER, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addGroup(javax.swing.GroupLayout.Alignment.LEADING, jPanel1Layout.createSequentialGroup()
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addComponent(cdt2, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 340, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                        .addComponent(cdt1, javax.swing.GroupLayout.Alignment.CENTER, javax.swing.GroupLayout.PREFERRED_SIZE, 340, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGroup(javax.swing.GroupLayout.Alignment.LEADING, jPanel1Layout.createSequentialGroup()
                                            .addGap(107, 107, 107)
                                            .addComponent(btn, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE))))
                                .addGap(0, 0, Short.MAX_VALUE)))
                        .addGap(2, 2, 2))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 328, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(17, 17, 17)
                        .addComponent(btnA, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(btnM, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(30, 30, 30))))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addGap(18, 18, 18)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnA)
                    .addComponent(btnM))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(leb1)
                .addGap(7, 7, 7)
                .addComponent(cdt1, javax.swing.GroupLayout.PREFERRED_SIZE, 80, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(btn)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(leb2)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(cdt2, javax.swing.GroupLayout.PREFERRED_SIZE, 84, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(23, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void cdt1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cdt1ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_cdt1ActionPerformed

    private void btnActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnActionPerformed
        this.Morse();
    }//GEN-LAST:event_btnActionPerformed

    private void cdt1KeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_cdt1KeyPressed
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            this.Morse();
        }
        if (evt.getKeyCode() == KeyEvent.VK_SPACE) {
            cdt1.setText(cdt1.getText() + " ");
        }


    }//GEN-LAST:event_cdt1KeyPressed

    private void btnMActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMActionPerformed
        leb2.setText("Alfanumérico");
        leb1.setText("Morse");
    }//GEN-LAST:event_btnMActionPerformed

    private void btnAActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAActionPerformed
        leb1.setText("Alfanumérico");
        leb2.setText("Morse");
    }//GEN-LAST:event_btnAActionPerformed

    private void cdt1KeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_cdt1KeyReleased

    }//GEN-LAST:event_cdt1KeyReleased

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
            java.util.logging.Logger.getLogger(frmMorse.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(frmMorse.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(frmMorse.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(frmMorse.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                frmMorse dialog = new frmMorse(new javax.swing.JFrame(), true);
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
    private javax.swing.JButton btn;
    private javax.swing.JToggleButton btnA;
    private javax.swing.JToggleButton btnM;
    private javax.swing.JTextField cdt1;
    private javax.swing.JTextField cdt2;
    private javax.swing.ButtonGroup gdb;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JLabel leb1;
    private javax.swing.JLabel leb2;
    // End of variables declaration//GEN-END:variables
}
