
package biblioteca;

public class Prestamo {
    private String codigo;
    private String id;
    private String fechaSalida;
    private String fechaRegreso;
    private int cuota;
    
    public void cuota(){
        
    }
    
    public void calcularFechaRegreso(int dias){
        int dia = Integer.parseInt(this.fechaSalida.substring(0, 2));
        int mes = Integer.parseInt(this.fechaSalida.substring(3, 5));
        int año =  Integer.parseInt(this.fechaSalida.substring(6, 10));
        dia += dias;
        do {
            if (dia > 30) {
                mes++;
                dia -= 30;
            }
            if (mes > 12) {
                año++;
                mes -= 12;
            }
        } while (dia > 30);
        this.fechaRegreso = dia+"/"+mes+"/"+año;
    }
    
    public int cuota(int dias){
        return this.cuota=dias*100;
    }
    
    public double calcularMulta(int dias){
        return dias*100+this.cuota*0.07;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }

    public void setFechaSalida(String fechaSalida) {
        this.fechaSalida = fechaSalida;
    }

    public String getFechaRegreso() {
        return fechaRegreso;
    }

 
    
    
}
