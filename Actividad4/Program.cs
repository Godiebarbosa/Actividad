class Program
{
    static void Main()
    {
        char operacion = '+';
        double num1 = 5.0;
        double num2 = 3.0;
        double resultado = 0.0;

        switch (operacion)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                resultado = num1 / num2;
                break;
            default:
                Console.WriteLine("Operación no válida.");
                return;
        }

        Console.WriteLine("El resultado es: " + resultado);
    }
}
