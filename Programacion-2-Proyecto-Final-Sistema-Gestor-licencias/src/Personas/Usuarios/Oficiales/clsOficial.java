package Personas.Usuarios.Oficiales;

import Personas.Usuarios.clsUsuarios;

public class clsOficial extends clsUsuarios {

    private double salario;

    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        if (salario > 0) {
            this.salario = salario;
        }
    }

    public clsOficial(String cedula, String nombre, String correo, String telefono, String fecha, String nomUsuario, String contra, String tipoUsuario) {
        super(cedula, nombre, correo, telefono, fecha, nomUsuario, contra, tipoUsuario);
    }

    public clsOficial(String cedula, String nombre, String fechaNac, String telefono, String correo, double salario) {
        super(cedula, nombre, fechaNac, telefono, correo);
        this.salario = salario;
    }

    public clsOficial(Object[] obj) {
        super((String) obj[0], (String) obj[1], (String) obj[2], (String) obj[3], (String) obj[4]);
        this.salario = (double) obj[5];
    }

    public clsOficial() {
    }

    public double calcularDeducEnfMat() {
        return salario * 0.055;
    }

    public double calcularDeducInvaMuer() {
        return (double)Math.round((salario * 0.0384) * 100d) / 100d;
    }

    public double calcularDeducAporTrab() {
        return (double)Math.round((salario * 0.01) * 100d) / 100d;
    }

    public double calcularDeducAsocSoli() {
        return (double)Math.round((salario * 0.033) * 100d) / 100d;
    }

    public double calcularDeducImpRenta() {
        if (salario > 817000 && salario <= 1226000) {
            return (double)Math.round((salario * 0.01) * 100d) / 100d;
        } else if (salario > 1226000) {
            return (double)Math.round((salario * 0.15) * 100d) / 100d;
        } else {
            return 0;
        }
    }

    public double calcularsalarioNeto() {
        return salario -= (calcularDeducInvaMuer() + calcularDeducImpRenta() + calcularDeducEnfMat() + calcularDeducAsocSoli() + calcularDeducAporTrab());
    }
    
}
