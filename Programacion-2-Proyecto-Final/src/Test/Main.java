package Test;

import BaseDeDatos.BaseDatos;
import Errores.ErrorConexion;

public class Main {

    public static void main(String[] args) {
//        VistaCliente vc = new VistaCliente();
//        vc.setCedula("501470258");
//        vc.setNombre("Clinete");
//        vc.setFecha("10/12/2000");
//        vc.setTelefono("84858687");
//        vc.setCorreo("cliente@gmail.com");
//        System.out.println(vc.toString());
//        ControladorClientes cc = new ControladorClientes(vc);
//        cc.agregar();
        try {
            BaseDatos bd = new BaseDatos();
        } catch (ErrorConexion ex) {
            System.out.println(ex.getMessage());
        }
    }
}
