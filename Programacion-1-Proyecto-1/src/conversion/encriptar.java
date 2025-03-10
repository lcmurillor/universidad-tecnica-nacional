package conversion;
/**
 *
 * @author Yordan Meneses, Juan Varela y Luis Murillo.
 */
public class encriptar {
    /**
     * Metodo que recibe un dato alfanumerico y returna una dato encriptacion.
     * @param txt String una oracion alfanumerica
     * @return Strin un secuencia encriptada
     */
    public static String encriptar(String txt) {
        char vec[] = txt.toCharArray();
        for (int i = 0; i < vec.length; i++) {
            vec[i] = (char) (vec[i] + 8);
        }
        String preEncrip = String.valueOf(vec);
        String encrip = "";
        for (int i = 0; i < preEncrip.length(); i++) {
            encrip = encrip.concat(Character.toString(preEncrip.charAt(i))).concat(num());
        }        
        return encrip;
    }
    /**
     * Metodo que genera un numero areatorio entre 9 y 0. 
     * altera su valor cambiando la posicion del codigo ASCII.
     * @return Un valor aleatorio del codigo ASCII
     */
    private static String num() {
        int preNum = (int) (Math.random() * (57 - 48) + 48);
        return String.valueOf((char) (preNum - 3));
    }
    /**
     * Resive una cadena de caracteres encriptada y la vuelve a su orden original.
     * @param txt un String encriptado
     * @return String alfanumerico
     */
    public static String desEncriptar(String txt) {
        String desEncrip = "";
        for (int i = 0; i < txt.length(); i += 2) {
            desEncrip = desEncrip.concat(Character.toString(txt.charAt(i)));
        }
        char vec[] = desEncrip.toCharArray();
        for (int i = 0; i < vec.length; i++) {
            vec[i] = (char) (vec[i] - 8);
        }
        desEncrip = String.valueOf(vec);        
        return desEncrip;
    }
    /**
     * Metodo que genera contraseñas aleatorias. 
     * @return Un pin numerico de cuadro dijitos 
     */
    public static String generarPassw(){
        String x = "";
        for (int i = 0; i < 4; i++) {
            x = (char)(Math.random() * (57 - 48) + 48)+x;
        }
        return x;
    }
    
}
