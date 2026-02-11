using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Atletas
{
    public class Atleta
    {
        public int Id { get; set; }
        public string Nome {  get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; } // M ou F
        public string Nacionalidade { get; set; }
        public string Modalidade { get; set; }
        public MedicalInfo InformacoesMedicas { get; set; }

        public Atleta() //Quando eu crio um novo objeto do tipo Atleta
        {
            InformacoesMedicas = new MedicalInfo();//Eu crio um novo objeto do tipo MedicalInfo
        }
    }
}
