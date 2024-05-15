using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente)
            : base(nombre, apellido, nacimiento)
        {
            this.esResidente = esResidente;
            consultas = new List<Consulta>();
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¿Finalizó residencia? {(esResidente ? "SI" : "NO")}");
            sb.AppendLine("ATENCIONES:");
            foreach (Consulta consulta in consultas)
            {
                sb.AppendLine(consulta.ToString());
            }
            return sb.ToString();
        }

        public void AgregarConsulta(Consulta nuevaConsulta)
        {
            consultas.Add(nuevaConsulta);
        }


    }
}