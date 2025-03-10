package Menu;

import BaseDeDatos.VistaConfiguracion;
import Citas.VistaCitas;
import Personas.Clientes.VistaClientes;
import Personas.Usuarios.VistaUsuarios;
import Pruebas.VistaPruebas;
import java.awt.Graphics;
import java.awt.Image;
import javax.swing.ImageIcon;
import javax.swing.JInternalFrame;

public class VistaMenu extends javax.swing.JFrame {

    public VistaMenu() {
        initComponents();
        this.setExtendedState(6);
    }

    private void agregar(JInternalFrame vista) {
        this.Escritorio.add(vista);
        vista.setVisible(true);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        ImageIcon icono = new ImageIcon(getClass().getResource("/Utilidades/Fondo.jpg"));
        Image imagen = icono.getImage();
        Escritorio = new javax.swing.JDesktopPane(){
            public void paintComponent(Graphics g){
                g.drawImage(imagen,0,0,getWidth(),getHeight(),this);
            }
        };
        BarraMenu = new javax.swing.JMenuBar();
        MInicar = new javax.swing.JMenu();
        BtnInicar = new javax.swing.JMenuItem();
        Btncrear = new javax.swing.JMenuItem();
        btnCliente = new javax.swing.JMenuItem();
        btnPrueba = new javax.swing.JMenuItem();
        btnCita = new javax.swing.JMenuItem();
        MConfig = new javax.swing.JMenu();
        BtnConfig = new javax.swing.JMenuItem();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        javax.swing.GroupLayout EscritorioLayout = new javax.swing.GroupLayout(Escritorio);
        Escritorio.setLayout(EscritorioLayout);
        EscritorioLayout.setHorizontalGroup(
            EscritorioLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 580, Short.MAX_VALUE)
        );
        EscritorioLayout.setVerticalGroup(
            EscritorioLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 394, Short.MAX_VALUE)
        );

        BarraMenu.setBorder(null);

        MInicar.setText("Sesión");

        BtnInicar.setText("Iniciar sesión");
        BtnInicar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnInicarActionPerformed(evt);
            }
        });
        MInicar.add(BtnInicar);

        Btncrear.setText("Crear sesión");
        Btncrear.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtncrearActionPerformed(evt);
            }
        });
        MInicar.add(Btncrear);

        btnCliente.setText("Cliente");
        btnCliente.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnClienteActionPerformed(evt);
            }
        });
        MInicar.add(btnCliente);

        btnPrueba.setText("Prueba");
        btnPrueba.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnPruebaActionPerformed(evt);
            }
        });
        MInicar.add(btnPrueba);

        btnCita.setText("Citas");
        btnCita.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCitaActionPerformed(evt);
            }
        });
        MInicar.add(btnCita);

        BarraMenu.add(MInicar);

        MConfig.setText("Configuración");

        BtnConfig.setAccelerator(javax.swing.KeyStroke.getKeyStroke(java.awt.event.KeyEvent.VK_1, java.awt.event.InputEvent.CTRL_MASK));
        BtnConfig.setText("Configuración");
        BtnConfig.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                BtnConfigActionPerformed(evt);
            }
        });
        MConfig.add(BtnConfig);

        BarraMenu.add(MConfig);

        setJMenuBar(BarraMenu);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(Escritorio)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(Escritorio)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void BtnConfigActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnConfigActionPerformed
        this.agregar(new VistaConfiguracion());
    }//GEN-LAST:event_BtnConfigActionPerformed

    private void BtnInicarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtnInicarActionPerformed

    }//GEN-LAST:event_BtnInicarActionPerformed

    private void BtncrearActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_BtncrearActionPerformed
        this.agregar(new VistaUsuarios());
    }//GEN-LAST:event_BtncrearActionPerformed

    private void btnClienteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnClienteActionPerformed
        this.agregar(new VistaClientes());
    }//GEN-LAST:event_btnClienteActionPerformed

    private void btnPruebaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnPruebaActionPerformed
        this.agregar(new VistaPruebas());
    }//GEN-LAST:event_btnPruebaActionPerformed

    private void btnCitaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCitaActionPerformed
        this.agregar(new VistaCitas());
    }//GEN-LAST:event_btnCitaActionPerformed

    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Windows".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException | InstantiationException | IllegalAccessException | javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(VistaMenu.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new VistaMenu().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JMenuBar BarraMenu;
    private javax.swing.JMenuItem BtnConfig;
    private javax.swing.JMenuItem BtnInicar;
    private javax.swing.JMenuItem Btncrear;
    public static javax.swing.JDesktopPane Escritorio;
    private javax.swing.JMenu MConfig;
    private javax.swing.JMenu MInicar;
    private javax.swing.JMenuItem btnCita;
    private javax.swing.JMenuItem btnCliente;
    private javax.swing.JMenuItem btnPrueba;
    // End of variables declaration//GEN-END:variables

}
