using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTestSQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.

            string consulta = "INSERT INTO Region (RegioID,RegionDescription) VALUES(5,'Centro')";
            conexion.EjecutaConsulta(consulta);


            string consulta = "select * from region order by RegionID";
            DataTable dt = conexion.Selecciona(consulta);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.Conectar();

            conexion.Desconectar();
        }

        private void CargarDatos()
        {
            string consulta = 
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string consulta = "delete from region where regionid="+id;

            conexion.EjecutaConsulta(consulta);
        }
    }
}
