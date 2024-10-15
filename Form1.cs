namespace AppLibroteca
{
    public partial class Form1 : Form
    {

        LibroImpreso libritoImpreso;
        AudioLibro audiolibrito;
        LibroDigital libroDigi;
        public Form1()
        {
            InitializeComponent();
        }

        private void rbAudioLibro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAudioLibro.Checked)
            {
                txtTiempoMinutos.Enabled = true;
                txtNumeroPaginas.Enabled = false;
            }
        }

        private void rbLimbroImpreso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLimbroImpreso.Checked)
            {
                txtNumeroPaginas.Enabled = true;
                txtTiempoMinutos.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rbLimbroImpreso.Checked == true)

            {
                libritoImpreso = new LibroImpreso(txtNombre.Text, txtAutor.Text
                        , double.Parse(txtCosto.Text)
                        , txtEditorial.Text, int.Parse(txtNumeroPaginas.Text));
                MessageBox.Show("Dato Ingresado Correctamente");
            }
            else if(rbAudioLibro.Checked == true)
            {
                audiolibrito = new AudioLibro(txtNombre.Text, txtAutor.Text,
                    double.Parse(txtCosto.Text),
                    txtEditorial.Text, int.Parse(txtTiempoMinutos.Text));
                MessageBox.Show("Dato Ingresado Correctamente");

            }
            else
            {
                libroDigi = new LibroDigital
                    (txtNombre.Text, txtAutor.Text, double.Parse(txtCosto.Text)
                    , txtEditorial.Text, double.Parse(txtPesoLibro.Text));
                MessageBox.Show("Dato Ingresado Correctamente");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
           
            
        }
    }
}
