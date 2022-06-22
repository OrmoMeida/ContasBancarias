using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasBancarias
{
    public partial class FrmContaBancaria : Form
    {
        private static List<ContaBancaria> _lstConta = new();
        private ContaBancaria contaAtual = null;
        private int Operation { get; set; }

        public FrmContaBancaria()
        {
            InitializeComponent();
            this.Size = new Size(682, 255);
            _lstConta = ContaBancaria.GeraContas();
        }

        public void ContaAtual()
        {
            TxtConta.Text = contaAtual.CodigoConta;
            TxtLimite.Text = contaAtual.Limite.ToString();
            TxtSaldo.Text = contaAtual.Saldo.ToString();

            RdComum.Checked = contaAtual.Tipo == 0;
            RdEspecial.Checked = contaAtual.Tipo == 1;

            contaAtual = null;
        }

        public void ResetCampos()
        {
            this.Size = new Size(682, 255);
            GpBoxInicial.Enabled = true;
            GpBoxMovimento.Enabled = false;
            TxtConta.Enabled = true;
            btnSacar.Enabled = true;
            btnDepositar.Enabled = true;
            btnSair.Enabled = true;

            TxtValor.Text = "";
        }

        public void Cadastrar()
        {
            if (TxtConta.Text == "")
                return;

            this.Size = new Size(682, 365);
            GpBoxInicial.Enabled = false;
            GpBoxMovimento.Enabled = true;
            btnDepositar.Enabled = false;
            btnSacar.Enabled = false;
            btnSair.Enabled = false;
        }

        private void TxtConta_Leave(object sender, EventArgs e)
        {
            try
            {
                contaAtual = _lstConta.Find(item => item.CodigoConta == TxtConta.Text);
                if (contaAtual == null)
                    throw new ArgumentNullException();
                ContaAtual();
            } 
            catch
            {
                MessageBox.Show("Essa conta não está cadastrada.", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtConta.Focus();
            }
        }

        private void TxtConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
                TxtConta_Leave(sender, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            Cadastrar();
            Operation = 0;
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Cadastrar();
            Operation = 1;
        }

        private void DtMovimento_Leave(object sender, EventArgs e)
        {
            bool validDay;
            validDay = DtMovimento.Value.DayOfWeek != DayOfWeek.Sunday && DtMovimento.Value.DayOfWeek != DayOfWeek.Saturday;

            if (!validDay)
            {
                MessageBox.Show("Impossível lançar em finais de semana: Data inválida.", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DtMovimento.Focus();
            }
        }

        private void TxtValor_Leave(object sender, EventArgs e)
        {
            if (TxtValor.Text.Trim() == "")
                return;

            try
            {
                if (double.Parse(TxtValor.Text.Trim()) <= 0)
                    throw new ArgumentException();
            } 
            catch
            {
                    MessageBox.Show("O valor da conta não deve ser negativo ou zero.", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtValor.Focus();
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
                TxtValor_Leave(sender, e);
        }

        private void DtMovimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
                DtMovimento_Leave(sender, e);
        }

        private void BtnLancar_Click(object sender, EventArgs e)
        {

            contaAtual = _lstConta.Find(item => item.CodigoConta == TxtConta.Text);

            if (TxtValor.Text != "")
            {
                double valor = Double.Parse(TxtValor.Text);

                if (Operation == 1)
                {
                    if (contaAtual.Tipo == 0 && (contaAtual.Saldo - valor) < 0)
                    {
                        MessageBox.Show("Impossível sacar: Saldo insuficiente.", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtValor.Focus();
                        contaAtual = null;
                        return;
                    }
                    else if (contaAtual.Tipo == 1 && (contaAtual.Saldo - valor) < contaAtual.Limite * -1)
                    {
                        MessageBox.Show("Impossível sacar: Saldo insuficiente.", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtValor.Focus();
                        contaAtual = null;
                        return;
                    }
                }

                valor = Operation == 1 ? valor * -1 : valor;
                contaAtual.Saldo += valor;
            }
            ContaAtual();
            ResetCampos();
        }
    }
}
