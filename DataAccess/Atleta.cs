using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Clube_Futebol.DataAccess
{
    public class Atleta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Posicao { get; set; }
        public int Numero_Camisa { get; set; }

        public double IMC => Peso / (Altura * Altura);
        public string ClassificacaoIMC
        {
            get
            {
                double imc = IMC;
                if (imc < 18.5)
                    return "Abaixo do peso normal";
                else if (imc < 25)
                    return "Peso normal";
                else if (imc < 30)
                    return "Excesso de peso";
                else if (imc < 35)
                    return "Obesidade classe I";
                else if (imc < 40)
                    return "Obesidade classe II";
                else
                    return "Obesidade classe III";
            }
        }
    }
}