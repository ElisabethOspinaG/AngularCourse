namespace EjercicioWebAppi.Services
{
    public class CalculatorService
    {
        public int sumar(int num1, int num2)
        {
                    var suma = num1 + num2;
                    return suma;
        }
        public int restar(int num1, int num2)
        {

            var resta = num1 - num2;
            return resta;

        }
        public int multiplicar(int num1, int num2)
        {

            var multiplicacion = num1 * num2;
            return multiplicacion;
            ;

        }
        public int dividir(int num1, int num2)
        {

            var division = num1 * num2;
            return division;
            ;

        }

    }
}
