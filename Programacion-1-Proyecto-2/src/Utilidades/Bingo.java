
package Utilidades;
public abstract class Bingo {
    public  int matrizEntera[][] = new int[5][5];
    public  boolean matrizBooleana[][] = new boolean[5][5];

    public int[][] getMatrizEntera() {
        return matrizEntera;
    }

    public boolean[][] getMatrizBoolean() {
        return matrizBooleana;
    }

}
