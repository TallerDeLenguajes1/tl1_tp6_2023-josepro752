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

/////// Ejercicio 2 ///////

bool resp = true, resultado;
int operacion = 1, opcion, num1, num2;
Console.WriteLine("------CalculadoraV1-------");
while (resp) {
    Console.WriteLine("---Operacion N"+operacion+"---");
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
                            num1 = num1 + num2;
                        break;
                        case 2:
                            num1 = num1 - num2;
                        break;
                        case 3:
                            num1 = num1 * num2;
                        break;
                        case 4:
                            num1 = num1/num2;
                        break;
                    }
                    Console.WriteLine("Resultado: "+num1);
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
    Console.WriteLine("Desea realizar otra operacion (SI:1/NO:0)");
    resultado = int.TryParse(Console.ReadLine(), out num1);
    if (resultado) {
        if (num1 == 0) {
            resp = false;
        }
    }
    operacion++;
}