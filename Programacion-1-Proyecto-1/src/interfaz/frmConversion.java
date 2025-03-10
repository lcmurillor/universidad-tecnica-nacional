
package interfaz;

import com.sun.glass.events.KeyEvent;
import static conversion.division.*;
import static conversion.multiplicacion.*;
import javax.swing.JOptionPane;

/**
 *
 * @author Yordan Meneses, Juan Varela y Luis Murillo.
 */
public class frmConversion extends javax.swing.JDialog {

    public frmConversion(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        this.setLocationRelativeTo(null);
        leb1.setText("Sistema Decimal");
        leb2.setText("Sistema Binario");
    }
    
    private void calcular() {
        try {
            this.calcularDecimal();
            this.calcularBinario();
            this.calcularOctal();
            this.calcularHexadecimal();
        } catch (Exception e) {
            this.mensError();
        }

    }
    /**
     * Mensaje de Error general para los Try catch y los errores de converción o ingreso de datos inválidos.
     */
    private void mensError() {
        JOptionPane.showMessageDialog(rootPane, "ERROR: \n"
                + "El tipo de dato ingresado no es válido \n"
                + "Posibles errores: Un número negativo,\n"
                + "letras o números inválidos,\n"
                + "números decimales o \n"
                + "conversión entre los mismos tipos de datos.", "Error", JOptionPane.WARNING_MESSAGE);
        cdt1.setText("");
    }
    /**
     * Convierte un dato Decimal a todos los demás sistemas númerios.
     */
    private void calcularDecimal() {
        if (btnDecimal1.isSelected()) {
            if (btnDecimal2.isSelected() || cdt1.getText().charAt(0) == '-') {
                this.mensError();
            } else if (btnBinario2.isSelected()) {
                    cdt2.setText(binario(Integer.parseInt(cdt1.getText())));
            } else if (btnOctal2.isSelected()) {
                    cdt2.setText(octal(Integer.parseInt(cdt1.getText())));
            } else if (btnHexadecimal2.isSelected()) {
                    cdt2.setText(hexadecimal(Integer.parseInt(cdt1.getText())));
            }
        }
    }
   /**
     * Convierte un dato Binario a todos los demás sistemas númerios.
     * Para algunas conversiones el dato Binario será Decimal y luego se pasará al sistema solicitado
     * por el usario.
     */
    private void calcularBinario() {
        if (btnBinario1.isSelected()) {
            boolean band = false;
            for (int i = 0; i < cdt1.getText().length(); i++) {
                if (cdt1.getText().charAt(i) != '1' && cdt1.getText().charAt(i) != '0') {
                    band = true;
                }
            }
            if (btnBinario2.isSelected() || band || cdt1.getText().charAt(0) == '-') {
                this.mensError();
            } else if (btnDecimal2.isSelected()) {
                    cdt2.setText(String.valueOf(binarioDecimal(cdt1.getText())));
            } else if (btnOctal2.isSelected()) {
                    cdt2.setText(octal((binarioDecimal(cdt1.getText()))));
            } else if (btnHexadecimal2.isSelected()) {
                    cdt2.setText(hexadecimal((binarioDecimal(cdt1.getText()))));
            }
        }
    }
   /**
     * Convierte un dato Octal a todos los demás sistemas númerios.
     * Para algunas conversiones el dato Octal será Decimal y luego se pasará al sistema solicitado
     * por el usario.
     */
    private void calcularOctal() {
        if (btnOctal1.isSelected()) {
            boolean band = false;
            for (int i = 0; i < cdt1.getText().length(); i++) {
                if (cdt1.getText().charAt(i) == '9' || cdt1.getText().charAt(i) == '8') {
                    band = true;
                }
            }
            if (btnOctal2.isSelected() || band || cdt1.getText().charAt(0) == '-') {
                this.mensError();
            } else if (btnDecimal2.isSelected()) {
                    cdt2.setText(String.valueOf(octalDecimal(cdt1.getText())));
            } else if (btnBinario2.isSelected()) {
                    cdt2.setText(binario(octalDecimal(cdt1.getText())));
            } else if (btnHexadecimal2.isSelected()) {
                    cdt2.setText(hexadecimal(octalDecimal(cdt1.getText())));
            }
        }
    }
 /**
     * Convierte un dato Hexadecimal a todos los demás sistemas númerios.
     * Para algunas conversiones el dato Hexaecimal será Decimal y luego se pasará al sistema solicitado
     * por el usario.
     */
    private void calcularHexadecimal() {
        if (btnHexadecimal1.isSelected()) {
            if (btnHexadecimal2.isSelected() || cdt1.getText().charAt(0) == '-') {
                this.mensError();
            } else if (btnDecimal2.isSelected()) {
                    cdt2.setText(String.valueOf(hexadecimalDecimal(cdt1.getText())));
            } else if (btnBinario2.isSelected()) {
                    cdt2.setText(binario(hexadecimalDecimal(cdt1.getText())));
            } else if (btnOctal2.isSelected()) {
                    cdt2.setText(octal(hexadecimalDecimal(cdt1.getText())));
            }
        }
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        gdbA = new javax.swing.ButtonGroup();
        gdbB = new javax.swing.ButtonGroup();
        jPanel1 = new javax.swing.JPanel();
        btnDecimal1 = new javax.swing.JToggleButton();
        btnBinario1 = new javax.swing.JToggleButton();
        btnOctal1 = new javax.swing.JToggleButton();
        btnHexadecimal1 = new javax.swing.JToggleButton();
        btnDecimal2 = new javax.swing.JToggleButton();
        btnBinario2 = new javax.swing.JToggleButton();
        btnOctal2 = new javax.swing.JToggleButton();
        btnHexadecimal2 = new javax.swing.JToggleButton();
        cdt1 = new javax.swing.JTextField();
        cdt2 = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        leb2 = new javax.swing.JLabel();
        leb1 = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Sistemas numéricos");
        setAlwaysOnTop(true);

        gdbA.add(btnDecimal1);
        btnDecimal1.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btnDecimal1.setSelected(true);
        btnDecimal1.setText("Decimal");
        btnDecimal1.setToolTipText("1234");
        btnDecimal1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDecimal1ActionPerformed(evt);
            }
        });

        gdbA.add(btnBinario1);
        btnBinario1.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btnBinario1.setText("Binario");
        btnBinario1.setToolTipText("1010");
        btnBinario1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBinario1ActionPerformed(evt);
            }
        });

        gdbA.add(btnOctal1);
        btnOctal1.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btnOctal1.setText("Octal");
        btnOctal1.setToolTipText("148");
        btnOctal1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnOctal1ActionPerformed(evt);
            }
        });

        gdbA.add(btnHexadecimal1);
        btnHexadecimal1.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btnHexadecimal1.setText("Hexadecimal");
        btnHexadecimal1.setToolTipText("12EF1");
        btnHexadecimal1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnHexadecimal1ActionPerformed(evt);
            }
        });

        gdbB.add(btnDecimal2);
        btnDecimal2.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btnDecimal2.setText("Decimal");
        btnDecimal2.setToolTipText("1234");
        btnDecimal2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDecimal2ActionPerformed(evt);
            }
        });

        gdbB.add(btnBinario2);
        btnBinario2.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btnBinario2.setSelected(true);
        btnBinario2.setText("Binario");
        btnBinario2.setToolTipText("1010");
        btnBinario2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBinario2ActionPerformed(evt);
            }
        });

        gdbB.add(btnOctal2);
        btnOctal2.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btnOctal2.setText("Octal");
        btnOctal2.setToolTipText("148");
        btnOctal2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnOctal2ActionPerformed(evt);
            }
        });

        gdbB.add(btnHexadecimal2);
        btnHexadecimal2.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        btnHexadecimal2.setText("Hexadecimal");
        btnHexadecimal2.setToolTipText("12EF1");
        btnHexadecimal2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnHexadecimal2ActionPerformed(evt);
            }
        });

        cdt1.setFont(new java.awt.Font("Century Gothic", 3, 12)); // NOI18N
        cdt1.setHorizontalAlignment(javax.swing.JTextField.LEFT);
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
        cdt2.setHorizontalAlignment(javax.swing.JTextField.LEFT);

        jLabel1.setFont(new java.awt.Font("Century Gothic", 0, 24)); // NOI18N
        jLabel1.setText("Sistemas numéricos");

        leb2.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        leb2.setText("Sistema 2");

        leb1.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        leb1.setText("Sistema 1");

        jButton1.setFont(new java.awt.Font("Century Gothic", 0, 14)); // NOI18N
        jButton1.setText("Convertir");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel1)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jButton1)
                            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addComponent(cdt1, javax.swing.GroupLayout.PREFERRED_SIZE, 269, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                    .addComponent(leb1, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addGroup(javax.swing.GroupLayout.Alignment.LEADING, jPanel1Layout.createSequentialGroup()
                                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                            .addComponent(btnBinario1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                            .addComponent(btnDecimal1, javax.swing.GroupLayout.PREFERRED_SIZE, 115, javax.swing.GroupLayout.PREFERRED_SIZE))
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                            .addComponent(btnHexadecimal1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                            .addComponent(btnOctal1, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE))))))
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addGap(18, 18, 18)
                                .addComponent(cdt2, javax.swing.GroupLayout.PREFERRED_SIZE, 262, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addGap(24, 24, 24)
                                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addComponent(leb2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                    .addGroup(jPanel1Layout.createSequentialGroup()
                                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                            .addComponent(btnDecimal2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                            .addComponent(btnBinario2, javax.swing.GroupLayout.PREFERRED_SIZE, 115, javax.swing.GroupLayout.PREFERRED_SIZE))
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                            .addComponent(btnHexadecimal2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                            .addComponent(btnOctal2, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE))))))))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addGap(0, 12, Short.MAX_VALUE)
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(btnDecimal2)
                            .addComponent(btnOctal2))
                        .addGap(18, 18, 18)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(btnBinario2)
                            .addComponent(btnHexadecimal2)))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(btnDecimal1)
                            .addComponent(btnOctal1))
                        .addGap(18, 18, 18)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(btnBinario1)
                            .addComponent(btnHexadecimal1))))
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(10, 10, 10)
                        .addComponent(leb2))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(leb1)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(cdt1, javax.swing.GroupLayout.PREFERRED_SIZE, 112, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(cdt2, javax.swing.GroupLayout.PREFERRED_SIZE, 112, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jButton1)
                .addContainerGap())
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnOctal1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnOctal1ActionPerformed
        leb1.setText("Sistema Octal");
    }//GEN-LAST:event_btnOctal1ActionPerformed

    private void btnOctal2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnOctal2ActionPerformed
        leb2.setText("Sistema Octal");
    }//GEN-LAST:event_btnOctal2ActionPerformed

    private void cdt1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cdt1ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_cdt1ActionPerformed

    private void btnHexadecimal1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnHexadecimal1ActionPerformed
        leb1.setText("Sistema Hexadecimal");
    }//GEN-LAST:event_btnHexadecimal1ActionPerformed

    private void cdt1KeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_cdt1KeyPressed
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            this.calcular();
        }
    }//GEN-LAST:event_cdt1KeyPressed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        this.calcular();
    }//GEN-LAST:event_jButton1ActionPerformed

    private void btnDecimal1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnDecimal1ActionPerformed
        leb1.setText("Sistema Decimal");
    }//GEN-LAST:event_btnDecimal1ActionPerformed

    private void btnBinario2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBinario2ActionPerformed
        leb2.setText("Sistema Binario");
    }//GEN-LAST:event_btnBinario2ActionPerformed

    private void btnBinario1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBinario1ActionPerformed
        leb1.setText("Sistema Binario");
    }//GEN-LAST:event_btnBinario1ActionPerformed

    private void btnDecimal2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnDecimal2ActionPerformed
        leb2.setText("Sistema Decimal");
    }//GEN-LAST:event_btnDecimal2ActionPerformed

    private void btnHexadecimal2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnHexadecimal2ActionPerformed
        leb2.setText("Sistema Hexadecimal");
    }//GEN-LAST:event_btnHexadecimal2ActionPerformed

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
            java.util.logging.Logger.getLogger(frmConversion.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(frmConversion.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(frmConversion.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(frmConversion.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                frmConversion dialog = new frmConversion(new javax.swing.JFrame(), true);
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
    private javax.swing.JToggleButton btnBinario1;
    private javax.swing.JToggleButton btnBinario2;
    private javax.swing.JToggleButton btnDecimal1;
    private javax.swing.JToggleButton btnDecimal2;
    private javax.swing.JToggleButton btnHexadecimal1;
    private javax.swing.JToggleButton btnHexadecimal2;
    private javax.swing.JToggleButton btnOctal1;
    private javax.swing.JToggleButton btnOctal2;
    private javax.swing.JTextField cdt1;
    private javax.swing.JTextField cdt2;
    private javax.swing.ButtonGroup gdbA;
    private javax.swing.ButtonGroup gdbB;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JLabel leb1;
    private javax.swing.JLabel leb2;
    // End of variables declaration//GEN-END:variables
}
