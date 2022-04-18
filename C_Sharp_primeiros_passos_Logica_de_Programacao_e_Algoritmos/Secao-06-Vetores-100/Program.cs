using System;
using System.Globalization;

namespace Secao_06_Vetores_100
{
    class Program
    {
        static void Main(string[] args){
            /*Exercícios propostos
            9) Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa. Para isto, mandou digitar
            um conjunto de N mercadorias, cada uma contendo nome, preço de compra e preço de venda das mesmas. Fazer um
            programa que leia tais dados e determine e escreva quantas mercadorias proporcionaram:
            - lucro < 10%
            - 10% ≤ lucro ≤ 20%
            - lucro > 20%
            Determine e escreva também o valor total de compra e de venda de todas as mercadorias, assim como o lucro total.
            Exemplo:
            Entrada                                                 Saída
            4                                                       Lucro abaixo de 10%: 1
            Feijao 10.00 11.00                                      Lucro entre 10% e 20%: 2
            Arroz 12.00 12.80                                       Lucro acima de 20%: 1
            Oleo 5.00 5.70                                          Valor total de compra: 30.00
            Sal 3.00 4.00                                           Valor total de venda: 33.50
                                                                    Lucro total: 3.50
            */

            Console.Write("Quantas mercadorias vão ser digitadas ?: ");
            int N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            double[] compra = new double[N];
            double[] venda = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                nome[i] = (s[0]);
                compra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                venda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            int contAbaixoDe10 = 0;
            int contEntre10E20 = 0;
            int contAcimaDe20 = 0;

            for (int i = 0; i < N; i++) {

                double lucro = venda[i] - compra[i];

                double porcentagemDeLucro = lucro / compra[i] * 100.0;

                if (porcentagemDeLucro < 10.0) {
                    contAbaixoDe10++;
                }
                else if (porcentagemDeLucro <= 20.0) {
                    contEntre10E20++;
                }
                else {
                    contAcimaDe20++;
                }
            }
            Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDe10);
            Console.WriteLine("Lucro entre 10% e 20%: " + contEntre10E20);
            Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);

            double totalCompra = 0.0;
            double totalVenda = 0.0;
            
            for (int i = 0; i < N; i++) {
                totalCompra = totalCompra + compra[i];
                totalVenda = totalVenda + venda[i];
            }

            double totalLucro = totalVenda - totalCompra;

            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
