using System.ComponentModel.Design;

double n1, n2;

Console.WriteLine(" INGRESA EL PRIMER NUMERO ");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine(" INGRESA EL SEGUNDO NUMERO ");
n2 = double.Parse(Console.ReadLine());

if (n1 > n2)
{
    double suma = n1 + n2;
    double resta = n1 - n2;

    Console.WriteLine(" LA SUMA ES : " + suma);
    Console.WriteLine(" LA RESTA ES : " + resta);
}
else
{
    double pro = n1 * n2;
    double divi = (n2 != 0) ? n1 / n2 : 1;
    Console.WriteLine(" EL PRODUCTO ES : " + pro);
    Console.WriteLine(" LA DIVISION ES : " + divi);
}