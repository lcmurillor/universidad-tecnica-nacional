package Personas.Usuarios;

import BaseDeDatos.BaseDatos;
import Errores.ErrorConexion;
import Errores.ErrorMensaje;
import Main.frmPrincipal;
import Personas.Usuarios.Oficiales.clsOficial;
import Personas.Usuarios.Secretarias.clsSecretaria;
import Personas.frmBuscarPersona;
import java.util.regex.Pattern;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

public class ControladorUsuarios {

    private clsUsuarios usuario;
    private BaseDatos BD;

    public ControladorUsuarios() {
    }

    public void agregar(frmRegistarUsuario vista) throws ErrorConexion {
        BD = new BaseDatos("INSERT INTO tblusuarios VALUES (?,?,?,?,?,?,?,?)");
        if (vista.getTipo().equals("Oficial")) {
            usuario = new clsOficial(vista.getCedula(), vista.getNombre(), vista.getFecha(), vista.getTelefono(), vista.getCorreo(),
                    vista.getUsuario(), vista.getContrasena(), vista.getTipo());
            vista.dispose();
        } else {
            usuario = new clsSecretaria(vista.getCedula(), vista.getNombre(), vista.getFecha(), vista.getTelefono(), vista.getCorreo(),
                    vista.getUsuario(), vista.getContrasena(), vista.getTipo());
            vista.dispose();
        }
        if (ErrorMensaje.mostrarMensajes()) {
            JOptionPane.showMessageDialog(vista, ErrorMensaje.getMsj(), "Error", 0);
        } else {
            BD.ejecutar(new Object[]{usuario.getCedula(), usuario.getNombre(), usuario.getFechaNac(), usuario.getTelefono(), usuario.getCorreo(),
                usuario.getNomUsuario(), usuario.getContra(), usuario.getTipoUsuario()});
        }
    }

    public void eliminar(frmBuscarPersona vista) throws ErrorConexion {
        usuario = new clsUsuarios();
        usuario.setCedula(vista.getPersonas().getValueAt(vista.getPersonas().getSelectedRow(), 0).toString());
        if (ErrorMensaje.mostrarMensajes()) {
            JOptionPane.showMessageDialog(vista, ErrorMensaje.getMsj(), "Error", 0);
        } else {
            BD = new BaseDatos("DELETE FROM tblusuarios WHERE Cedula =?");
            BD.ejecutar(new Object[]{usuario.getCedula()});
            JOptionPane.showMessageDialog(vista, "El Registro se Elimino", "Eliminar Usuario", 1);
        }
    }

    public void filtar(frmBuscarPersona vista) throws ErrorConexion {
        if (Pattern.matches("[a-zA-Z]+", vista.getBusqueda())) {
            BD = new BaseDatos("SELECT * FROM tblusuarios WHERE Nombre LIKE ?");
        } else {
            BD = new BaseDatos("SELECT * FROM tblusuarios WHERE Cedula LIKE ?");
        }
        BD.ejecutar(new Object[]{"%" + vista.getBusqueda() + "%"});
        DefaultTableModel modelo = (DefaultTableModel) vista.getPersonas().getModel();
        Object obj[];
        do {
            obj = BD.getObjet();
            if (obj != null) {
                usuario = new clsUsuarios(obj);
                modelo.addRow(usuario.toObjects(usuario.getTipoUsuario()));
            }
        } while (obj != null);
    }

    public void modificar(frmEditarUsuario vista) throws ErrorConexion {
        BD = new BaseDatos("UPDATE tblusuarios SET Nombre=?, Telefono=?, Correo=?, Usuario=? WHERE Cedula=?");
        usuario = new clsUsuarios(vista.getCedula(), vista.getNombre(), "01/01/2019", vista.getTelefono(), vista.getCorreo());
        usuario.setNomUsuario(vista.getUsuario());
        if (ErrorMensaje.mostrarMensajes()) {
            JOptionPane.showMessageDialog(vista, ErrorMensaje.getMsj(), "Error", 0);
        } else {
            BD.ejecutar(new Object[]{usuario.getNombre(), usuario.getTelefono(), usuario.getCorreo(), usuario.getNomUsuario(), usuario.getCedula()});
            JOptionPane.showMessageDialog(vista, "Registro Exitoso", "Actualizar Usuario", 1);
            vista.dispose();
        }
    }

