package metodos;


public class metodos {

    public static void main(String[] args) {
        System.out.println(contenido(lenguajes(),numero(lenguajes())));
    }
    
    /**
     * Realice un método de clase, publico, llamado aTexto que reciba 
     * como parámetro un carácter, convierta y retorne dicho valor en una cadena de texto.
     * @param x
     * @return 
     */
    public static String aTexto (Object x){
        return x.toString();
    }
    /**
     * Se desea calcular el volumen de un cilindro conociendo el diámetro (D) y la altura(H). Nota V=Pi*R2*H., 
     * para lo cual se le solicita desarrollar un subproceso que permita recibir los parámetros (con sus tipos de datos) 
     * adecuados y retornar el valor correspondiente.
     * @param d
     * @param h
     * @return 
     */
    public static double volumen (double d,double h){
        return Math.PI * Math.pow(d/2, 2)*h;
    }
    /**
     * Realice un subproceso en el cual declare, inicialice y retorne un arreglo que contenga los siguiente
     * lenguajes de programacion: Java, VB, C++, C char, JavaScript, PHP, ASP.
     * @return 
     */
    public static String[] lenguajes(){
        String [] leng = new String []{"Java", "VB", "C++", "C char", "JavaScript", "PHP", "ASP"};
        return leng;
    }
    /**
     * Realice un subproceso que reciba por parámetro el arreglo del ejercicio anterior y 
     * retorne un numero aleatorio según la cantidad de valores del arreglo.
     * @param vec
     * @return 
     */
    public static int numero (String[] vec){
        return (int) (Math.random()*(vec.length - 0)+0);
    }
    /**
     * Realice un subproceso que reciba por parámetro el arreglo creado anteriormente y utilizando el 
     * proceso anterior (que genera un valor aleatorio) retorne el contenido de uno de los espacios del 
     * vector de forma aleatoria.
     * @param vec
     * @param num
     * @return 
     */
    public static String contenido (String [] vec,int num ){
        return vec[num];
    }
}
