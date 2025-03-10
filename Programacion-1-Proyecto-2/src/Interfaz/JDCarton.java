package Interfaz;

import static Interfaz.FRMBingo.misCartones;
import Utilidades.Carton;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.util.ArrayList;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.Timer;

public class JDCarton extends javax.swing.JDialog {

    final int c = FRMBingo.cantVentanas;
    ArrayList<JLabel> lblNumeros = new ArrayList<JLabel>();

    public void cargarBingo() {
        if (!misCartones[c].esValidoEnColumna(Integer.parseInt(cdtNumero.getText()))) {
            JOptionPane.showMessageDialog(rootPane, "No es valido por columna");
        } else if (!misCartones[c].esValidoEnMatriz(Integer.parseInt(cdtNumero.getText()))) {
            JOptionPane.showMessageDialog(rootPane, "No es valido por matriz (ya existe)");
        }
        if (misCartones[c].esValidoEnColumna(Integer.parseInt(cdtNumero.getText())) && misCartones[c].esValidoEnMatriz(Integer.parseInt(cdtNumero.getText()))) {
            this.crearNumero(cdtNumero.getText(), misCartones[c].getF(), misCartones[c].getC());
            misCartones[c].cargarBingo(Integer.parseInt(cdtNumero.getText()));
        }
    }

    public void crearNumero(String num, int f, int c) {
        JLabel lblNum = new JLabel();
        lblNum.setFont(new java.awt.Font("Century Gothic", 1, 20));
        lblNum.setText(num);
        lblNum.setHorizontalAlignment((int) CENTER_ALIGNMENT);
        getContentPane().add(lblNum, new org.netbeans.lib.awtextra.AbsoluteConstraints(40+c * 55,65+f * 55, 55, 55));      
        this.lblNumeros.add(lblNum);
        getContentPane().setComponentZOrder(lblNum, 0);
        this.pack();
    }

    public Timer actualizar = new Timer(100, new ActionListener() {
        @Override
        public void actionPerformed(ActionEvent e) {
            actualizar();
        }

    });

    public void actualizar() {
        for (int f = 0; f < 5; f++) {
            for (int c = 0; c < 5; c++) {
                if (FRMBingo.misCartones[this.c].getMatrizBoolean()[f][c] == true) {
                    for (int i = 0; i < lblNumeros.size(); i++) {
                        if (FRMBingo.misCartones[this.c].getMatrizEntera()[f][c] == Integer.parseInt(lblNumeros.get(i).getText())) {
                            lblNumeros.get(i).setForeground(Color.red);
                        }
                    }
                }
                if (FRMBingo.misCartones[this.c].getMatrizBoolean()[f][c] == false) {
                    for (int i = 0; i < lblNumeros.size(); i++) {
                        if (FRMBingo.misCartones[this.c].getMatrizEntera()[f][c] == Integer.parseInt(lblNumeros.get(i).getText())) {
                            lblNumeros.get(i).setForeground(Color.black);
                        }
                    }
                }
            }
        }
    }