    public void modificarContraseña(frmCambiarContrasena vistaContra, frmIniciarSesion vistaSesion) throws ErrorConexion {
        BD = new BaseDatos("SELECT Contraseña FROM tblusuarios WHERE Usuario = ?");
        usuario = new clsUsuarios();
        usuario.setNomUsuario(vistaSesion.getUsuario());
        BD.ejecutar(new Object[]{usuario.getNomUsuario()});
        usuario.setContra((String) BD.getObjet()[0]);
        if (usuario.cambiarContrasena(vistaContra.getContrasena(), vistaContra.getNuevaContrasena()) && !ErrorMensaje.mostrarMensajes()) {
            BD.setSentencia("UPDATE tblusuarios SET Contraseña = ? WHERE Usuario = ? ");
            BD.ejecutar(new Object[]{usuario.getContra(), usuario.getNomUsuario()});
            JOptionPane.showMessageDialog(vistaContra, "La Contraseña se ha cambiado con Exito", "Cambiar Contraseña", 1);
            vistaContra.dispose();
        } else {
            JOptionPane.showMessageDialog(vistaContra, ErrorMensaje.getMsj(), "Error", 0);
        }
    }

    public void modificarContraseña(frmCambiarContrasena vistaContra) throws ErrorConexion {
        BD = new BaseDatos("SELECT Contraseña FROM tblusuarios WHERE Usuario = ?");
        usuario = new clsUsuarios();
        usuario.setNomUsuario(frmEditarUsuario.getUser());
        BD.ejecutar(new Object[]{usuario.getNomUsuario()});
        usuario.setContra((String) BD.getObjet()[0]);
        if (usuario.cambiarContrasena(vistaContra.getContrasena(), vistaContra.getNuevaContrasena()) && !ErrorMensaje.mostrarMensajes()) {
            BD.setSentencia("UPDATE tblusuarios SET Contraseña = ? WHERE Usuario = ? ");
            BD.ejecutar(new Object[]{usuario.getContra(), usuario.getNomUsuario()});
            JOptionPane.showMessageDialog(vistaContra, "La Contraseña se ha cambiado con Exito", "Cambiar Contraseña", 1);
            vistaContra.dispose();
        } else {
            JOptionPane.showMessageDialog(vistaContra, ErrorMensaje.getMsj(), "Error", 0);
        }
    }

    public void iniciarSesion(frmIniciarSesion vistaSesion, frmPrincipal vistaPrincipal) throws ErrorConexion {
        BD = new BaseDatos("SELECT Cedula, Nombre, `Tipo Usuario` FROM tblusuarios WHERE Usuario = ? AND Contraseña = ?");
        usuario = new clsUsuarios();
        usuario.setNomUsuario(vistaSesion.getUsuario());
        usuario.setContra(vistaSesion.getContrasena());
        BD.ejecutar(new Object[]{usuario.getNomUsuario(), usuario.getContra()});
        Object[] obj = BD.getObjet();
        if (obj != null) {
            frmIniciarSesion.setCedulaOficial((String) obj[0]);
            frmIniciarSesion.setNombreOficial((String) obj[1]);
            verificarTipoUsuario((String) obj[2], vistaPrincipal);
            JOptionPane.showMessageDialog(vistaSesion, "Sesion iniciada correctamente", "Iniciar Sesion", 1);
            vistaSesion.dispose();
        } else {
            JOptionPane.showMessageDialog(vistaSesion, "Error: Usuario o Contraseña Invalidos", "Error", 0);
        }
    }

    private void verificarTipoUsuario(String tipo, frmPrincipal vistaPrincipal) {
        if (tipo.equals("Oficial")) {
            vistaPrincipal.habilitarOfical();
        } else {
            vistaPrincipal.habilitarSecretario();
        }
    }

    public clsUsuarios editar(frmBuscarPersona vista, int indice) throws ErrorConexion {
        BD = new BaseDatos("SELECT * from tblUsuarios WHERE Cedula = ?");
        BD.ejecutar(new Object[]{vista.getPersonas().getValueAt(indice, 0).toString()});
        Object obj[] = BD.getObjet();
        usuario = new clsUsuarios(obj);
        return usuario;
    }

}
