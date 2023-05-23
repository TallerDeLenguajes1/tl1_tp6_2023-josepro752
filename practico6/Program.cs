// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

/////// Ejercicio 1 ///////

// int num, aux = 0;
// bool resultado;

// Console.WriteLine("Escriba un numero");
// resultado = int.TryParse(Console.ReadLine(), out num);
// if (resultado) {
//     if (num > 0) {
//         while (num != 0) {
//             aux = (aux * 10) + num%10;
//             num = num/10;
//         }
//         Console.WriteLine("El numero invertido es: "+aux);
//     }
// }

/////// Ejercicio 4 ///////

string? cadena, cadena2;
Console.WriteLine("Ingrese una frase o palabra:\n");
cadena = Console.ReadLine();
if (cadena != null) {
    Console.WriteLine("La longitud de: '"+cadena+"' es: "+cadena.Length);
}
Console.WriteLine("Ingrese una frase o palabra:\n");
cadena2 = Console.ReadLine();
if (cadena2 != null) {
    cadena = cadena + cadena2;
    Console.WriteLine("Las cadenas concatenadas son: "+cadena);
}
if (cadena != null) {
    Console.WriteLine(""+cadena.Substring(0,cadena.Length/2));
}