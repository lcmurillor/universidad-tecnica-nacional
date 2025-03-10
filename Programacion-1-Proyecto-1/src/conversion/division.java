package conversion;
/**
 *
 * @author Yordan Meneses, Juan Varela y Luis Murillo.
 */
public class division {

    /**
     *Conversión de decimal a binario.
     * @param numero Es el número en base 10 que se va a convertir a base 2.
     * @return El valor en binario.
     */
    public static String binario(int numero) {
        String binario = "";
            if (numero > 0) {
                while (numero > 0) {
                    if (numero % 2 == 0) {
                        binario = "0" + binario;
                    } else {
                        binario = "1" + binario;
                    }
                    numero = (int) numero / 2;
                }
            } else if (numero == 0) {
                binario = "0";
            }
        return binario;
    }

    /**
     * Método que resive un valor decimal y retorna un valor octal.
     * @param numero Es el número en base 10.
     * @return El valor en octal.
     */
    public static String octal(int numero) {
        String octal = "";
            if (numero > 0) {
                while (numero > 0) {
                    octal = String.valueOf(numero % 8) + octal;
                    numero = (int) numero / 8;
                }
            } else if (numero == 0) {
                octal = "0";
            }
        return octal;
    }

    /**
     * Método que resive un valor decimal y retorna un valor hexadecimal.
     * @param numero Es el número en base 10.
     * @return El valor en hexadecimal.
     */
    public static String hexadecimal(int numero) {
        String Hexadecimal = "";
            if (numero > 0) {
                while (numero > 0) {
                    Hexadecimal = String.valueOf(numero % 16) + Hexadecimal;
                    Hexadecimal = Hexadecimal.replace("10", "A");
                    Hexadecimal = Hexadecimal.replace("11", "B");
                    Hexadecimal = Hexadecimal.replace("12", "C");
                    Hexadecimal = Hexadecimal.replace("13", "D");
                    Hexadecimal = Hexadecimal.replace("14", "E");
                    Hexadecimal = Hexadecimal.replace("15", "F");
                    numero = (int) numero / 16;
                }
            } else if (numero == 0) {
                Hexadecimal = "0";
            }
        return Hexadecimal;
    }

}
