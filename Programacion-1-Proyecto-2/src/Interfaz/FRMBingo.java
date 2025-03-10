package Interfaz;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import Utilidades.*;

public class FRMBingo extends javax.swing.JFrame {
    public static Carton misCartones[] = new Carton[5];
    public static int cantVentanas = 0;

    public FRMBingo() {
        initComponents();
        this.setExtendedState(JFrame.MAXIMIZED_BOTH);

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        fondo = new javax.swing.JDesktopPane();
        jMenuBar1 = new javax.swing.JMenuBar();
        brMenu = new javax.swing.JMenu();
        agragarCarton = new javax.swing.JMenuItem();
        tipoDeJuego = new javax.swing.JMenuItem();
        desmarcarNumero = new javax.swing.JMenuItem();
        limpiar = new javax.swing.JMenuItem();
        Jugar = new javax.swing.JMenuItem();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("BINGO");

        javax.swing.GroupLayout fondoLayout = new javax.swing.GroupLayout(fondo);
        fondo.setLayout(fondoLayout);
        fondoLayout.setHorizontalGroup(
            fondoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 400, Short.MAX_VALUE)
        );
        fondoLayout.setVerticalGroup(
            fondoLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 281, Short.MAX_VALUE)
        );

        jMenuBar1.setBorder(null);

        brMenu.setText("Opciones");

        agragarCarton.setText("Agregar Cartón");
        agragarCarton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                agragarCartonActionPerformed(evt);
            }
        });
        brMenu.add(agragarCarton);

        tipoDeJuego.setText("Tipo de Juego");
        tipoDeJuego.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                tipoDeJuegoActionPerformed(evt);
            }
        });
        brMenu.add(tipoDeJuego);

        desmarcarNumero.setText("Desmarcar Número");
        desmarcarNumero.setToolTipText("");
        desmarcarNumero.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                desmarcarNumeroActionPerformed(evt);
            }
        });
        brMenu.add(desmarcarNumero);

        limpiar.setText("Limpiar");
        limpiar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                limpiarActionPerformed(evt);
            }
        });
        brMenu.add(limpiar);

        Jugar.setText("Jugar");
        Jugar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                JugarActionPerformed(evt);
            }
        });
        brMenu.add(Jugar);

        jMenuBar1.add(brMenu);

        setJMenuBar(jMenuBar1);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(fondo)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(fondo)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void agragarCartonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_agragarCartonActionPerformed
        if (this.cantVentanas < 5) {
            JDCarton carton = new JDCarton(this, false);
            carton.setVisible(true);
            this.cantVentanas++;
        } else {
            JOptionPane.showMessageDialog(rootPane, "Limite de ventanas");
        }
    }//GEN-LAST:event_agragarCartonActionPerformed

    private void tipoDeJuegoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_tipoDeJuegoActionPerformed
        JDTipo tipo = new JDTipo(this, false);
        tipo.setVisible(true);
    }//GEN-LAST:event_tipoDeJuegoActionPerformed

    private void JugarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_JugarActionPerformed
        JDJuego juego = new JDJuego(this, false);
        juego.setVisible(true);
    }//GEN-LAST:event_JugarActionPerformed

    private void limpiarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_limpiarActionPerformed
          for (int i = 0; i < cantVentanas; i++) {
           misCartones[i].matrizBooleanEnFalse();
        }
    }//GEN-LAST:event_limpiarActionPerformed

    private void desmarcarNumeroActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_desmarcarNumeroActionPerformed
         JDNumero juego = new JDNumero(this, false);
        juego.setVisible(true);
    }//GEN-LAST:event_desmarcarNumeroActionPerformed

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
            java.util.logging.Logger.getLogger(FRMBingo.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(FRMBingo.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(FRMBingo.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(FRMBingo.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FRMBingo().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JMenuItem Jugar;
    private javax.swing.JMenuItem agragarCarton;
    private javax.swing.JMenu brMenu;
    private javax.swing.JMenuItem desmarcarNumero;
    public static javax.swing.JDesktopPane fondo;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JMenuItem limpiar;
    public static javax.swing.JMenuItem tipoDeJuego;
    // End of variables declaration//GEN-END:variables
}
