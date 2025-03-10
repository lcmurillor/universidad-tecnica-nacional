package conversion;
/**
 *
 * @author Yordan Meneses, Juan Varela y Luis Murillo.
 */
public class multiplicacion {

    /**
     * Método que se encarga de convertir un String binario en int decimal.
     * @param numero Coresponde a un valor dado en binario.
     * @return Un valor decimal.
     */
    public static int binarioDecimal(String numero) {
        int binario = 0, exp = numero.length() - 1;
        for (int i = 0; i < numero.length(); i++) {
            binario = (int) ((Integer.parseInt("" + numero.charAt(i)))) * (int) (Math.pow(2, exp)) + binario;
            exp--;
        }
        return binario;
    }

    /**
     * Método que permite convertir un dato octal a decima.
     * @param numero Es un String que coresponde a una cantidad en base 8.
     * @return El valor en decimal.
     */
    public static int octalDecimal(String numero) {
        int octal = 0, exp = numero.length() - 1;
            for (int i = 0; i < numero.length(); i++) {
                octal = (int) ((Integer.parseInt("" + numero.charAt(i)))) * (int) (Math.pow(8, exp)) + octal;
                exp--;
            }
        return octal;
    }

    /**
     * Método que perimete convetir un dato hexadecimal a un dato decimal.
     * @param numero Es un String que corresponde a un valor dado en
     * hexadecimal.
     * @return Un valor entero decimal.
     */
    public static int hexadecimalDecimal(String numero) {
        int hexadecimal = 0, exp = numero.length() - 1;
        for (int i = 0; i < numero.length(); i++) {
            switch (Character.toUpperCase(numero.charAt(i))) {
                case 'A':
                    hexadecimal = 10 * (int) (Math.pow(16, exp)) + hexadecimal;
                    break;
                case 'B':
                    hexadecimal = 11 * (int) (Math.pow(16, exp)) + hexadecimal;
                    break;
                case 'C':
                    hexadecimal = 12 * (int) (Math.pow(16, exp)) + hexadecimal;
                    break;
                case 'D':
                    hexadecimal = 13 * (int) (Math.pow(16, exp)) + hexadecimal;
                    break;
                case 'E':
                    hexadecimal = 14 * (int) (Math.pow(16, exp)) + hexadecimal;
                    break;
                case 'F':
                    hexadecimal = 15 * (int) (Math.pow(16, exp)) + hexadecimal;
                    break;
                default:
                    hexadecimal = (int) ((Integer.parseInt("" + numero.charAt(i)))) * (int) (Math.pow(16, exp)) + hexadecimal;
            }
            exp--;
        }
        return hexadecimal;
    }
}
