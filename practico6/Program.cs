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
bool resultado;
int opcion, num1, num2, num3 = 1;
string[] datos;
char operador = '-';
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
    Console.WriteLine("Una subcadena de "+cadena+" es "+cadena.Substring(0,cadena.Length/2));
}
Console.WriteLine("Seleccione la operacion que desea realizar");
Console.WriteLine("1_Suma");
Console.WriteLine("2_Resta");
Console.WriteLine("3_Mulitplicacion");
Console.WriteLine("4_Division");
resultado = int.TryParse(Console.ReadLine(), out opcion);
if (resultado) {
    if (opcion > 0 && opcion < 5) {
        Console.WriteLine("Escriba el primer numero a operar");
        resultado = int.TryParse(Console.ReadLine(), out num1);
        if (resultado) {
            Console.WriteLine("Escriba el segundo numero a operar");
            resultado = int.TryParse(Console.ReadLine(), out num2);
            if (resultado) {
                switch(opcion) {
                    case 1:
                        num3 = num1 + num2;
                        Console.WriteLine("La suma de "+num1+" mas "+num2+ " es igual a: "+num3);
                    break;
                    case 2:
                        num3 = num1 - num2;
                        Console.WriteLine("La resta de "+num1+" menos "+num2+ " es igual a: "+num3);
                    break;
                    case 3:
                        num3 = num1 * num2;
                        Console.WriteLine("La multiplicacion de "+num1+" por "+num2+ " es igual a: "+num3);
                    break;
                    case 4:
                        num3 = num1/num2;
                        Console.WriteLine("La division de "+num1+" entre "+num2+ " es igual a: "+num3);
                    break;
                }
            } else {
                Console.WriteLine("No se ingresaron numeros");
            }
        } else {
            Console.WriteLine("No se ingresaron numeros");
        }
    }
}  else {
    Console.WriteLine("Numero de operacion ingresado no valido");
}
foreach (char c in cadena) {
    Console.WriteLine(c);
}
Console.WriteLine("Ingrese una palabra para saber su ocurrencia en la cadena anterior");
cadena2 = Console.ReadLine();
if (cadena.IndexOf(cadena2) == -1) {
    Console.WriteLine("La palabra NO se encuentra en la cadena");
} else {
    Console.WriteLine("La palabra SI se encuentra en la cadena");
}
Console.WriteLine("La cadena en mayusculas es: "+cadena.ToUpper());
Console.WriteLine("La cadena en minusculas es: "+cadena.ToLower());
Console.WriteLine("Ingrese su nombre, DNI y fecha de nacimiento. Todo separado por ';'");
cadena2 = Console.ReadLine();
datos = cadena2.Split(';');
Console.WriteLine("Su Nombre es: "+datos[0]);
Console.WriteLine("Su DNI es: "+datos[1]);
Console.WriteLine("Su Fecha de Nacimiento es: "+datos[2]);
Console.WriteLine("Ingrese la operacion");
cadena = Console.ReadLine();
foreach (char c in cadena) {
    if (c == '+' || c == '-' || c == '/' || c == '*') {
        operador = c;
    }
}
datos = cadena.Split(operador);
int.TryParse(datos[0], out num1);
int.TryParse(datos[1], out num2);
switch (operador) {
    case '+':
        num3 = num1 + num2;
    break;
    case '-':
        num3 = num1 - num2;
    break;
    case '*':
        num3 = num1 * num2;
    break;
    case '/':
        num3 = num1 / num2;
    break;
}
Console.WriteLine("La respuesta: "+num3);