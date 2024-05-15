using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        public string Diagnostico { get; set; }

        public Paciente(string nombre, string apellido, DateTime nacimiento, string diagnostico, string barrioRecidencia)
            : base(nombre, apellido, nacimiento, barrioRecidencia) 
        {
            Diagnostico = diagnostico;
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Recide en: {barrioRecidencia}"); 
            sb.AppendLine(Diagnostico);
            return sb.ToString();
        }
    }
}