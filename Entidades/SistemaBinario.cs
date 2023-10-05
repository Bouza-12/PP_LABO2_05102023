using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        internal override double ValorNumerico
        {
            get
            {
                return Double.Parse(valor);
            }
        }

        public SistemaBinario(string valor) : base(valor)
        {

        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return this.BinarioADecimal();
            }
            return this;
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return String.IsNullOrWhiteSpace(valor) && EsSistemaBinarioValido(valor);
        }

        private bool EsSistemaBinarioValido(string valor)
        {
            foreach (char c in valor)
            {
                if (c == '0' || c == '1')
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private SistemaDecimal BinarioADecimal()
        {
            double suma = 0;
            if(this.valor != msgError)
            {
                string nueva = Revertir(valor);
                int contador = 0;
                if (EsSistemaBinarioValido(valor))
                {
                    foreach (char i in nueva)
                    {
                        if (i == '1')
                        {
                            suma += (int)Math.Pow(2, contador);
                        }
                        contador++;
                    }
                }
            }
            else
            {
                suma = double.MinValue;
            }
            return (SistemaDecimal)suma;
        }

        private string Revertir(string str)
        {
            return new string(str.Reverse().ToArray());
        }
        
        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
    }
}
