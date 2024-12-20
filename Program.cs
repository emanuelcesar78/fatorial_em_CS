using System;

namespace fatorial
{
    class Numero()
    {
        private int numero()
        {
            Random numero_aleatorio = new Random();
            int numero = numero_aleatorio.Next(0,9);

            return numero;
        }
        public int recebe_numero => numero();

       public static void Conta_fatorial(int n)
       {
            int fatorial = 1;
            for (int i = 1; i <= n ; i++)
            {
              fatorial = fatorial * i;   
            }  
            Console.WriteLine("resultado do fatorial : " +n+ ":"+fatorial);
       } 
    }

    class Fatorial:Numero
    {
        static void Main ()
        {
            Numero num = new Numero();

            Conta_fatorial(num.recebe_numero); 
        }
    }
    
}
