using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
namespace PRACTICA_FUSION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Contacto[] a = new Contacto[1];
        int i = 0;
        SaveFileDialog sfd = new SaveFileDialog();

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
            StreamWriter sw = new StreamWriter(@"C:\Users\af339\OneDrive\Desktop\Prueba.txt",true);
            try
            {
                Contacto x = new Contacto();

                if (i < a.Length)
                {
                    x.Nombre = txtboxnombre.Text;
                    x.FechaN = dtpfecha.Value;
                    x.Telefono = txtboxtelefono.Text;
                    x.Correo = txtboxcorreo.Text;

                    a[i] = x;

                    sfd.Filter = "txt|*.txt";
                    if (sfd.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    sw.WriteLine(x.ToString());
                    sw.Close();
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }            
            sw.Close();


        }
        
    }   

}