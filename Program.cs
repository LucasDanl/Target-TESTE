using System;
using System.Runtime.InteropServices;

namespace Target{
    
    class Program{

        static void Main (string[] args){

            //Referenciar numero do exercicio desejado:
            //Ex:
            //Exercicio5();

        }

        static public void Exercicio1(){

            int indice = 13;
            int soma = 0;
            int k = 0;
            
            while (k < indice){

                k = k + 1;
                soma = soma + k;
            } 
            Console.WriteLine(soma);
        }

        static public void Exercicio2(){

            Console.WriteLine("Digite um numero para verifica-lo na sequencia Fibonacci!");
            int fiboUser = Int32.Parse(Console.ReadLine());
            
            int fiboStarter1 = 0;
            int fiboStarter2 = 1;

            int aux = 0;
            while(aux != fiboUser && aux < fiboUser){
                
                aux = fiboStarter1 + fiboStarter2;
                                
                fiboStarter1 = fiboStarter2;
                fiboStarter2 = aux;

            }

            if(aux == fiboUser){
                Console.WriteLine("Numero pertence a sequencia Fibonacci");
            }else{
                Console.WriteLine("Numero NÃO pertence a sequencia Fibonacci");
            }
        }


        static public void Exercicio3(){
            //xml indisponivel
        }

        static public void Exercicio4(){
            
            Dictionary<string, float> faturamento = new Dictionary<string, float>();

            faturamento.Add("SP", 67836.43f);
            faturamento.Add("RJ", 36678.66f);
            faturamento.Add("MG", 29229.88f);
            faturamento.Add("ES", 27165.48f);
            faturamento.Add("Outros", 19849.53f);

            float total = faturamento.Select(f => f.Value).Sum();
             
            foreach (var estado in faturamento)
            {                
                Console.WriteLine("Estado: " + estado.Key +" - Percentual de Faturamento: "+ ((estado.Value/total) *100).ToString("F2") + "%");                
            }

        }

        static public void Exercicio5(){
            
            Console.WriteLine("Digite algo para inverter:");
            string normal = Console.ReadLine();
            string inverse = "";

            for(int i = normal.Length-1; i >=0; i--){
                inverse += normal[i];
            }

            Console.WriteLine(inverse);
        }
    }


}

