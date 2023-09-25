using pratica_para_a_prova.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratica_para_a_prova.UI
{
    public partial class formResultado : Form
    {
        public formResultado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNull.Text = votesControl.votosBrancos.ToString();
            txtLula.Text = votesControl.votosLula.ToString();
            txtBolsonaro.Text = votesControl.votosBolsonaro.ToString();
        }
    }
}
