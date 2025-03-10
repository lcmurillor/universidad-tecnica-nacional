package conversion;
/**
 *
 * @author Yordan Meneses, Juan Varela y Luis Murillo.
 */
public class morse {
    /**
     * Metodo de comvierte una cadena de texto en clave morse.
     * @param txt Es un String qeu corresponde a una entrad de texto
     * @return  Clave Morse
     */
    public static String textoAMorse(String txt) {
        txt = txt.toLowerCase();
        txt = txt.replace("a", " .- ");
        txt = txt.replace("b", " -... ");
        txt = txt.replace("c", " -.-. ");
        txt = txt.replace("d", " -.. ");
        txt = txt.replace("e", " . ");
        txt = txt.replace("f", " ..-. ");
        txt = txt.replace("g", " --. ");
        txt = txt.replace("h", " .... ");
        txt = txt.replace("i", " .. ");

        txt = txt.replace("j", " .--- ");
        txt = txt.replace("k", " -.- ");
        txt = txt.replace("l", " .-.. ");
        txt = txt.replace("m", " -- ");
        txt = txt.replace("n", " -. ");
        txt = txt.replace("o", " --- ");
        txt = txt.replace("p", " .--. ");
        txt = txt.replace("q", " --.- ");
        txt = txt.replace("r", " .-. ");

        txt = txt.replace("s", " ... ");
        txt = txt.replace("t", " - ");
        txt = txt.replace("u", " ..- ");
        txt = txt.replace("v", " ...- ");
        txt = txt.replace("w", " .-- ");
        txt = txt.replace("x", " -..- ");
        txt = txt.replace("y", " -.-- ");
        txt = txt.replace("z", " --.. ");

        txt = txt.replace("1", " .---- ");
        txt = txt.replace("2", " ..--- ");
        txt = txt.replace("3", " ...-- ");
        txt = txt.replace("4", " ....- ");
        txt = txt.replace("5", " ..... ");
        txt = txt.replace("6", " -.... ");
        txt = txt.replace("7", " --... ");
        txt = txt.replace("8", " ---.. ");
        txt = txt.replace("9", " ----. ");
        txt = txt.replace("0", " ----- ");
        return txt;
    }
    /**
     * Metodo que resive un dato morse y lo convierte en alfanumerico
     * @param mor un String en formato morse
     * @return un Strin con el mensaje en formato alfanumerico
     */
    public static String morseATexto (String mor){
        mor = " "+mor+" ";
        mor = mor.replace(" .- ", "a");
        mor = mor.replace(" -... ", "b");
        mor = mor.replace(" -.-. ", "c");
        mor = mor.replace(" -.. ", "d");
        mor = mor.replace(" . ", "e");
        mor = mor.replace(" ..-. ", "f");
        mor = mor.replace(" --. ", "g");
        mor = mor.replace(" .... ", "h");
        mor = mor.replace(" .. ", "i");
        
        mor = mor.replace(" .--- ", "j");
        mor = mor.replace(" -.- ", "k");
        mor = mor.replace(" .-.. ", "l");
        mor = mor.replace(" -- ", "m");
        mor = mor.replace(" -. ", "n");
        mor = mor.replace(" --- ", "o");
        mor = mor.replace(" .--. ", "p");
        mor = mor.replace(" --.- ", "q");
        mor = mor.replace(" .-. ", "r");
        
        mor = mor.replace(" ... ", "s");
        mor = mor.replace(" - ", "t");
        mor = mor.replace(" ..- ", "u");
        mor = mor.replace(" ...- ", "v");
        mor = mor.replace(" .-- ", "w");
        mor = mor.replace(" -..- ", "x");
        mor = mor.replace(" -.-- ", "z");
        
        mor = mor.replace(" .---- ", "1");
        mor = mor.replace(" ..--- ", "2");
        mor = mor.replace(" ...-- ", "3");
        mor = mor.replace(" ....- ", "4");
        mor = mor.replace(" ..... ", "5");
        mor = mor.replace(" -.... ", "6");
        mor = mor.replace(" --... ", "7");
        mor = mor.replace(" ---.. ", "8");
        mor = mor.replace(" ----. ", "9");
        mor = mor.replace(" ----- ", "0");
        return mor;
    }
    
}
