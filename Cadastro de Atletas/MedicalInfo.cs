using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Atletas
{
    public class MedicalInfo
    {
        public int Id { get; set; }
        public string TipoSanguineo { get; set; }
        public string Alergia { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public double IMC { get; set; }
    }
}
