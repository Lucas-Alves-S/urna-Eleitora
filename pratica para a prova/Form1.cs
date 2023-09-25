namespace pratica_para_a_prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI.formPresidente presidente = new UI.formPresidente();
            presidente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UI.formResultado resultado = new UI.formResultado();
            resultado.Show();
        }
    }
}