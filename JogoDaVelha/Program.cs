using System;

namespace JogoDaVelha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] tab = new char[3, 3];
            int linha;
            int coluna;
            bool flag = false;
            Console.WriteLine("\t>>> JOGO DA VELHA <<<\n*Que a Sorte Esteja Sempre a Seu Favor*\n\n\t\tINICIO!\n\n");
            //iniciando a matriz sem valores.
            for (int l = 0; l < tab.GetLength(0); l++)
            {
                for (int c = 0; c < tab.GetLength(1); c++)
                {
                    tab[l, c] = ' ';
                }
            }
            for (int l = 0; l < tab.GetLength(0); l++)  //imprimindo a matriz zerada pra mostrar o inicio do jogo.
            {
                for (int c = 0; c < tab.GetLength(1); c++)
                {
                    Console.Write($" [{tab[l, c]}] ");
                }
                Console.WriteLine();
            }
            for (int jog = 0; jog < tab.Length; jog++) //começa o preenchimento.
            {
                if (jog % 2 == 0)
                { //se a jogada for par, preenche com x
                    Console.WriteLine("\n\nJogador 1, esolha uma casa livre para preencher com ''X''. Informe a linha (de 1 a 3) e a coluna (de 1 a 3): ");

                    do
                    {
                        Console.Write("\nLINHA: "); linha = int.Parse(Console.ReadLine());
                        Console.Write("COLUNA: "); coluna = int.Parse(Console.ReadLine());
                        if (linha > 0 && linha < 4 && coluna > 0 && coluna < 4)
                        {
                            if (tab[linha - 1, coluna - 1] == ' ')
                            {
                                tab[linha - 1, coluna - 1] = 'X';
                                flag = true;
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Opção não disponivel, escolha outra linha e coluna:");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção não disponivel, escolha outra linha e coluna:");
                        }
                    } while (flag == false);
                }
                else
                {//se a jogada for impar, preenche com O
                    Console.WriteLine("\n\nJogador 2, esolha uma casa livre para preencher com ''O''. Informe a linha (de 1 a 3) e a coluna (de 1 a 3): :");
                    do
                    {
                        Console.Write("\nLINHA: "); linha = int.Parse(Console.ReadLine());
                        Console.Write("COLUNA: "); coluna = int.Parse(Console.ReadLine());
                        if (linha > 0 && linha < 4 && coluna > 0 && coluna < 4)
                        {
                            if (tab[linha - 1, coluna - 1] == ' ')
                            {
                                tab[linha - 1, coluna - 1] = 'O';
                                flag = true;
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Opção não disponivel, escolha outra linha e coluna:");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção não disponivel, escolha outra linha e coluna:");
                        }
                    } while (flag == false);
                }
                flag = false;
                for (int l = 0; l < tab.GetLength(0); l++)
                {
                    for (int c = 0; c < tab.GetLength(1); c++)
                    {
                        Console.Write($" [{tab[l, c]}] ");
                    }
                    Console.WriteLine();
                }
                if (jog >=4 ) //se a jogada for maior ou igual a 4 (ou seja, 5 jogadas pra frente) faço as verificações
                {    
                    if (tab[0, 0] == tab[1, 1] && tab[0, 0] == tab[2, 2] ||
                        tab[0, 2] == tab[1, 1] && tab[0, 2] == tab[2, 0] ||
                        tab[0, 0] == tab[0, 1] && tab[0, 0] == tab[0, 2] && tab[0, 0] != ' ' ||
                        tab[1, 0] == tab[1, 1] && tab[1, 0] == tab[1, 2] && tab[1, 0] != ' ' ||
                        tab[2, 0] == tab[2, 1] && tab[2, 0] == tab[2, 2] && tab[2, 0] != ' ' ||
                        tab[0, 0] == tab[1, 0] && tab[0, 0] == tab[2, 0] && tab[0, 0] != ' ' ||
                        tab[0, 1] == tab[1, 1] && tab[0, 1] == tab[2, 1] && tab[0, 1] != ' ' ||
                        tab[0, 2] == tab[1, 2] && tab[0, 2] == tab[2, 2] && tab[0, 2] != ' ')
                    {
                        if (jog % 2 == 0)
                        {
                            Console.WriteLine("\n***FIM DE JOGO***\nO vencedor é o JOGADOR 1");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n***FIM DE JOGO***\nO vencedor é o JOGADOR 2");
                            break;
                        }
                    }
                    else if (jog >=8)
                    {
                        Console.WriteLine("\nFim de jogo. Não houve ganhadores!");
                        break;
                    }
                }
            }
        }
    }
}
