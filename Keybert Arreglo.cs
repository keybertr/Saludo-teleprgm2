using System; 
class MainClass {
  public static void Main (string[] args) {
		// Nuestro arreglo
		double[] valores = {90, 98, 85, 95, 90, 80, 70, 100, 55};
		// Vamos a almacenar la sumatoria
		double sumatoria = 0;
		// Lo recorremos con un foreach
		foreach(double valor in valores){
			// Ir agregando el valor a la sumatoria
			sumatoria += valor;
		}
		// la media resulta de dividir la sumatoria entre la cantidad de elementos
		double media = sumatoria / valores.Length;
    Console.WriteLine(" La Media de los Valores es: " + media);
  }
}