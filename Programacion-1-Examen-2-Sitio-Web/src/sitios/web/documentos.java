
package sitios.web;

public class documentos extends sitios.web.striosWeb{
       private String[] documentos[];
       private int indice;
       private int tamaño;
       
       
       public documentos(String documeto, int indice){
           String[] documento = this.documentos[indice];
           
       }

       
    public String[][] getDocumentos() {
        return documentos;
    }

    public void setDocumentos(String[][] documentos) {
        this.documentos = documentos;
    }

    public int getIndice() {
        return indice;
    }

    public void setIndice(int indice) {
        this.indice = indice;
    }

    public void setTamaño(int tamaño) {
        this.tamaño = tamaño;
    }
       
       @Override
    public String toString(){
     return "El docuemton es: "+ this.documentos;   
    }
       
}
