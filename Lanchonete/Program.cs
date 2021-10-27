using System;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produto = new string[10];
            float[] v_p = new float[10];
            int[] quant = new int[10];
            float total = 0f;
            bool quit_menu = false;
            while (!quit_menu)
            {
                Console.Clear();
                Console.WriteLine("Bem-Vindo");
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1- Registrar produto\n2- Lançar produtos\n3- Quantidade de produtos vendidodos\n4- Lista e preços do produtos\n5-Sair do programa");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 5)
                {
                    quit_menu = true;
                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Quantos produtos quer registar? (MAX:10)");
                        int q_p = int.Parse(Console.ReadLine());
                        for (int i = 0; i < q_p; i++)
                        {
                            Console.WriteLine("Digite o produto: ");
                            produto[i] = Console.ReadLine();
                            Console.WriteLine("Digite o valor do produto: ");
                            v_p[i] = float.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Qual produto acabou de vender? (1 a 10)");
                        int ve_p = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a quantidade vendida? ");
                        int qa_v = int.Parse(Console.ReadLine());
                        switch (ve_p)
                        {
                            case 1:
                                total = total + (qa_v * v_p[0]);
                                quant[0] = quant[0] + qa_v;
                                break;
                            case 2:
                                total = total + (qa_v * v_p[1]);
                                quant[1] = quant[1] + qa_v;
                                break;
                            case 3:
                                total = total + (qa_v * v_p[2]);
                                quant[2] = quant[2] + qa_v;
                                break;
                            case 4:
                                total = total + (qa_v * v_p[3]);
                                quant[3] = quant[3] + qa_v;
                                break;
                            case 5:
                                total = total + (qa_v * v_p[4]);
                                quant[4] = quant[4] + qa_v;
                                break;
                            case 6:
                                total = total + (qa_v * v_p[5]);
                                quant[5] = quant[5] + qa_v;
                                break;
                            case 7:
                                total = total + (qa_v * v_p[6]);
                                quant[6] = quant[6] + qa_v;
                                break;
                            case 8:
                                total = total + (qa_v * v_p[7]);
                                quant[7] = quant[7] + qa_v;
                                break;
                            case 9:
                                total = total + (qa_v * v_p[8]);
                                quant[8] = quant[8] + qa_v;
                                break;
                            case 10:
                                total = total + (qa_v * v_p[9]);
                                quant[9] = quant[9] + qa_v;
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Quantidades: ");
                        for (int i2 = 0; i2 < produto.Length; i2++)
                        {
                            Console.WriteLine(produto[i2] + " = " + quant[i2]);
                        }
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine(" ===== Tabela de nome e preço ===== ");
                        for(int i3 = 0; i3 < produto.Length; i3++)
                        {
                            Console.WriteLine($"{i3} - {produto[i3]} custa = {v_p[i3]} ");
                        }
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
