// Pregunta Parcial 2

int datol = 16;
string dato2 = "25g";

try
{
    int resultado = datol + Convert.ToInt32(dato2);
    Console.WriteLine(resultado);
}
catch (Exception)
{
    Console.WriteLine("Error, no se pudo realizar corectamente la operacion que solicito");
}
