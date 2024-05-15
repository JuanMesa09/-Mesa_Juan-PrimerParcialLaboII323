using Entidades;

namespace FmrAtencion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (lstMedicos.SelectedItem == null || lstPacientes.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un Medico y un Paciente para poder continuar.", "Error en los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            PersonalMedico medico = (PersonalMedico)lstMedicos.SelectedItem;
            Paciente paciente = (Paciente)lstPacientes.SelectedItem;
            Consulta consulta = new Consulta(DateTime.Now, paciente);

            
            medico.AgregarConsulta(consulta);

            
            lstMedicos.ClearSelected();
            lstPacientes.ClearSelected();

            
            string mensaje = $"Se ha atendido a {paciente.NombreCompleto}.\nFecha: {consulta.Fecha}\nDiagnóstico: Paciente curao";
            MessageBox.Show(mensaje, "Atención finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }
    }
}
