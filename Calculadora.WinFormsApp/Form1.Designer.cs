
namespace Calculadora.WinFormsApp
{
    partial class TelaCalcular
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelPrimeiroN = new Label();
            labalSegundoN = new Label();
            primeiroN = new TextBox();
            segundoN = new TextBox();
            resultado = new Label();
            btnCalcular = new Button();
            btnLimpar = new Button();
            ListBoxHistorico = new ListBox();
            groupBox1 = new GroupBox();
            selecioneOperacao = new Label();
            radioBtnSubtracao = new RadioButton();
            radioBtnDivisao = new RadioButton();
            radioBtnMultiplicacao = new RadioButton();
            radioBtnAdicao = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelPrimeiroN
            // 
            labelPrimeiroN.AutoSize = true;
            labelPrimeiroN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrimeiroN.Location = new Point(12, 26);
            labelPrimeiroN.Name = "labelPrimeiroN";
            labelPrimeiroN.Size = new Size(162, 25);
            labelPrimeiroN.TabIndex = 6;
            labelPrimeiroN.Text = "Primeiro Número:";
            // 
            // labalSegundoN
            // 
            labalSegundoN.AutoSize = true;
            labalSegundoN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labalSegundoN.Location = new Point(12, 75);
            labalSegundoN.Name = "labalSegundoN";
            labalSegundoN.Size = new Size(165, 25);
            labalSegundoN.TabIndex = 7;
            labalSegundoN.Text = "Segundo Número:";
            // 
            // primeiroN
            // 
            primeiroN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            primeiroN.Location = new Point(180, 23);
            primeiroN.Name = "primeiroN";
            primeiroN.Size = new Size(100, 33);
            primeiroN.TabIndex = 9;
            // 
            // segundoN
            // 
            segundoN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            segundoN.Location = new Point(180, 72);
            segundoN.Name = "segundoN";
            segundoN.Size = new Size(100, 33);
            segundoN.TabIndex = 10;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultado.Location = new Point(323, 39);
            resultado.Name = "resultado";
            resultado.Size = new Size(43, 50);
            resultado.TabIndex = 11;
            resultado.Text = "0";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.ControlLight;
            btnCalcular.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(12, 337);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(503, 42);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.ControlLight;
            btnLimpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(12, 385);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(503, 42);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // ListBoxHistorico
            // 
            ListBoxHistorico.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListBoxHistorico.FormattingEnabled = true;
            ListBoxHistorico.ItemHeight = 25;
            ListBoxHistorico.Location = new Point(15, 442);
            ListBoxHistorico.Name = "ListBoxHistorico";
            ListBoxHistorico.Size = new Size(500, 229);
            ListBoxHistorico.TabIndex = 14;
            ListBoxHistorico.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(selecioneOperacao);
            groupBox1.Controls.Add(radioBtnSubtracao);
            groupBox1.Controls.Add(radioBtnDivisao);
            groupBox1.Controls.Add(radioBtnMultiplicacao);
            groupBox1.Controls.Add(radioBtnAdicao);
            groupBox1.Location = new Point(12, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 200);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // selecioneOperacao
            // 
            selecioneOperacao.AutoSize = true;
            selecioneOperacao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selecioneOperacao.Location = new Point(6, 19);
            selecioneOperacao.Name = "selecioneOperacao";
            selecioneOperacao.Size = new Size(192, 25);
            selecioneOperacao.TabIndex = 13;
            selecioneOperacao.Text = "Selecione a operação";
            // 
            // radioBtnSubtracao
            // 
            radioBtnSubtracao.AutoSize = true;
            radioBtnSubtracao.Font = new Font("Segoe UI", 14.25F);
            radioBtnSubtracao.Location = new Point(9, 82);
            radioBtnSubtracao.Name = "radioBtnSubtracao";
            radioBtnSubtracao.Size = new Size(115, 29);
            radioBtnSubtracao.TabIndex = 12;
            radioBtnSubtracao.TabStop = true;
            radioBtnSubtracao.Text = "Subtração";
            radioBtnSubtracao.UseVisualStyleBackColor = true;
            // 
            // radioBtnDivisao
            // 
            radioBtnDivisao.AutoSize = true;
            radioBtnDivisao.Font = new Font("Segoe UI", 14.25F);
            radioBtnDivisao.Location = new Point(9, 117);
            radioBtnDivisao.Name = "radioBtnDivisao";
            radioBtnDivisao.Size = new Size(91, 29);
            radioBtnDivisao.TabIndex = 11;
            radioBtnDivisao.TabStop = true;
            radioBtnDivisao.Text = "Divisão";
            radioBtnDivisao.UseVisualStyleBackColor = true;
            // 
            // radioBtnMultiplicacao
            // 
            radioBtnMultiplicacao.AutoSize = true;
            radioBtnMultiplicacao.Font = new Font("Segoe UI", 14.25F);
            radioBtnMultiplicacao.Location = new Point(9, 152);
            radioBtnMultiplicacao.Name = "radioBtnMultiplicacao";
            radioBtnMultiplicacao.Size = new Size(144, 29);
            radioBtnMultiplicacao.TabIndex = 10;
            radioBtnMultiplicacao.TabStop = true;
            radioBtnMultiplicacao.Text = "Multiplicaçao";
            radioBtnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // radioBtnAdicao
            // 
            radioBtnAdicao.AutoSize = true;
            radioBtnAdicao.Font = new Font("Segoe UI", 14.25F);
            radioBtnAdicao.Location = new Point(9, 47);
            radioBtnAdicao.Name = "radioBtnAdicao";
            radioBtnAdicao.Size = new Size(88, 29);
            radioBtnAdicao.TabIndex = 9;
            radioBtnAdicao.TabStop = true;
            radioBtnAdicao.Text = "Adição";
            radioBtnAdicao.UseVisualStyleBackColor = true;
            // 
            // TelaCalcular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(527, 683);
            Controls.Add(groupBox1);
            Controls.Add(ListBoxHistorico);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(resultado);
            Controls.Add(segundoN);
            Controls.Add(primeiroN);
            Controls.Add(labalSegundoN);
            Controls.Add(labelPrimeiroN);
            Name = "TelaCalcular";
            Text = "Calculadora";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelPrimeiroN;
        private Label labalSegundoN;
        private TextBox primeiroN;
        private TextBox segundoN;
        private Label resultado;
        private Button btnCalcular;
        private Button btnLimpar;
        private ListBox ListBoxHistorico;
        private GroupBox groupBox1;
        private Label selecioneOperacao;
        private RadioButton radioBtnSubtracao;
        private RadioButton radioBtnDivisao;
        private RadioButton radioBtnMultiplicacao;
        private RadioButton radioBtnAdicao;
    }
}
