
package biblioteca;

public class Libro extends Material{
    private String editorial;
    
    public void altaMaterial(){
        this.setStatus("Activo");
    }
    public void bajaMaterial(){
        this.setStatus("Inactivo");
    }
    public void cambioMaterial(){
        this.setStatus("Activo o reparacion");
    }

    public String getEditorial() {
        return editorial;
    }

    public void setEditorial(String editorial) {
        this.editorial = editorial;
    }
    
    
}
