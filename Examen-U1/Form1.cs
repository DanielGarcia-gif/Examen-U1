using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Examen_U1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string edadCom(string txt)
        {

            string años = "";
            int año = int.Parse(txt.Substring(0, 2)) >= 0 && int.Parse(txt.Substring(0, 2)) <= 25 ? int.Parse(txt.Substring(0, 2)) + 2000 : int.Parse(txt.Substring(0, 2)) + 1900;
            año = DateTime.Now.Year - año;
            int mes = DateTime.Now.Month - int.Parse(txt.Substring(2, 2));
            int dia = DateTime.Now.Day - int.Parse(txt.Substring(4, 2));

            if (dia < 0)
            {
                dia += DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 1);
                mes--;
            }
            if (mes < 0)
            {
                mes += 12;
                año--;
            }

            años = año + " años " + mes + " meses " + dia + " dias ";

            return años;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butAbrir_Click(object sender, EventArgs e)
        {

            openFileDialogAbrir.FileName = "";
            DialogResult res = openFileDialogAbrir.ShowDialog();
            if (res == DialogResult.OK)
            {
                string txt = File.ReadAllText(openFileDialogAbrir.FileName);
                string[] ren = txt.Split("\n");

                for (int i = 0; i < ren.Length - 1; i++)
                {
                    string[] datos = ren[i].Split(",");
                    string edad = edadCom(datos[0].Substring(4, 6));
                    string sexo = datos[0].Substring(10, 1) == "M" ? "Mujer" : "Hombre";
                    dataGridViewDatos.Rows.Add(datos[0], datos[1], edad, sexo);

                }

            }
        }
    }
}
