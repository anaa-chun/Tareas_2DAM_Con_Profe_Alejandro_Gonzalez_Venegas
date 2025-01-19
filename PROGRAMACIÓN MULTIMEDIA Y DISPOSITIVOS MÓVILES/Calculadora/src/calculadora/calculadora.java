package calculadora;

import java.util.InputMismatchException;
import java.util.Scanner;

public class calculadora {
	/**
	 * @Alumna: Ana Chun Gómez de Castro 2ºDAM
	 */

	public static void main(String[] args) {
		Scanner sr = new Scanner(System.in);
		int operaciones = 0;

		do {
			int num1 = 0;
			int num2 = 0;
			boolean entrada;

			do {
				System.out.println("Dime el primer número: ");
				try {
					num1 = sr.nextInt();
					entrada = true;
				} catch (InputMismatchException e) {
					System.out.println("Error: Solo puedes introducir un número válido.");
					sr.next();
					entrada = false;
				}
			} while (!entrada);

			do {
				System.out.println("Dime el segundo número: ");
				try {
					num2 = sr.nextInt();
					entrada = true;
				} catch (InputMismatchException e) {
					System.out.println("Error: Solo puedes introducir un número válido.");
					sr.next();
					entrada = false;
				}
			} while (!entrada);

			System.out.println();
			System.out.println("OPERACIONES MATEMÁTICAS");
			System.out.println(
					"1. Suma" + "\n2. Resta" + "\n3. Multiplicación" + "\n4. División" + "\n5. Salir del programa");
			System.out.println("**************************");
			System.out.println("Elija una operación: ");

			try {
				operaciones = sr.nextInt();
			} catch (InputMismatchException e) {
				System.out.println("Error: Introduce un número válido del 1 al 5.");
				sr.next();
			}

			switch (operaciones) {
			case 1:
				// Suma
				System.out.println("Suma: " + num1 + " + " + num2 + " = " + (num1 + num2));
				break;
			case 2:
				// Resta
				System.out.println("Resta: " + num1 + " - " + num2 + " = " + (num1 - num2));
				break;
			case 3:
				// Multiplicación
				System.out.println("Multiplicación: " + num1 + " * " + num2 + " = " + (num1 * num2));
				break;
			case 4:
				// División
				if (num2 != 0) {
					System.out.println("División: " + num1 + " ÷ " + num2 + " = " + (num1 / num2));
				} else {
					System.out.println("Error: No se puede dividir por cero.");
				}
				break;
			case 5:
				// Despedida
				System.out.println("¡Hasta luego! 🥰");
				break;
			default:
				System.out.println("Opción inválida. Por favor, elige un número del 1 al 5.");
				break;
			}

			System.out.println(); // Es para que haya espacio cuando se muestre los resultados de las operaciones

		} while (operaciones != 5);
		sr.close();
	}
}
