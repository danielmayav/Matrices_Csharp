using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz_de_Datos_DanielMayaVera
{
    public partial class frmMatrices : Form
    {
        public frmMatrices()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string[,] personas = new string[10, 4]
            {
                {"123456", "Pablo", "Rodriguez", "24" },
                {"124564", "Sandra", "Perez", "35" },
                {"164658", "Pedro", "Sanchez", "44" },
                {"132654", "Juan", "Vera", "23" },
                {"111265", "Santiago", "Restrepo", "52" },
                {"964421", "Esteban", "Moreno", "19" },
                {"321654", "Luisa", "Cardona", "36" },
                {"795463", "Paula", "Ospina", "38" },
                {"579564", "Carolina", "Uribe", "45" },
                {"223546", "Carlos", "Botero", "32" }
            };

            int fila = 10;
            int column = 4;

            dgvMatriz.ColumnCount = column;
            dgvMatriz.RowCount = fila;

            dgvMatriz.Columns[0].HeaderText = "CEDULA";
            dgvMatriz.Columns[1].HeaderText = "NOMBRE";
            dgvMatriz.Columns[2].HeaderText = "APELLIDO";
            dgvMatriz.Columns[3].HeaderText = "EDAD";

            for(int i = 0; i < fila - 1; i++)
            {
                for(int j = 0; j < column - 1; j++)
                {
                    dgvMatriz.Rows[i].Cells[j].Value = personas[i,j].ToString();
                }
            }


        }

    }
}
