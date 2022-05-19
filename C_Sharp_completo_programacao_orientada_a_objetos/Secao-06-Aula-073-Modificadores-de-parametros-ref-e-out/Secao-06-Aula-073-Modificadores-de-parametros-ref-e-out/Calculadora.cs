using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_06_Aula_073_Modificadores_de_parametros_ref_e_out
{
    internal class Calculadora
    {
        //O modificador out é similar ao ref, faz o parâmetro ser uma referência para a variável original, mas não exige que a variável original seja iniciada.
        //A verdade... é que isso nem é usado, o return faz muito mais sentido que out ou ref.
        public static void Triplo(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}
