// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

/////// Ejercicio 1 ///////

// int num1, aux = 0;
// bool resultado;

// Console.WriteLine("Escriba un numero");
// resultado = int.TryParse(Console.ReadLine(), out num1);
// if (resultado) {
//     if (num1 > 0) {
//         while (num1 != 0) {
//             aux = (aux * 10) + num1%10;
//             num1 = num1/10;
//         }
//         Console.WriteLine("El numero invertido es: "+aux);
//     }
// }

/////// Ejercicio 2 ///////

// bool resp = true, resultado;
// int operacion = 1, opcion, num1, num2;
// Console.WriteLine("------CalculadoraV1-------");
// while (resp) {
//     Console.WriteLine("---Operacion N"+operacion+"---");
//     Console.WriteLine("Seleccione la operacion que desea realizar");
//     Console.WriteLine("1_Suma");
//     Console.WriteLine("2_Resta");
//     Console.WriteLine("3_Mulitplicacion");
//     Console.WriteLine("4_Division");
//     resultado = int.TryParse(Console.ReadLine(), out opcion);
//     if (resultado) {
//         if (opcion > 0 && opcion < 5) {
//             Console.WriteLine("Escriba el primer numero a operar");
//             resultado = int.TryParse(Console.ReadLine(), out num1);
//             if (resultado) {
//                 Console.WriteLine("Escriba el segundo numero a operar");
//                 resultado = int.TryParse(Console.ReadLine(), out num2);
//                 if (resultado) {
//                     switch(opcion) {
//                         case 1:
//                             num1 = num1 + num2;
//                         break;
//                         case 2:
//                             num1 = num1 - num2;
//                         break;
//                         case 3:
//                             num1 = num1 * num2;
//                         break;
//                         case 4:
//                             num1 = num1/num2;
//                         break;
//                     }
//                     Console.WriteLine("Resultado: "+num1);
//                 } else {
//                     Console.WriteLine("No se ingresaron numeros");
//                 }
//             } else {
//                 Console.WriteLine("No se ingresaron numeros");
//             }
//         }
//     }  else {
//         Console.WriteLine("Numero de operacion ingresado no valido");
//     }
//     Console.WriteLine("Desea realizar otra operacion (SI:1/NO:0)");
//     resultado = int.TryParse(Console.ReadLine(), out num1);
//     if (resultado) {
//         if (num1 == 0) {
//             resp = false;
//         }
//     }
//     operacion++;
// }

/////// Ejercicio 3 ///////

bool resp = true, resultado;
int operacion = 1, opcion;
float num1, num2;
Console.WriteLine("------CalculadoraV2-------");
while (resp) {
    Console.WriteLine("Escriba un numero");
    resultado = float.TryParse(Console.ReadLine(), out num1);
    if (resultado) {
        Console.WriteLine("El valor absoluto del numero es: "+Math.Abs(num1));
        Console.WriteLine("El cuadrado del numero es: "+num1*num1);
        Console.WriteLine("La raiz cuadrada del numero es: "+Math.Sqrt(num1));
        Console.WriteLine("El seno del numero es: "+Math.Sin(num1));
        Console.WriteLine("El coseno del numero es: "+Math.Cos(num1));
        Console.WriteLine("La parte entera del numero es: "+Math.Truncate(num1));
    } else {
        Console.WriteLine("No se ingresaron numeros");
    }
    Console.WriteLine("Escriba un numero");
    resultado = float.TryParse(Console.ReadLine(), out num1);
    if (resultado) {
        Console.WriteLine("Escriba otro numero");
        resultado = float.TryParse(Console.ReadLine(), out num2);
        if (resultado) {
            if (num1 < num2) {
                Console.WriteLine("El mayor numero es: "+num2);
                Console.WriteLine("El menor numero es: "+num1);
            } else {
                Console.WriteLine("El mayor numero es: "+num1);
                Console.WriteLine("El menor numero es: "+num2);        
            }
        } else {
            Console.WriteLine("No se ingresaron numeros");
        }
    } else {
        Console.WriteLine("No se ingresaron numeros");
    }
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
            resultado = float.TryParse(Console.ReadLine(), out num1);
            if (resultado) {
                Console.WriteLine("Escriba el segundo numero a operar");
                resultado = float.TryParse(Console.ReadLine(), out num2);
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
    resultado = float.TryParse(Console.ReadLine(), out num1);
    if (resultado) {
        if (num1 == 0) {
            resp = false;
        }
    }
    operacion++;
}



