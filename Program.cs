using System;
using System.Globalization;
using System.Xml;

namespace Target{
    
    class Program{

        static void Main (string[] args){

            //Referenciar numero do exercicio desejado:
            //Ex:
            //Exercicio3();

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

            XmlDocument document = new XmlDocument();
            document.Load(@"../../../dados xml.xml");
            XmlNodeList linhas = document.SelectNodes("root/row");
            Dictionary<int, float> faturamento = new Dictionary<int, float>();

            foreach (XmlNode linha in linhas)
            {
                int dia = Int32.Parse(linha["dia"].InnerText);
                float valor = float.Parse(linha["valor"].InnerText, CultureInfo.InvariantCulture);
                faturamento.Add(dia, valor);
            }

            int indexAux;

            Console.WriteLine("Dia com menor faturamento:");
            indexAux = faturamento.Where(f => f.Value > 0).OrderBy(o => o.Value).FirstOrDefault().Key;
            Console.WriteLine("Dia: "+ indexAux + " - Faturamento: "+ faturamento.ElementAt(indexAux-1).Value.ToString("F2"));

            //Possiveis outros dados poderiam ser extraidos e usando o "indexAux" como auxiliar pra operação, poupando variáveis e memória   

            //ATENÇÃO:
            //Verificar e-mail enviado por lucas050300@gmail.com explicando o problema que ouve na Gupy e prejudicou a resolução deste exercicio.       

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

