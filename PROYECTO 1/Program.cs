//Ejercicio 1.

using System;
long num3, num4, suma, resta, mul;
byte edad, num1, num2;
ushort producto;

Console.WriteLine("Cual es tu edad?");
edad = Convert.ToByte(Console.ReadLine());
Console.WriteLine("No aparentas tener: " + edad + " Años.\n\n");


//ejercicio 2.

Console.WriteLine("ingrese dos numero de dos digitos para obtener su producto\n");
Console.WriteLine("num1");
num1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("num2");
num2 = Convert.ToByte(Console.ReadLine());
producto = Convert.ToUInt16((num1 * num2));
Console.WriteLine("el producto es: " + producto + "\n\n\n");


//ejercicio 3.

Console.WriteLine("ingrese dos numeros enteros largos para \n");
Console.WriteLine("num3");
num3 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("num4");
num4 = Convert.ToInt64(Console.ReadLine());
suma = num3 + num4;
resta = num3 - num4;
mul = num3 * num4;
Console.WriteLine("La suma es: " + suma + "\n");
Console.WriteLine("La resta es: " + resta + "\n");
Console.WriteLine("El producto es: " + mul + "\n\n");

Console.WriteLine("tenga buen dia:) \n\n");


