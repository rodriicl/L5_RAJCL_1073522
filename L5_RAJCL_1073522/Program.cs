int numeroEntero = 0;

Console.WriteLine("EJERCICIO 1");

Console.WriteLine("Numero Entero");


numeroEntero = Convert.ToInt32(Console.ReadLine());


if (numeroEntero >= 1)
{
    Console.WriteLine("Numero positivo ");

}
else if (numeroEntero <= -1)
{
    Console.WriteLine("Numero Negativo");
}
else if (numeroEntero == 0)
{
    Console.WriteLine("Numero es cero");
}