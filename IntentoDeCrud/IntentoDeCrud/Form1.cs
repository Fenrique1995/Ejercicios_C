using Libreria;
namespace IntentoDeCrud
{
    public partial class Guardar : Form
    {
        private List<Trabajador> trabajadores = new List<Trabajador>();
        public Guardar()
        {
            InitializeComponent();
            LoadPuestoEnumValues();
        }
        private void LoadPuestoEnumValues()
        {
            comboBoxPuesto.DataSource = Enum.GetValues(typeof(Puesto)).Cast<Puesto>().ToList();
        }

        private void comboBoxPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPuesto.SelectedItem != null)
            {
                Puesto selectedPuesto = (Puesto)comboBoxPuesto.SelectedItem;
            }
            else 
            {
                MessageBox.Show("Seleccione un puesto por favor.");
                return;
            }
        }
        private void guardarTrabajador_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int dni;
                Puesto puesto = (Puesto)comboBoxPuesto.SelectedItem;

                if (!int.TryParse(txtDNI.Text, out dni))
                {
                    MessageBox.Show("Por favor, ingresa un DNI válido.");
                    return;
                }

                Trabajador trabajador = new Trabajador(nombre, apellido, dni, puesto);

                trabajadores.Add(trabajador);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void mostrarTrabajador_Click(object sender, EventArgs e)
        {
            txtMostrarTrabajadores.Items.Clear();
            foreach (var trabajador in trabajadores)
            {
                txtMostrarTrabajadores.Items.Add(trabajador.ToString());
            }
        }
    }
}