    public void cerrar() {
        try {
            this.setDefaultCloseOperation(DO_NOTHING_ON_CLOSE);
            addWindowListener(new WindowAdapter() {
                @Override
                public void windowClosing(WindowEvent e) {
                    confirmarSalida();
                }
            });
            this.setVisible(true);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private void confirmarSalida() {
        if (JOptionPane.showConfirmDialog(rootPane, "¿Está seguro de cerrar el cartón?", "Advetencia", JOptionPane.YES_NO_OPTION) == JOptionPane.YES_NO_OPTION) {
            this.setDefaultCloseOperation(DISPOSE_ON_CLOSE);
            misCartones[c].cerrar();
            FRMBingo.cantVentanas--;
        }
    }

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

    public JDCarton(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        this.setLocationRelativeTo(null);
        this.cerrar();
        misCartones[c] = new Carton();
        this.actualizar.start();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        lblcod = new javax.swing.JLabel();
        cdtCodigo = new javax.swing.JTextField();
        lblCodigo = new javax.swing.JLabel();
        cdtNumero = new javax.swing.JTextField();
        lblNumero = new javax.swing.JLabel();
        lblFondo = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DO_NOTHING_ON_CLOSE);
        setTitle("CARTON, Código: ");
        setMinimumSize(new java.awt.Dimension(350, 429));
        setResizable(false);
        setSize(new java.awt.Dimension(350, 429));
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        lblcod.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        getContentPane().add(lblcod, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 50, 40, 10));

        cdtCodigo.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        cdtCodigo.setToolTipText("Precione  ENTER");
        cdtCodigo.setBorder(null);
        cdtCodigo.setMaximumSize(new java.awt.Dimension(70, 20));
        cdtCodigo.setMinimumSize(new java.awt.Dimension(70, 20));
        cdtCodigo.setPreferredSize(new java.awt.Dimension(70, 20));
        cdtCodigo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cdtCodigoActionPerformed(evt);
            }
        });
        cdtCodigo.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                cdtCodigoKeyPressed(evt);
            }
        });
        getContentPane().add(cdtCodigo, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 370, 70, 20));

        lblCodigo.setFont(new java.awt.Font("Century Gothic", 0, 11)); // NOI18N
        lblCodigo.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblCodigo.setText("Código de cartón");
        getContentPane().add(lblCodigo, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 350, -1, -1));

        cdtNumero.setHorizontalAlignment(javax.swing.JTextField.CENTER);
        cdtNumero.setToolTipText("Precione  ENTER");
        cdtNumero.setBorder(null);
        cdtNumero.setMaximumSize(new java.awt.Dimension(70, 20));
        cdtNumero.setMinimumSize(new java.awt.Dimension(70, 20));
        cdtNumero.setPreferredSize(new java.awt.Dimension(70, 20));
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
        getContentPane().add(cdtNumero, new org.netbeans.lib.awtextra.AbsoluteConstraints(200, 370, 70, 20));

        lblNumero.setFont(new java.awt.Font("Century Gothic", 0, 11)); // NOI18N
        lblNumero.setText("Números de Cartón");
        getContentPane().add(lblNumero, new org.netbeans.lib.awtextra.AbsoluteConstraints(200, 350, -1, -1));

        lblFondo.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblFondo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagenes/Fondo de Carton.png"))); // NOI18N
        getContentPane().add(lblFondo, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, -1, -1));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void cdtCodigoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cdtCodigoActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_cdtCodigoActionPerformed

    private void cdtCodigoKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_cdtCodigoKeyPressed
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            boolean ban = true;
            if (this.esValido(this.cdtCodigo.getText())) {
                for (int i = 0; i < FRMBingo.cantVentanas; i++) {
                    if (cdtCodigo.getText().equals(misCartones[i].getCodigo())) {
                        ban = false;
                    }
                }
                if (ban) {
                    misCartones[c].setCodigo(cdtCodigo.getText());
                    this.setTitle(this.getTitle() + " " + misCartones[c].getCodigo());
                    this.lblcod.setText(misCartones[c].getCodigo());
                    this.cdtCodigo.setVisible(false);
                    this.lblCodigo.setVisible(false);
                } else {
                    JOptionPane.showMessageDialog(rootPane, "El Cartón ya existe");
                }

            }
            this.cdtCodigo.setText("");
        }
    }//GEN-LAST:event_cdtCodigoKeyPressed

    private void cdtNumeroActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cdtNumeroActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_cdtNumeroActionPerformed

    private void cdtNumeroKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_cdtNumeroKeyPressed
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            if (this.esValido(this.cdtNumero.getText()) && misCartones[c].getMatrizEntera()[4][4] == 0) {
                this.cargarBingo();
            }
            this.cdtNumero.setText("");
            if (misCartones[c].getMatrizEntera()[4][4] != 0) {
                this.cdtNumero.setVisible(false);
                this.lblNumero.setVisible(false);
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
            java.util.logging.Logger.getLogger(JDCarton.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(JDCarton.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(JDCarton.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(JDCarton.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                JDCarton dialog = new JDCarton(new javax.swing.JFrame(), true);
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
    private javax.swing.JTextField cdtCodigo;
    private javax.swing.JTextField cdtNumero;
    private javax.swing.JLabel lblCodigo;
    private javax.swing.JLabel lblFondo;
    private javax.swing.JLabel lblNumero;
    private javax.swing.JLabel lblcod;
    // End of variables declaration//GEN-END:variables
}
