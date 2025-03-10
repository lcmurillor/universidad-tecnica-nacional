package interfaz;

import com.sun.glass.events.KeyEvent;
import static conversion.encriptar.*;
import javax.swing.JOptionPane;

/**
 *
 * @author Yordan Meneses, Juan Varela y Luis Murillo.
 */
public class frmEncriptar extends javax.swing.JDialog {

    public frmEncriptar(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        this.setLocationRelativeTo(null);
        passw.setVisible(false);
        leb1.setText("Mensaje");
        leb2.setText("Mensaje encriptado");
    }
    String x;
    String y;

    /**
     * Resive un String del método generarPassw() correspondiente a 4 números
     * aleatorios guardando ésta contraseña en una variable global como un
     * requerimiento para el desencriptado. La contraseña se guarda en un
     * arreglo (no puede conservar más de 3 contraseñas).
     */
    private void contraseña() {
        x = generarPassw();
        y = encriptar(x);
    }

    /**
     * Genera la encriptación y muestra un mensaje con la contraseña para
     * desencriptar.
     */
    private void encrypt() {
        this.contraseña();
        if (btnE.isSelected()) {
            cdt2.setText(y + encriptar(cdt1.getText()));
            JOptionPane.showMessageDialog(rootPane, "La contraseña es: \n"
                    + "" + x);
        }
    }

    /**
     * Evalúa si la contraseña ingresada corresponde a la contraseña asignada
     * por contraseña() si se cumple desencriptará y sino genera un mensaje de
     * error y no muestra el menaje desencriptado.
     */
    private void decrypt() {
        boolean band = false;
        String aux = desEncriptar(cdt1.getText()).substring(0, 4);
        if (aux.equals(String.valueOf(passw.getPassword()))) {
            band=true;
        }
        if (band) {
             cdt2.setText(desEncriptar(cdt1.getText()).substring(4));
        } else {
            JOptionPane.showMessageDialog(rootPane, "Contraseña incorrecta");
        }
        passw.setText("");
       
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        gdb = new javax.swing.ButtonGroup();
        jPanel1 = new javax.swing.JPanel();
        btnE = new javax.swing.JToggleButton();
        btnD = new javax.swing.JToggleButton();
        cdt1 = new javax.swing.JTextField();
        cdt2 = new javax.swing.JTextField();
        btn = new javax.swing.JButton();
        leb1 = new javax.swing.JLabel();
        leb2 = new javax.swing.JLabel();
        passw = new javax.swing.JPasswordField();
        jLabel1 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Encriptación");
        setAlwaysOnTop(true);

        gdb.add(btnE);
        btnE.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btnE.setSelected(true);
        btnE.setText("Encriptar");
        btnE.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEActionPerformed(evt);
            }
        });

        gdb.add(btnD);
        btnD.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btnD.setText("Desencriptar");
        btnD.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDActionPerformed(evt);
            }
        });

        cdt1.setFont(new java.awt.Font("Century Gothic", 3, 12)); // NOI18N
        cdt1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cdt1ActionPerformed(evt);
            }
        });
        cdt1.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                cdt1KeyPressed(evt);
            }
        });

        cdt2.setFont(new java.awt.Font("Century Gothic", 3, 12)); // NOI18N
        cdt2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cdt2ActionPerformed(evt);
            }
        });

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

        passw.setToolTipText("Ingrese la contraseña para desencriptar");
        passw.setEchoChar('•');
        passw.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                passwKeyPressed(evt);
            }
        });

        jLabel1.setFont(new java.awt.Font("Century Gothic", 0, 24)); // NOI18N
        jLabel1.setText("Encriptación");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addGap(6, 6, 6)
                        .addComponent(btn, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(passw, javax.swing.GroupLayout.PREFERRED_SIZE, 120, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(37, 37, 37))
                    .addComponent(leb1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(leb2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addComponent(cdt2, javax.swing.GroupLayout.PREFERRED_SIZE, 328, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addContainerGap())
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 328, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(cdt1, javax.swing.GroupLayout.PREFERRED_SIZE, 328, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addGap(17, 17, 17)
                        .addComponent(btnE, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(btnD, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(33, 33, 33))))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnE)
                    .addComponent(btnD))
                .addGap(18, 18, 18)
                .addComponent(leb1)
                .addGap(5, 5, 5)
                .addComponent(cdt1, javax.swing.GroupLayout.PREFERRED_SIZE, 101, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btn)
                    .addComponent(passw, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(leb2)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(cdt2, javax.swing.GroupLayout.PREFERRED_SIZE, 84, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(14, 14, 14))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnActionPerformed
        if (btnE.isSelected()) {
            this.encrypt();
        } else if (btnD.isSelected()) {
            this.decrypt();
        }
    }//GEN-LAST:event_btnActionPerformed

    private void cdt1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cdt1ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_cdt1ActionPerformed

    private void btnDActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnDActionPerformed
        passw.setVisible(true);
        cdt1.setText("");
        cdt2.setText("");
        leb2.setText("Mensaje");
        leb1.setText("Mensaje encriptado");
    }//GEN-LAST:event_btnDActionPerformed

    private void btnEActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEActionPerformed
        passw.setVisible(false);
        cdt1.setText("");
        cdt2.setText("");
        leb1.setText("Mensaje");
        leb2.setText("Mensaje encriptado");
    }//GEN-LAST:event_btnEActionPerformed

    private void cdt1KeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_cdt1KeyPressed
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            if (btnE.isSelected()) {
                this.encrypt();
            } else if (btnD.isSelected()) {
                this.decrypt();
            }
        }
    }//GEN-LAST:event_cdt1KeyPressed

    private void passwKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_passwKeyPressed
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            if (btnE.isSelected()) {
                this.encrypt();
            } else if (btnD.isSelected()) {
                this.decrypt();
            }
        }
    }//GEN-LAST:event_passwKeyPressed

    private void cdt2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cdt2ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_cdt2ActionPerformed

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
            java.util.logging.Logger.getLogger(frmEncriptar.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(frmEncriptar.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(frmEncriptar.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(frmEncriptar.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                frmEncriptar dialog = new frmEncriptar(new javax.swing.JFrame(), true);
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
    private javax.swing.JToggleButton btnD;
    private javax.swing.JToggleButton btnE;
    private javax.swing.JTextField cdt1;
    private javax.swing.JTextField cdt2;
    private javax.swing.ButtonGroup gdb;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JLabel leb1;
    private javax.swing.JLabel leb2;
    private javax.swing.JPasswordField passw;
    // End of variables declaration//GEN-END:variables
}
