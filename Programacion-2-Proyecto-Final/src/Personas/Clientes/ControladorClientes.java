package Personas.Clientes;

import BaseDeDatos.BaseDatos;
import Errores.ErrorConexion;
import Utilidades.CRUD;

public class ControladorClientes implements CRUD {

    private ModeloClientes cliente;
    private BaseDatos BD;
    private VistaClientes vista;

    public ControladorClientes(VistaClientes vista) {
        this.vista = vista;
    }
    
    @Override
    public void agregar() throws ErrorConexion {
        BD = new BaseDatos("INSERT INTO tblclientes VALUES (?,?,?,?,?)");
        cliente = new ModeloClientes(vista.getCedula(), vista.getNombre(), vista.getTelefono(), vista.getCorreo(), vista.getFecha());
        BD.ejecutar(new Object[]{cliente.getCedula(), cliente.getNombre(), cliente.getFechaNac(), cliente.getTelefono(), cliente.getCorreo()});

    }

    @Override
    public void eliminar() throws ErrorConexion {
        cliente = new ModeloClientes();
        cliente.setCedula(vista.getCedula());
        BD = new BaseDatos("DELETE FROM tblclientes WHERE Cedula =" + cliente.getCedula());
        BD.ejecutar();
    }
    
    @Override
    public void leer() throws ErrorConexion {
        cliente = new ModeloClientes();
        cliente.setCedula(vista.getCedula());
        BD = new BaseDatos("SELECT * FROM tblclientes WHERE Cedula =" + cliente.getCedula());
        BD.ejecutar();
    }

    @Override
    public void modificar() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

}
