using System;


namespace AnaliseCombinatoria
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Para saber  de quantas formas você pode combinar uma senha\n" +
                "informe  aquantidade de algarismos que a senha possui ex: 3,5,10:\nDICA FAÇA NÚMEROS MENOR QUE 31");
            float algarismo = Int32.Parse(Console.ReadLine());
            float teste = 1;
            for(float i =algarismo;i>1;i--)
            {
                teste *= i;
               
            }
             Console.WriteLine("Possui {0} maneiras diferente, de senha", teste,3f);
            Console.WriteLine("\nAgora você  conbinar de quantas formas poderá se vestir\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Quantas camisetas você tem?");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quantas touca,bone,peruca, ou chapéu  você tem?");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quantas calças você tem?");
            int num3 = Int32.Parse(Console.ReadLine());
            int total = 0;
            
            if (num1 == 0) { total = num2 * num3; }
            else if (num2 == 0) { total = num1 * num3; }
            else if (num3 == 0) { total = num1 * num2; }
            
            else
            {
                total = num1 * num2 * num3;
               
            }
            Console.WriteLine("Você tem {0} formas diferentes de se vestir", total);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("De quantas formas pessoas conseguem sentar-se  em difentes ascentos em um onibus?:\n\nO " +
            "número de pessoas deve ser maior que os lugares\ninforme o número de pessoas ");
            int pessoas = Int32.Parse(Console.ReadLine());
        lugares:
            Console.WriteLine("informe o número de lugares");
           
            int lugares = Int32.Parse(Console.ReadLine());
            if (lugares>=pessoas)
            {
                goto lugares;
            }
            int aux = 1;
            for (int i=pessoas;i>=lugares;i--)
            {
                aux *= i;
               
            }
            Console.WriteLine("Existem {0} formas para acomodar essas pessoas",aux);
        }
    }
}
