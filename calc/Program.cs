using System;
 
 namespace calc
 {
     class Program
     {
         static void Main(string[] args)
         {
             string menu;
             bool op;            
 
             do
             {
                 op = (false);
                 Console.WriteLine("#=============================#");
                 Console.WriteLine("#==========Calculadora========#");
                 Console.WriteLine("#  Somar           Subtrair   #");
                 Console.WriteLine("#  Multiplicar     Dividir    #");
                 Console.WriteLine("#            Fechar           #");
                 Console.WriteLine("#=============================#");
 
                 menu = (Console.ReadLine());
                 op = (true);
             } while (op == false);
 
             switch (menu)
             {
                 case "Somar":
                     Console.Clear();
                     Soma();
                     op = (false);
                     break;
 
                 case "Subtrair":
                     Console.Clear();
                     Subtração();
                     op = (false);
                     break;
 
                 case "Multiplicar":
                     Console.Clear();
                     Multiplicação();
                     op = (false);
                     break;
 
                 case "Dividir":
                     Console.Clear();
                     Divisão();
                     op = (false);
                     break;
 
                 case "Fechar":
                     break;
             }
             Console.ReadKey();
         }
 
         static void Soma()
         {
             int n1, n2, S;
             Console.WriteLine("Digite o primeiro número da operação:");
             n1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o segundo número da operação:");
             n2 = int.Parse(Console.ReadLine());
 
             S = n1 + n2;
             Console.WriteLine("A soma dos valores é:{0}.", S);
             Console.ReadKey();
 
         }
         static void Subtração()
         {
 
             int n1, n2, S;
             Console.WriteLine("Digite o primeiro número da operação:");
             n1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o segundo número da operação:");
             n2 = int.Parse(Console.ReadLine());
 
             S = n1 - n2;
             Console.WriteLine("A subtração dos valores é:{0}", S);
             Console.ReadKey();
 
         }
         static void Multiplicação()
         {
 
             int n1, n2, S;
             Console.WriteLine("Digite o primeiro número da operação:");
             n1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o segundo número da operação:");
             n2 = int.Parse(Console.ReadLine());
 
             S = n1 * n2;
             Console.WriteLine("A multiplicação dos valores é:{0}", S);
             Console.ReadKey();
 
         }
         static void Divisão()
         {
 
             double n1, n2, S, R;
             Console.WriteLine("Digite o primeiro número da operação:");
             n1 = double.Parse(Console.ReadLine());
             Console.WriteLine("Digite o segundo número da operação:");
             n2 = double.Parse(Console.ReadLine());
 
             S = n1 / n2;
             R = n1 % n2;
             Console.WriteLine("A divisão dos valores é {0} com resto {1}", S, R);
             Console.ReadKey();
 
         }
     }
 }
