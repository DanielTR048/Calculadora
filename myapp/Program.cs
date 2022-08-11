using System;

namespace myapp
{
    class Program {

        public static void Main(string[] args){
            int num1,num2,result = 0;
            string signal = "";
            string op = "";
            string cont = "";
            Console.WriteLine("Digite o primeiro numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o operador: (+) (-) (*) (/)");
            signal = Console.ReadLine();

            Console.WriteLine("Digite o segundo numero");
            num2 = int.Parse(Console.ReadLine());

            switch (signal) 
            {
                case "+":
                op = "somando...";
                result = num1 + num2;
                break;

                case "-":
                op = "Subtraindo...";
                result = num1 - num2;
                break;

                case "*":
                op = "Multiplicando...";
                result = num1 * num2;
                break;

                case "/":
                op = "Dividindo...";
                if (num2 == 0){
                     Console.WriteLine("Error, exiting...");
                     Environment.Exit(0);
                }
                result = num1 / num2;
                break;

                default:
                Console.WriteLine("Operador invalido!!");
                break;
            }
            Console.WriteLine(op);

            Console.WriteLine("{0} {1} {2} = {3}", num1,signal, num2, result);

            Console.WriteLine("Deseja continuar com o resultado?? (s) (n)");
            cont = Console.ReadLine();



            int result2 = 0;

            while (cont == "s"){

            Console.WriteLine("Digite o operador: (+) (-) (*) (/)");
            signal = Console.ReadLine();

            Console.WriteLine("Digite o segundo numero");
            int num3 = int.Parse(Console.ReadLine());


                switch (signal)
                {
                case "+":
                op = "somando...";
                result2 = result;
                result2 += num3;
                break;

                case "-":
                op = "Subtraindo...";
                result2 = result;
                result2 -= num3;
                break;

                case "*":
                op = "Multiplicando...";
                result2 = result;
                result2 *= num3;
                break;

                case "/":
                op = "Dividindo...";
                if (num3 == 0){
                     Console.WriteLine("Error, exiting...");
                     Environment.Exit(0);
                }
                result2 = result;
                result2 /= num3;
                break;

                default:
                Console.WriteLine("Operador invalido!!");
                break;

                }

            Console.WriteLine(op);
            Console.WriteLine("{0} {1} {2} = {3}", result,signal, num3, result2);
            Console.WriteLine("Deseja continuar com o resultado?? (s) (n)");
            cont = Console.ReadLine();


            result = result2;
            }


        }
    }
}

