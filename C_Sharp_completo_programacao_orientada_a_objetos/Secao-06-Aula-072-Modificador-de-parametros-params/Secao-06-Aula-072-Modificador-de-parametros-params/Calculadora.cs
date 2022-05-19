using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_06_Aula_072_Modificador_de_parametros_params
{
    internal class Calculadora
    {
        //É dessa forma que se cria uma função com parâmetros variados.
        public static int Soma(params int[] numero)//params - avisa o compilador que essa função pode receber uma quantia variada de valores.
        {
            int soma = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                soma += numero[i];
            }
            return soma;
        }
    }
}
