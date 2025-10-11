using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    public partial class Form1 : Form
    {
        public string ConexionCatalogos = "Server=DANIFLOW\\SQLEXPRESS;"
                            + " Database=Catalogos;"
                            + " Integrated Security=True; "
                            + " TrustServerCertificate=True";
        public string ConexionTablas = "Server=DANIFLOW\\SQLEXPRESS;"
                            + " Database=Tablas;"
                            + " Integrated Security=True; "
                            + " TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
