package Personas.Clientes;

import Archivos.ControladorXml;
import Errores.ErrorConexion;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

public class frmMostrarClientes extends javax.swing.JInternalFrame {

    private ControladorClientes clientes;
    private ControladorXml xml;

    public frmMostrarClientes() {
        initComponents();
        Utilidades.AjustarVentana.ajustar(this, 2, 2);
        clientes = new ControladorClientes();
        try {
            clientes.cargarClientes(this);
        } catch (ErrorConexion ex) {
            Logger.getLogger(frmMostrarClientes.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        tblClientes = new javax.swing.JTable();

        setClosable(true);
        setTitle("Exportar");
        setFrameIcon(new javax.swing.ImageIcon(getClass().getResource("/Utilidades/Imagenes/Exportar.png"))); // NOI18N

        tblClientes.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Cedula", "Nombre", "Edad", "Telefono", "Correo"
            }
        ) {
            Class[] types = new Class [] {
                java.lang.String.class, java.lang.String.class, java.lang.Integer.class, java.lang.String.class, java.lang.String.class
            };
            boolean[] canEdit = new boolean [] {
                false, false, false, false, false
            };

            public Class getColumnClass(int columnIndex) {
                return types [columnIndex];
            }

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        tblClientes.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tblClientesMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(tblClientes);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void tblClientesMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tblClientesMouseClicked
        int i = tblClientes.getSelectedRow();
        xml = new ControladorXml();
        if (i != -1) {
            try {
                int opc = JOptionPane.showConfirmDialog(this, "¿Esta seguro que desea seleccionar este Cliente?", "Confirmación", 0, 2);
                if (opc == 0) {
                    clsClientes cliente = clientes.pasarDatos(this, i);
                    xml.importarXml(cliente.getCedula());
                }
            } catch (ErrorConexion ex) {
                JOptionPane.showMessageDialog(this, ex.getMessage(), "Error", 0);
            }
        }
    }//GEN-LAST:event_tblClientesMouseClicked


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable tblClientes;
    // End of variables declaration//GEN-END:variables

    public JTable getTblClientes() {
        return tblClientes;
    }

    public void setTblClientes(JTable tblClientes) {
        this.tblClientes = tblClientes;
    }

}
