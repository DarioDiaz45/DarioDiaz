

using Piramide.Entidades;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;

namespace Piramides.Windows
{
    public partial class frmPiramides : Form
    {
        private List<PiramideCuadradas> piramides = new List<PiramideCuadradas>();
        public frmPiramides()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var lado = int.Parse(txtLado.Text);
                var altura = int.Parse(txtAltura.Text);
                PiramideCuadradas p = new PiramideCuadradas(lado, altura);

                var context = new ValidationContext(p);
                var errors = new List<ValidationResult>();

                var isValid = Validator.TryValidateObject(p, context, errors, true);
                if (isValid)
                {
                    MessageBox.Show(p.ToString(), "Mensaje", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    AgregarPiramide(p);
                    InicializarControles();
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var error in errors)
                    {
                        sb.AppendLine($"{error.ErrorMessage}");
                    }
                    MessageBox.Show(sb.ToString(), "Errores", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    txtLado.SelectAll();
                    txtLado.Focus();
                }
            }
        }
       

        private void AgregarPiramide(PiramideCuadradas p)
        {
            piramides.Add(p);
            PiramidesCuadradas.Items.Add(p.MostrarInfo());
            lblCantidad.Text = $"Cantidad de pirámides: {piramides.Count}";
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtLado.Text, out _))
            {
                valido = false;
                errorProvider1.SetError(txtLado, "Lado mal ingresado");
            }
            if (!int.TryParse(txtAltura.Text, out _))
            {
                valido = false;
                errorProvider1.SetError(txtAltura, "Altura mal ingresada");
            }
            return valido;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            txtLado.Clear();
            txtAltura.Clear();
            txtLado.Focus();
        }
    }
}
