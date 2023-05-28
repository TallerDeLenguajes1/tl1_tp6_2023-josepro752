# tl1_tp6_2023-josepro752
tl1_tp6_2023-josepro752 created by GitHub Classroom
## ¿String es una tipo por valor o un tipo por referencia?
En C#, el tipo string es un tipo por referencia. Esto significa que cuando se crea una variable de tipo string, en realidad se crea un objeto en la memoria que almacena el valor del texto. La variable de tipo string actúa como una referencia a ese objeto en la memoria.
Cuando se asigna una cadena a una variable de tipo string, la variable hace referencia al objeto que contiene la cadena. Si se asigna otra cadena a la misma variable, la variable se actualizará para hacer referencia al nuevo objeto que contiene la nueva cadena.
## ¿Qué secuencias de escape tiene el tipo string?
El tipo string en C# admite varias secuencias de escape que se utilizan para representar caracteres especiales dentro de una cadena. Estas secuencias de escape se componen de un carácter de escape precedido por el símbolo "". A continuación se muestra una lista de las secuencias de escape más comunes en C#:
#### '\"': Representa una comilla doble (").
#### '\'': Representa una comilla simple (').
#### '\\': Representa un carácter de barra invertida ().
#### '\n': Representa un salto de línea.
#### '\r': Representa un retorno de carro.
#### '\t': Representa un tabulador horizontal.
#### '\b': Representa un retroceso (backspace).
#### '\f': Representa un avance de página (form feed).
#### '\v': Representa un tabulador vertical.
#### '\0': Representa el carácter nulo.
#### '\uXXXX': Representa un carácter Unicode especificado por el valor hexadecimal XXXX.
#### '\xXX': Representa un carácter Unicode especificado por el valor hexadecimal XX.
Estas secuencias de escape son útiles para incluir caracteres especiales en una cadena, como comillas, caracteres de control o caracteres Unicode, sin interferir con la sintaxis de la propia cadena.
## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
Cuando se utiliza el carácter @ antes de una cadena de texto en C#, se indica que se trata de una cadena de texto literal, lo que significa que los caracteres de escape no se interpretan en esa cadena. Esto se conoce como una cadena de texto verbatim.

Al utilizar una cadena de texto literal con el carácter @, los caracteres de escape, como '\n', '\t', '\"', etc., se tratan como caracteres normales en lugar de secuencias de escape. Esto es útil cuando se desea incluir una cadena que contiene muchas barras invertidas o caracteres de escape, como en expresiones regulares, rutas de archivo o código fuente.

Por otro lado, cuando se utiliza el carácter '$' antes de una cadena de texto en C#, se indica que se trata de una cadena de texto interpolada. Esto permite incrustar expresiones dentro de la cadena de texto utilizando la sintaxis '{}'. Las expresiones dentro de las llaves son evaluadas y sus resultados se insertan en la cadena en tiempo de ejecución.
