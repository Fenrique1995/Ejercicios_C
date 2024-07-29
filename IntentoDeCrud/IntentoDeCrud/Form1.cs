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

                // Crear instancia de Inyector y guardar en la base de datos
                Inyector inyector = new Inyector();
                inyector.InsertarTrabajador(trabajador.Nombre, trabajador.Apellido, trabajador.Dni, puesto.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void mostrarTrabajador_Click(object sender, EventArgs e)
        {
            txtMostrarTrabajadores.Items.Clear();

            Inyector inyector = new Inyector();
            List<Trabajador> trabajadores = inyector.ConectarYLeer();

            foreach (var trabajador in trabajadores)
            {
                txtMostrarTrabajadores.Items.Add(trabajador.ToString());
            }
        }

        private void txtMostrarTrabajadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void borrarTrabajador_Click(object sender, EventArgs e)
        {
            if (txtMostrarTrabajadores.SelectedItem != null)
            {
                // Obtener el trabajador seleccionado como cadena
                string trabajadorSeleccionadoStr = txtMostrarTrabajadores.Text;

                // Llamar al método para borrar el trabajador usando la cadena ToString
                Inyector inyector = new Inyector();
                inyector.BorrarTrabajador(trabajadorSeleccionadoStr);

                // Eliminar el trabajador de la lista en memoria
                Trabajador trabajadorSeleccionado = trabajadores.FirstOrDefault(t => t.ToString() == trabajadorSeleccionadoStr);
                if (trabajadorSeleccionado != null)
                {
                    trabajadores.Remove(trabajadorSeleccionado);
                }

                // Actualizar la ListBox
                ActualizarListaTrabajadores();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un trabajador para borrar.");
            }

        }
        private void ActualizarListaTrabajadores()
        {
            Inyector inyector = new Inyector();
            trabajadores = inyector.ConectarYLeer();

            txtMostrarTrabajadores.DataSource = null;
            txtMostrarTrabajadores.DataSource = trabajadores;
        }
    }
}