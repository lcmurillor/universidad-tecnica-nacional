
package biblioteca;

import java.util.ArrayList;

public class Biblitoca{
    
    ArrayList<Material> materiales = new ArrayList<>();
    
    
    public void agregar( Material material){
        this.materiales.add(material);
        
    }
    public void eliminar(Material material){
        this.materiales.remove(material);
    }
    
    
    
    public void cargarMateriales(){
        
    }
    public void cargarPersonas(){
        
    }
}
