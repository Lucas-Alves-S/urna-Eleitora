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
    public partial class formPresidente : Form
    {
        public formPresidente()
        {
            InitializeComponent();
        }

        string nomeCandidato;

        private void updatePhoto()
        {
            if (txtCandidato.Text == "13")
            {
                nomeCandidato = "Luiz Inácio Lula da Silva";
                txtNomeCandidato.Text = nomeCandidato;
                Image foto = Image.FromFile("../../../assets/lula.jpeg");
                pictureBox1.Image = foto;
            }
            else if (txtCandidato.Text == "22")
            {
                nomeCandidato = "Jair Messias Bolsonaro";
                txtNomeCandidato.Text = nomeCandidato;
                Image foto = Image.FromFile("../../../assets/bolsonaro.jpeg");
                pictureBox1.Image = foto;
            }
            else
            {
                nomeCandidato = "NULO";
                txtNomeCandidato.Text = "VOTO NULO";
                Image foto = Image.FromFile("../../../assets/clear.jpg");
                pictureBox1.Image = foto;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCandidato.Text += "1";
            updatePhoto();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCandidato.Text += "2";
            updatePhoto();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCandidato.Text += "3";
            updatePhoto();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCandidato.Text += "4";
            updatePhoto();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCandidato.Text += "5";
            updatePhoto();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCandidato.Text += "6";
            updatePhoto();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCandidato.Text += "7";
            updatePhoto();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCandidato.Text += "8";
            updatePhoto();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCandidato.Text += "9";
            updatePhoto();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCandidato.Text += "0";
            updatePhoto();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmar voto em Branco?", "Confirmar Voto", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                votesControl.votosBrancos++;
                MessageBox.Show("Voto armazenado com sucesso");
                this.Close();
            }

        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            txtCandidato.Clear();
            txtNomeCandidato.Text = "";
            pictureBox1.Image = null;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Confirmar voto no candidato {nomeCandidato}?", "Confirmar Voto", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (txtCandidato.Text == "13")
                {
                    votesControl.votosLula++;
                    MessageBox.Show("Voto armazenado com sucesso");
                    this.Close();
                }
                else if (txtCandidato.Text == "22")
                {
                    votesControl.votosBolsonaro++;
                    MessageBox.Show("Voto armazenado com sucesso");
                    this.Close();
                }
                else
                {
                    votesControl.votosBrancos++;
                    MessageBox.Show("Voto armazenado com sucesso");
                    this.Close();
                }
            }
            else if (result == DialogResult.No)
            {
                txtCandidato.Clear();
                txtNomeCandidato.Text = "";
                pictureBox1.Image = null;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
