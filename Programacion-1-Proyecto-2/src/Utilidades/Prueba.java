package Utilidades;

import java.util.Scanner;

public class Prueba {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Carton misCartones[] = new Carton[1];
        misCartones[0] = new Carton();
        do {
            int n = scanner.nextInt();
            misCartones[0].cargarBingo(n);
            misCartones[0].matrizToString();
        } while (true);

    }

}
