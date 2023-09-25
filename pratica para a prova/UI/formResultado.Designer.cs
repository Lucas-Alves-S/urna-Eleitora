namespace pratica_para_a_prova.UI
{
    partial class formResultado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNull = new TextBox();
            txtLula = new TextBox();
            txtBolsonaro = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 158);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 0;
            label1.Text = "Número de votos nulos/brancos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 187);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "Número de votos Lula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 216);
            label3.Name = "label3";
            label3.Size = new Size(158, 15);
            label3.TabIndex = 2;
            label3.Text = "Número de votos Bolsonaro:";
            // 
            // txtNull
            // 
            txtNull.Enabled = false;
            txtNull.Location = new Point(422, 155);
            txtNull.Name = "txtNull";
            txtNull.Size = new Size(100, 23);
            txtNull.TabIndex = 3;
            // 
            // txtLula
            // 
            txtLula.Enabled = false;
            txtLula.Location = new Point(422, 184);
            txtLula.Name = "txtLula";
            txtLula.Size = new Size(100, 23);
            txtLula.TabIndex = 4;
            // 
            // txtBolsonaro
            // 
            txtBolsonaro.Enabled = false;
            txtBolsonaro.Location = new Point(422, 213);
            txtBolsonaro.Name = "txtBolsonaro";
            txtBolsonaro.Size = new Size(100, 23);
            txtBolsonaro.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(141, 158);
            button1.Name = "button1";
            button1.Size = new Size(75, 78);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // formResultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtBolsonaro);
            Controls.Add(txtLula);
            Controls.Add(txtNull);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formResultado";
            Text = "formResultado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNull;
        private TextBox txtLula;
        private TextBox txtBolsonaro;
        private Button button1;
    }
}