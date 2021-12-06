
namespace ConsolePrimeiro
{
    internal class Quartos
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public int numero { get; set; }

        //---------------PARAMS----------------------------------
        //recebe uma quantidade variável de parametros
        public static int Sum(params int[] numbers) 
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];

            }
            return sum;
        }

        

    }
}
