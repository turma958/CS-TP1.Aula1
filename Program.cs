namespace CS_TP1.Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabela = new int[10];

            string[,] nomes = new string[3,2];

            tabela[0] = 10;
            tabela[1] = 5;
            tabela[3] = 20;
            tabela[4] = 30;

            nomes[0, 0] = "Mateus";
            nomes[0, 1] = "Pedro";
            nomes[1, 0] = "Othon";
            nomes[1, 1] = "Bruno";
            nomes[2, 0] = "Marcus";
            nomes[2, 1] = "Paulo";

            //foreach(int i in tabela)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 0; i < tabela.Length; i++)
            //{
            //    Console.WriteLine(tabela[i]);
            //}

            //foreach (string s in nomes)
            //{
            //    Console.WriteLine(s);
            //}

            //for(int linha = 0; linha < nomes.GetLength(0); linha++)
            //{
            //    for(int coluna = 0; coluna < nomes.GetLength(1); coluna++)
            //    {
            //        Console.WriteLine(nomes[linha,coluna]);
            //    }
            //}

            //int i = 0;
            //while(i < tabela.Length)
            //{
            //    Console.WriteLine(tabela[i]);

            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine(tabela[i]);

            //    i++;
            //} while (i < tabela.Length);

            //Array.Clear(tabela);

            //int[] tabela2 = new int[10];

            //Array.Copy(tabela, tabela2, 10);

            Array.Sort(tabela);
            

            foreach (int i in tabela)
            {
                Console.WriteLine(i);
            }

            //Console.WriteLine(nomes[0,1]);
            //Console.WriteLine(tabela[3]);
        }
    }
}