using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_15_Aula_216_GetHashCode_e_Equals_p2.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        //Comparando um Client que vai vir comparando com outro cliente que no caso é o obj.
        public override bool Equals(object obj)
        {
            if (!(obj is Client))//Se esse obj não for um objeto do tipo Client retorne false, esse objetos não são iguais.
            {
                return false;
            } 
            Client other = obj as Client;//Downcasting
            return Email.Equals(other.Email);//Comparando por Email, Email.Equals com o outro/other.Email.
        }

        //Como está sendo considerado que um cliente é igual ao outro, quando os Email são iguais,
        //o mesmo principio também vai valer para o HashCode.
        public override int GetHashCode()
        {
            return Email.GetHashCode();//Portando o HashCode do Email vai ser o HashCode do Client
        }
    }
}
