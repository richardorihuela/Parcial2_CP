using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consumirDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ci = Convert.ToInt32(ci_e.Text);
            ServiceReference1.WebServiceSoap ws = new ServiceReference1.WebServiceSoapClient();
            DataSet datos = new DataSet();
            datos = ws.alumno(ci);
            //nombre_s.Text = datos.Tables["Tabla1"].Rows[0]["nombre"].ToString();
            nombre_s.Text = datos.Tables[0].Rows[0][1].ToString();
            paterno_s.Text = datos.Tables[0].Rows[0][2].ToString();
            materno_s.Text = datos.Tables[0].Rows[0][3].ToString();
            telefono_s.Text = datos.Tables[0].Rows[0][4].ToString();
            //paterno_s.Text = datos.Tables["Tabla1"].Rows[0]["paterno"].ToString();
            //materno_s.Text= datos.Tables["Tabla1"].Rows[0]["materno"].ToString();
            //telefono_s.Text = datos.Tables["Tabla1"].Rows[0]["telefono"].ToString();
        }
    }
}
