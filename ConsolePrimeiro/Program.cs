using ConsolePrimeiro;
using System;
using System.Globalization;
using System.Collections.Generic;

//namespace: grupamento de classes relacionadas
namespace Primeiro
{
    //por convenção colocamos o nome da classe o mesmo nome do arquivo. (Program.cs)
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Console.WriteLine("Hello, World!");
            //sbyte -128 a 127
            //sbyte x = 100;

            //Console.WriteLine(x);
            //Console.Write(x); -- Esse comando não pula uma linha depois de imprimir

            int idade = 32;
            double saldo = 10.7634;
            string nome = "Maria";

            //PLACEHOLDER - como se fosse um lugar para colocar a variavel.
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome,idade,saldo);

            //INTERPOLAÇÃO
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2}.");

            //CONCATENAÇÃO DE STRING.
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

            //CultureInfo.InvariantCulture - retira qualquer formatação de um país.

            //overflow - quando um cálculo extrapola o limite de tamanho da variável. Nesse casoo valor da variável vai para o limite oposto


            //int a = 5;
           // int b = 2;

           // double resultado = a / b;
            //resultado = 2 - porque o compilador entende que vc esta fazendo uma operação entre dois int e vai te retornar um int como resposta

            //Console.WriteLine(resultado);
            //se vc quer o resultado correto, logo 2,5...terá que fazer o CASTING. converter um deles para double.

           // double resultado2 = (double) a / b;
            //nesse caso, ele converte a em double e depois divide. Resultado será 2,5
           // Console.WriteLine(resultado2.ToString(CultureInfo.InvariantCulture));


            //entrada de dados básica
           // string frase = Console.ReadLine();
           // Console.WriteLine("Você digitou: " + frase);

            //SPLIT - no nosso caso, separa as partes separadas por um espaço em branco
         /*  string[] vet = frase.Split(' ');

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            */

            Triangulo x, y;

            //instanciação das variáveis

            /*
             x = new Triangulo();
             y = new Triangulo();

             Console.WriteLine("Entre com as medidas do Triangulo X: ");
             x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             Console.WriteLine("Entre com as medidas do Triangulo Y: ");
             y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaX = x.CalcularArea();

            double areay = y.CalcularArea();
            

            Pessoa pes1, pes2;

            pes1 = new Pessoa();
            pes2 = new Pessoa();    


            Console.WriteLine("Insira os dados da primeira pessoa: ");
            pes1.nome = Console.ReadLine();
            pes1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira os dados da segunda pessoa: ");
            pes2.nome = Console.ReadLine();
            pes2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("O mais velho é: " + MaisVelho(pes1,pes2));


           static string MaisVelho (Pessoa a, Pessoa b)
            {
                if (a.idade > b.idade )
                {
                    return a.nome;
                }
                else 
                {
                    return b.nome;
                }
            }
            */

            //Produto p = new Produto();

            //Produto p2 = new Produto("TV", 3.4, 3);

            //p2.Nome = "TV 4K";

            //Console.WriteLine(p2.Nome);
           // Console.WriteLine(p2.Preco);

            //--------------------------------STRUCT --------------------------------------------------
            //Não precisa fazer p = new Point();  porque é um tipo STRUCT , é um tipo valor.
            //A simples declaração dele vai criar na memória (stack) as caixinhas.

            Point p;

            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            //vc tb pode declarar com new

            p = new Point();
            Console.WriteLine(p);

            //quando alocamos (new) qualquer tipo estruturado (class, struct, array), são atribuídos os valores
            //padrão de seus elementos
            //numero = 0
            //bool = false, etc...


            //--------------  NULLABLE -----------------------
            /*double? testenullable1 = null;
            double? testenullable2 = 10;

            Console.WriteLine(testenullable1.GetValueOrDefault());
            Console.WriteLine(testenullable2.GetValueOrDefault());

            Console.WriteLine(testenullable1.HasValue);
            Console.WriteLine(testenullable2.HasValue);

            if (testenullable1.HasValue)
            {
                Console.WriteLine(testenullable1.Value);
            }
            else { Console.WriteLine("X é nulo"); }
            
            if (testenullable2.HasValue)
            {
                Console.WriteLine(testenullable2.Value);
            }
            else { Console.WriteLine("Y é nulo!"); }

            //--------------OPERADOR COALESCENCIA NULA ---------------------------
            double? testeCoalescenciaNula = testenullable1 ?? 999;

            Console.WriteLine(testeCoalescenciaNula);


            /*
            Console.WriteLine("Entre com os dados do Produto: ");
            Console.Write("Nome: ");

            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");

            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no Estoque: ");

            p.Quantidade = int.Parse(Console.ReadLine()); 

            // O PRÓPRIO C# VAI PERCEBER QUE P ESTÁ PARTICIPANDO DE UMA CONCATENAÇÃO DE STRING, ENTÃO VAI CHAMAR O ToString()
            Console.WriteLine("Dados do Produto: " + p);

            Console.Write("Adicionar QTD: ");
            p.AdicionaQtd(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados do Produto: " + p);

            Console.Write("Remover QTD: ");
            p.DiminuiQtd(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados do Produto: " + p);
            */
            /*
            Console.WriteLine("Digite a quatidade de posicoes do vetor:");
            int n = int.Parse(Console.ReadLine());

            //double[] vect = new double[n];

            Products[] vect = new Products[n];

            //--------------EXEMPLO DE VETOR COM OBJETO DO TIPO REFERENCIA (CLASSE)----------------
            for (int i = 0; i < n; i++)
            {
                //vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                string name = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                vect[i] = new Products { Nome = name, Price = preco };  

            }

            //Console.WriteLine("A media do vetor é:" + vect.Average().ToString("F2",CultureInfo.InvariantCulture));

            double soma =0.0;
            for (int i = 0;i < vect.Length; i++)
            {
                soma+=vect[i].Price;   
            }

            Console.WriteLine("A média de preço dos produtos é: " + (soma / n).ToString("F2", CultureInfo.InvariantCulture));

           
            ////--------------------- PROGRAMA BUSY ROOMS -------------------------------------------------
            Console.WriteLine("How many rooms will be rented?");
            int QtdRooms = int.Parse(Console.ReadLine());

            Quartos[] vect = new Quartos[QtdRooms];

            for (int i = 0; i < QtdRooms; i++) 
            {
                Console.WriteLine("RENT #" + (i+1) + ":");
                Console.Write("Nome:");
                string nome = Console.ReadLine();

                Console.Write("Email:");
                string email = Console.ReadLine();

                Console.Write("Room:");
                int numQuarto = int.Parse(Console.ReadLine()); 

                vect[numQuarto] = new Quartos { Nome = nome, Email = email, numero= numQuarto };

            }

            Console.WriteLine("BUSY ROOMS:");

            for (int i = 0;i < vect.Length; i++) 
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i].numero + ": " + vect[i].Nome + ", " + vect[i].Email);
                }
            }
 */
            //------------PARAMS ---------------------------
            // int s1 = Quartos.Sum(1, 2, 4, 7);
            //  int s2 = Quartos.Sum(7, 9);

            // Console.WriteLine(s1);
            // Console.WriteLine(s2);

            /*
                        //----------------------------- LISTAS -------------------------------
                        List<string> list = new List<string>();

                        // ADD adiciona no final da lista
                        list.Add("Ana");
                        list.Add("Gabriel");
                        list.Add("Giovana");

                        // INSERT vc pode dizer qual a posição. Empurra o elemento anterior para baixo.
                        list.Insert(1,"Alessandra");   


                        foreach (string s in list)
                        {
                            Console.WriteLine(s);
                        }

                        //----------------------Expressão LAMBDA--------------------
                        //eu quero que o primeiro caracter de x (x[0]) seja igual a A
                        string s1 = list.Find(x => x[0] == 'A');
                        Console.WriteLine("Primeiro nome com a letra 'A' é: " + s1);

                        string s2 = list.FindLast(x => x[0] == 'A');
                        Console.WriteLine("Último nome com a letra 'A' é: " + s2);

                        //---FAZER UM FILTRO NA LISTA   

                        List<string> list2 = list.FindAll(x => x.Length > 5);
                        foreach (string s in list2)
                        {
                            Console.WriteLine(s);
                        }


                        //------------------------------------------------------------------

                        */

            /*Console.WriteLine("How many employees will be registred?");
            int qtdEmployees = int.Parse(Console.ReadLine());

            List<funcionario> list = new List<funcionario>();


            for (int i = 1; i <= qtdEmployees; i++)
            {
                Console.WriteLine("Employee #" + i + ":");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new funcionario(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            funcionario emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            foreach (funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
            */

            //----------------------Expressão condicional sem usar IF
            // se ele atender a condição, executa o primeiro, caso contrário executa o segundo
           // double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;


        }
    }


}
