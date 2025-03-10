
package biblioteca;

public class Revista extends Material{
    public void altaMaterial(){
        this.setStatus("Activo");
    }
    public void bajaMaterial(){
        this.setStatus("Inactivo");
    }
    public void cambioMaterial(){
        this.setStatus("Activo o reparacion");
    }

}
