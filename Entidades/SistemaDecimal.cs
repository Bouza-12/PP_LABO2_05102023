using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        internal override double ValorNumerico
        {
            get
            {
                return Double.Parse(valor);
            }
        }

        public SistemaDecimal(string valor) : base(valor)
        {

        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if(sistema == ESistema.Binario)
            {
                return this.DecimalABinario();
            }
            return this;
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return String.IsNullOrWhiteSpace(valor) && Double.TryParse(valor, out double ValorNumerico);
        }
        private SistemaBinario DecimalABinario()
        {
            {
                List<int> binario = new List<int>();
                int valor = (int)ValorNumerico;
                Math.Abs(valor);
                if (valor >= 0)
                {

                    while (valor > 1)
                    {
                        binario.Add(valor % 2);
                        valor = valor / 2;
                    }
                    if (valor <= 1)
                        binario.Add(valor);

                    binario.Reverse();
                    StringBuilder sb = new StringBuilder();
                    foreach (int i in binario)
                    {
                        sb.Append($"{i}");
                    }
                    return new SistemaBinario(sb.ToString());
                }
                return new SistemaBinario(msgError);
            }
        

        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return (SistemaDecimal)valor.ToString();
        }
        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
}
