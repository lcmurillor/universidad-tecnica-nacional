package Utilidades;

public class Carton extends Bingo {

    public String codigo;
    private int f;
    private int c;

    public Carton() {
        this.f = 0;
        this.c = 0;
        this.codigo = "0";
        this.matrizEnteraEn0();
        this.matrizBooleanEnFalse();
    }

    private void matrizEnteraEn0() {
        for (int f = 0; f < 5; f++) {
            for (int c = 0; c < 5; c++) {
                this.matrizEntera[f][c] = 0;
            }
        }
    }

    public void matrizBooleanEnFalse() {
        for (int f = 0; f < 5; f++) {
            for (int c = 0; c < 5; c++) {
                this.matrizBooleana[f][c] = false;
            }
        }
        this.matrizBooleana[2][2] = true;
    }


    public void cerrar() {
        this.f = 0;
        this.c = 0;
        this.codigo = "0";
        this.matrizEnteraEn0();
        this.matrizBooleanEnFalse();
    }

    public void cargarBingo(int num) {
        if (this.esValidoEnMatriz(num) && this.esValidoEnColumna(num)) {
            this.cargarMatriz(num, f, c);
            f++;
            if (f == 5) {
                c++;
                f = 0;
            } else if (f == 2 && c == 2) {
                f++;
            }
        }
    }

    private void cargarMatriz(int num, int f, int c) {
        switch (c) {
            case 0:
                this.cargarMatrizPasoA(num, f);
                break;
            case 1:
                this.cargarMatrizPasoB(num, f);
                break;
            case 2:
                this.cargarMatrizPasoC(num, f);
                break;
            case 3:
                this.cargarMatrizPasoD(num, f);
                break;
            case 4:
                this.cargarMatrizPasoE(num, f);
                break;
            default:
                break;
        }
    }

    private void cargarMatrizPasoA(int num, int f) {
        if (num >= 1 && num <= 15) {
            this.matrizEntera[f][0] = num;
        }
    }

    private void cargarMatrizPasoB(int num, int f) {
        if (num >= 16 && num <= 30) {
            this.matrizEntera[f][1] = num;
        }
    }

    private void cargarMatrizPasoC(int num, int f) {
        if (num >= 31 && num <= 45) {
            this.matrizEntera[f][2] = num;
        }
    }

    private void cargarMatrizPasoD(int num, int f) {
        if (num >= 46 && num <= 60) {
            this.matrizEntera[f][3] = num;
        }
    }

    private void cargarMatrizPasoE(int num, int f) {
        if (num >= 61 && num <= 75) {
            this.matrizEntera[f][4] = num;
        }
    }

    public void cargarMatrizBTrue(int f, int c) {
        this.matrizBooleana[f][c] = true;
    }
    public void cargarMatrizBFalse(int f, int c) {
        this.matrizBooleana[f][c] = false;
    }
    
    

    public boolean esValidoEnMatriz(int num) {
        boolean ban = true;
        for (int f = 0; f < this.matrizEntera.length; f++) {
            for (int c = 0; c < this.matrizEntera.length; c++) {
                if (this.matrizEntera[f][c] == num) {
                    ban = false;
                }
            }
        }
        return ban;
    }

    public boolean esValidoEnColumna(int num) {
        boolean ban = false;
        switch (c) {
            case 0:
                if (num >= 1 && num <= 15) {
                    ban = true;
                }
                break;
            case 1:
                if (num >= 16 && num <= 30) {
                    ban = true;
                }
                break;
            case 2:
                if (num >= 31 && num <= 45) {
                    ban = true;
                }
                break;
            case 3:
                if (num >= 46 && num <= 60) {
                    ban = true;
                }
                break;
            case 4:
                if (num >= 61 && num <= 75) {
                    ban = true;
                }
                break;

        }
        return ban;
    }

    public String getCodigo() {
        return codigo;
    }

    public void matrizToString() {
        for (int f = 0; f < this.matrizEntera.length; f++) {
            for (int c = 0; c < this.matrizEntera.length; c++) {
                System.out.print(this.matrizEntera[f][c] + " ");

            }
            System.out.println(" ");
        }
    }

    public void setCodigo(String codigo) {
        if (codigo.length() <= 5) {
            this.codigo = codigo;
        }
    }

    public int getF() {
        return f;
    }

    public int getC() {
        return c;
    }

}
