package Utilidades;

public class tipoDeJuego extends Bingo {

    public static boolean cartonEsquinas(boolean[][] mat) {
        boolean ban = false;
        if (mat[0][0] == true && mat[0][4] == true && mat[4][0] == true && mat[4][4] == true) {
            ban = true;
        }
        return ban;
    }

    public  static  boolean cartonLleno(boolean[][] mat) {
        boolean ban = false;
        int con = 0;
        for (int f = 0; f < 5; f++) {
            for (int c = 0; c < 5; c++) {
                if (mat[f][c] == true) {
                    con++;
                }
            }
        }
        if (con > 24) {
            ban = true;
        }

        return ban;
    }

    public static  boolean cartonDiagonal(boolean[][] mat) {
        boolean ban = false;
            if (mat[0][0] == true && mat[1][1] == true && mat[2][2] == true && mat[3][3] == true && mat[4][4] == true) {
                ban = true;
            }
            if (mat[0][4] == true && mat[1][3] == true && mat[2][2] == true && mat[3][1] == true && mat[4][0] == true) {
             ban = true;
        }
        return ban;
    }

    public static  boolean cartonHorizontal(boolean[][] mat) {
        boolean ban = false;
        for (int i = 0; i < 5; i++) {
            if (mat[i][0] == true && mat[i][1] == true && mat[i][2] == true && mat[i][3] == true && mat[i][4] == true) {
                ban = true;
            }
        }
        return ban;
    }

    public static  boolean cartonVertical(boolean[][] mat) {
        boolean ban = false;
        for (int i = 0; i < 5; i++) {
            if (mat[0][i] == true && mat[1][i] == true && mat[2][i] == true && mat[3][i] == true && mat[4][i] == true) {
                ban = true;
            }
        }
        return ban;
    }

}
