package Personas;

import Errores.ErrorConexion;
import Errores.ErrorMensaje;
import Main.frmPrincipal;
import Personas.Clientes.ControladorClientes;
import Personas.Clientes.clsClientes;
import Personas.Clientes.frmEditarCliente;
import Personas.Usuarios.ControladorUsuarios;
import Personas.Usuarios.Oficiales.ControladorOficial;
import Personas.Usuarios.clsUsuarios;
import Personas.Usuarios.frmEditarUsuario;
import java.awt.event.KeyEvent;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.JPopupMenu;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

public class frmBuscarPersona extends javax.swing.JInternalFrame {

    private ControladorClientes controlCliente;
    private ControladorUsuarios controlUsuario;
    private ControladorOficial controlOficial;
    
    private JPopupMenu menu = new JPopupMenu();
    private JMenuItem btnEditar = new JMenuItem("Editar registro");
    private JMenuItem btnEliminar = new JMenuItem("Eliminar registro");

    public frmBuscarPersona() {
        initComponents();
        Utilidades.AjustarVentana.ajustar(this, 1.5, 2);
        menu.add(btnEditar);
        menu.add(btnEliminar);
        tblPersonas.setComponentPopupMenu(menu);
        controlCliente = new ControladorClientes();
        controlUsuario = new ControladorUsuarios();
        controlOficial = new ControladorOficial();
        
        btnEditar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEditarActionPerformed(evt);
            }
        });
        btnEliminar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEliminarActionPerformed(evt);
            }
        });
        
    }

    private void boton() {
        try {
            DefaultTableModel modelo = (DefaultTableModel) tblPersonas.getModel();
            modelo.setNumRows(0);
            ErrorMensaje.crear();
            controlCliente.filtar(this);
            controlUsuario.filtar(this);
        } catch (ErrorConexion ex) {
            JOptionPane.showMessageDialog(this, ex.getMessage(), "Error", 0);
        }
    }

    private void tipoUsuario() {
        int indice = tblPersonas.getSelectedRow();
        try {
            if (tblPersonas.getValueAt(indice, 5).toString().equals("Cliente")) {
                frmEditarCliente editar = new frmEditarCliente();
                clsClientes cliente = controlCliente.editar(this, indice);
                editar.setCedula(cliente.getCedula());
                editar.setNombre(cliente.getNombre());
                editar.setTelefono(cliente.getTelefono());
                editar.setCorreo(cliente.getCorreo());
                editar.setTitle("Actualizar " + tblPersonas.getValueAt(indice, 5));
                frmPrincipal.agregar(editar);
            } else {
                clsUsuarios usuario = controlUsuario.editar(this, indice);
                frmEditarUsuario editar = new frmEditarUsuario();
                editar.setCedula(usuario.getCedula());
                editar.setNombre(usuario.getNombre());
                editar.setTelefono(usuario.getTelefono());
                editar.setCorreo(usuario.getCorreo());
                editar.setUsuario(usuario.getNomUsuario());
                editar.setUser(usuario.getNomUsuario());
                editar.setTitle("Actualizar Usuario - " + tblPersonas.getValueAt(indice, 5));
                frmPrincipal.agregar(editar);
            }

        } catch (ErrorConexion ex) {
            JOptionPane.showMessageDialog(this, ex.getMessage(), "Error", 0);
        }
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        txtBusqueda = new javax.swing.JTextField();
        btnBuscar = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        tblPersonas = new javax.swing.JTable();

        setClosable(true);
        setTitle("Buscar");
        setFrameIcon(new javax.swing.ImageIcon(getClass().getResource("/Utilidades/Imagenes/Buscar.png"))); // NOI18N

        txtBusqueda.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                txtBusquedaKeyPressed(evt);
            }
        });

        btnBuscar.setText("Buscar");
        btnBuscar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBuscarActionPerformed(evt);
            }
        });

        tblPersonas.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Nombre", "N° de Cédula", "Fecha", "Telefono", "Correo", "Tipo"
            }
        ) {
            Class[] types = new Class [] {
                java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.Object.class
            };
            boolean[] canEdit = new boolean [] {
                false, false, false, false, false, false
            };

            public Class getColumnClass(int columnIndex) {
                return types [columnIndex];
            }

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jScrollPane1.setViewportView(tblPersonas);
        if (tblPersonas.getColumnModel().getColumnCount() > 0) {
            tblPersonas.getColumnModel().getColumn(0).setResizable(false);
            tblPersonas.getColumnModel().getColumn(1).setResizable(false);
            tblPersonas.getColumnModel().getColumn(2).setResizable(false);
            tblPersonas.getColumnModel().getColumn(3).setResizable(false);
            tblPersonas.getColumnModel().getColumn(4).setResizable(false);
            tblPersonas.getColumnModel().getColumn(5).setResizable(false);
        }

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 468, Short.MAX_VALUE)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(txtBusqueda)
                        .addGap(39, 39, 39)
                        .addComponent(btnBuscar, javax.swing.GroupLayout.PREFERRED_SIZE, 128, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.CENTER)
                    .addComponent(txtBusqueda)
                    .addComponent(btnBuscar, javax.swing.GroupLayout.PREFERRED_SIZE, 27, Short.MAX_VALUE))
                .addGap(18, 18, 18)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 267, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void txtBusquedaKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtBusquedaKeyPressed
        if (evt.getKeyCode() == KeyEvent.VK_ENTER) {
            this.boton();
        }
    }//GEN-LAST:event_txtBusquedaKeyPressed

    private void btnBuscarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBuscarActionPerformed
        this.boton();
    }//GEN-LAST:event_btnBuscarActionPerformed

    private void btnEliminarActionPerformed(java.awt.event.ActionEvent evt) {
        int indice = tblPersonas.getSelectedRow();
        if (indice != -1) {
            try {
                ErrorMensaje.crear();
                DefaultTableModel modelo = (DefaultTableModel) tblPersonas.getModel();
                if (tblPersonas.getValueAt(indice, 5).toString().equals("Cliente")) {
                    controlCliente.eliminar(this);
                }else{
                    if (tblPersonas.getValueAt(indice, 5).toString().equals("Oficial")) {
                        controlOficial.eliminar(this);
                    }
                    controlUsuario.eliminar(this);
                }
                modelo.removeRow(tblPersonas.getSelectedRow());
            } catch (ErrorConexion ex) {
                JOptionPane.showMessageDialog(this, ex.getMessage(), "Error", 0);
            }
        }
    }
    
    private void btnEditarActionPerformed(java.awt.event.ActionEvent evt) {
        int indice = tblPersonas.getSelectedRow();
        if (indice != -1) {
            int opc = JOptionPane.showConfirmDialog(this, "¿Esta seguro que desea seleccionar este "
                    + tblPersonas.getValueAt(indice, 5) + "?", "Confirmación", 0, 2);
            if (opc == 0) {
                this.tipoUsuario();
            }
        }
    }
    

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnBuscar;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable tblPersonas;
    private javax.swing.JTextField txtBusqueda;
    // End of variables declaration//GEN-END:variables

    public String getBusqueda() {
        return txtBusqueda.getText();
    }

    public JTable getPersonas() {
        return tblPersonas;
    }

    public void setjPersonas(JTable jTable1) {
        this.tblPersonas = jTable1;
    }

}
