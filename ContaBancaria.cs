using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBancarias
{
    class ContaBancaria
    {
        public string CodigoConta { get; set; }
        public int Tipo { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public ContaBancaria() { }

        public ContaBancaria(string codigoConta, int tipo, double saldo, double limite)
        {
            CodigoConta = codigoConta;
            Tipo = tipo;
            Saldo = saldo;
            Limite = limite;
        }

        public static List<ContaBancaria> GeraContas()
        {
            List<ContaBancaria> _listContas = new();
            _listContas.Add(new ContaBancaria("1-123", 0, 1000, 0));
            _listContas.Add(new ContaBancaria("1-321", 0, 5500, 0));
            _listContas.Add(new ContaBancaria("2-500", 1, 58900, 1500));
            _listContas.Add(new ContaBancaria("2-501", 1, 103400, 3500));
            return _listContas;
        }
    }
}
