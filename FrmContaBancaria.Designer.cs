
namespace ContasBancarias
{
    partial class FrmContaBancaria
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
            this.GpBoxInicial = new System.Windows.Forms.GroupBox();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.LabelLimites = new System.Windows.Forms.Label();
            this.TxtLimite = new System.Windows.Forms.TextBox();
            this.RdEspecial = new System.Windows.Forms.RadioButton();
            this.RdComum = new System.Windows.Forms.RadioButton();
            this.LabelNrConta = new System.Windows.Forms.Label();
            this.TxtConta = new System.Windows.Forms.TextBox();
            this.GpBoxMovimento = new System.Windows.Forms.GroupBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.BtnLancar = new System.Windows.Forms.Button();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.DtMovimento = new System.Windows.Forms.DateTimePicker();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.GpBoxInicial.SuspendLayout();
            this.GpBoxMovimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpBoxInicial
            // 
            this.GpBoxInicial.BackColor = System.Drawing.Color.Gainsboro;
            this.GpBoxInicial.Controls.Add(this.labelSaldo);
            this.GpBoxInicial.Controls.Add(this.TxtSaldo);
            this.GpBoxInicial.Controls.Add(this.LabelLimites);
            this.GpBoxInicial.Controls.Add(this.TxtLimite);
            this.GpBoxInicial.Controls.Add(this.RdEspecial);
            this.GpBoxInicial.Controls.Add(this.RdComum);
            this.GpBoxInicial.Controls.Add(this.LabelNrConta);
            this.GpBoxInicial.Controls.Add(this.TxtConta);
            this.GpBoxInicial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GpBoxInicial.Location = new System.Drawing.Point(12, 12);
            this.GpBoxInicial.Name = "GpBoxInicial";
            this.GpBoxInicial.Size = new System.Drawing.Size(645, 100);
            this.GpBoxInicial.TabIndex = 0;
            this.GpBoxInicial.TabStop = false;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(499, 22);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(53, 18);
            this.labelSaldo.TabIndex = 7;
            this.labelSaldo.Text = "Saldo";
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Enabled = false;
            this.TxtSaldo.Location = new System.Drawing.Point(499, 53);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(124, 27);
            this.TxtSaldo.TabIndex = 6;
            // 
            // LabelLimites
            // 
            this.LabelLimites.AutoSize = true;
            this.LabelLimites.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelLimites.Location = new System.Drawing.Point(340, 22);
            this.LabelLimites.Name = "LabelLimites";
            this.LabelLimites.Size = new System.Drawing.Size(59, 18);
            this.LabelLimites.TabIndex = 5;
            this.LabelLimites.Text = "Limite";
            // 
            // TxtLimite
            // 
            this.TxtLimite.Enabled = false;
            this.TxtLimite.Location = new System.Drawing.Point(340, 53);
            this.TxtLimite.Name = "TxtLimite";
            this.TxtLimite.Size = new System.Drawing.Size(124, 27);
            this.TxtLimite.TabIndex = 4;
            // 
            // RdEspecial
            // 
            this.RdEspecial.AutoSize = true;
            this.RdEspecial.Enabled = false;
            this.RdEspecial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdEspecial.Location = new System.Drawing.Point(151, 54);
            this.RdEspecial.Name = "RdEspecial";
            this.RdEspecial.Size = new System.Drawing.Size(147, 22);
            this.RdEspecial.TabIndex = 3;
            this.RdEspecial.TabStop = true;
            this.RdEspecial.Text = "Conta Especial";
            this.RdEspecial.UseVisualStyleBackColor = true;
            // 
            // RdComum
            // 
            this.RdComum.AutoSize = true;
            this.RdComum.Enabled = false;
            this.RdComum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdComum.Location = new System.Drawing.Point(151, 22);
            this.RdComum.Name = "RdComum";
            this.RdComum.Size = new System.Drawing.Size(141, 22);
            this.RdComum.TabIndex = 2;
            this.RdComum.TabStop = true;
            this.RdComum.Text = "Conta Comum";
            this.RdComum.UseVisualStyleBackColor = true;
            // 
            // LabelNrConta
            // 
            this.LabelNrConta.AutoSize = true;
            this.LabelNrConta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelNrConta.Location = new System.Drawing.Point(20, 19);
            this.LabelNrConta.Name = "LabelNrConta";
            this.LabelNrConta.Size = new System.Drawing.Size(84, 18);
            this.LabelNrConta.TabIndex = 1;
            this.LabelNrConta.Text = "Nr. Conta";
            // 
            // TxtConta
            // 
            this.TxtConta.Location = new System.Drawing.Point(20, 53);
            this.TxtConta.MaxLength = 10;
            this.TxtConta.Name = "TxtConta";
            this.TxtConta.Size = new System.Drawing.Size(111, 27);
            this.TxtConta.TabIndex = 0;
            this.TxtConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConta_KeyPress);
            this.TxtConta.Leave += new System.EventHandler(this.TxtConta_Leave);
            // 
            // GpBoxMovimento
            // 
            this.GpBoxMovimento.BackColor = System.Drawing.Color.Gainsboro;
            this.GpBoxMovimento.Controls.Add(this.labelValor);
            this.GpBoxMovimento.Controls.Add(this.labelData);
            this.GpBoxMovimento.Controls.Add(this.BtnLancar);
            this.GpBoxMovimento.Controls.Add(this.TxtValor);
            this.GpBoxMovimento.Controls.Add(this.DtMovimento);
            this.GpBoxMovimento.Enabled = false;
            this.GpBoxMovimento.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GpBoxMovimento.Location = new System.Drawing.Point(9, 212);
            this.GpBoxMovimento.Name = "GpBoxMovimento";
            this.GpBoxMovimento.Size = new System.Drawing.Size(648, 102);
            this.GpBoxMovimento.TabIndex = 1;
            this.GpBoxMovimento.TabStop = false;
            this.GpBoxMovimento.Text = "MOVIMENTO";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValor.Location = new System.Drawing.Point(252, 35);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(49, 18);
            this.labelValor.TabIndex = 4;
            this.labelValor.Text = "Valor";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelData.Location = new System.Drawing.Point(14, 35);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(47, 18);
            this.labelData.TabIndex = 3;
            this.labelData.Text = "Data";
            // 
            // BtnLancar
            // 
            this.BtnLancar.BackColor = System.Drawing.Color.Gray;
            this.BtnLancar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnLancar.Location = new System.Drawing.Point(536, 40);
            this.BtnLancar.Name = "BtnLancar";
            this.BtnLancar.Size = new System.Drawing.Size(90, 33);
            this.BtnLancar.TabIndex = 2;
            this.BtnLancar.Text = "Lançar";
            this.BtnLancar.UseVisualStyleBackColor = false;
            this.BtnLancar.Click += new System.EventHandler(this.BtnLancar_Click);
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(250, 65);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(144, 22);
            this.TxtValor.TabIndex = 1;
            this.TxtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValor_KeyPress);
            this.TxtValor.Leave += new System.EventHandler(this.TxtValor_Leave);
            // 
            // DtMovimento
            // 
            this.DtMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtMovimento.Location = new System.Drawing.Point(9, 65);
            this.DtMovimento.Name = "DtMovimento";
            this.DtMovimento.Size = new System.Drawing.Size(122, 22);
            this.DtMovimento.TabIndex = 0;
            this.DtMovimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtMovimento_KeyPress);
            this.DtMovimento.Leave += new System.EventHandler(this.DtMovimento_Leave);
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDepositar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDepositar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDepositar.Location = new System.Drawing.Point(15, 133);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(191, 56);
            this.btnDepositar.TabIndex = 2;
            this.btnDepositar.Text = "DEPOSITAR";
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.BackColor = System.Drawing.Color.Salmon;
            this.btnSacar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSacar.Location = new System.Drawing.Point(212, 132);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(191, 57);
            this.btnSacar.TabIndex = 3;
            this.btnSacar.Text = "SACAR";
            this.btnSacar.UseVisualStyleBackColor = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Gray;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(545, 146);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 33);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmContaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 326);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.GpBoxMovimento);
            this.Controls.Add(this.GpBoxInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContaBancaria";
            this.Text = "Form1";
            this.GpBoxInicial.ResumeLayout(false);
            this.GpBoxInicial.PerformLayout();
            this.GpBoxMovimento.ResumeLayout(false);
            this.GpBoxMovimento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpBoxInicial;
        private System.Windows.Forms.GroupBox GpBoxMovimento;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label LabelNrConta;
        private System.Windows.Forms.TextBox TxtConta;
        private System.Windows.Forms.RadioButton RdEspecial;
        private System.Windows.Forms.RadioButton RdComum;
        private System.Windows.Forms.Label LabelLimites;
        private System.Windows.Forms.TextBox TxtLimite;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Button BtnLancar;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.DateTimePicker DtMovimento;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelData;
    }
}

