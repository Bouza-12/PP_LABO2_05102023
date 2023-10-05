using System.Runtime.CompilerServices;

namespace Entidades
{
    public enum ESistema { Binario, Decimal}
    public abstract class Numeracion
    {
        protected static string msgError;
        protected string valor;

        public string Valor { get { return valor; } }

        internal abstract double ValorNumerico { get; }



        static Numeracion()
        {
            msgError = "Numero Invalido";
        }

        protected Numeracion(string valor)
        {
            this.InicializarValor(valor);
        }

        private void InicializarValor(string valor)
        {
            if(Double.TryParse(valor, out double valorDouble) && EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                valor = msgError;
            }
        }

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected bool EsNumeracionValida(string valor)
        {
            return valor is not null && !(valor.Contains(" "));
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1 is not null && n2 is not null && n1.GetType() == n2.GetType();
        }
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }
        public static explicit operator double(Numeracion numeracion)
        {
            return numeracion.ValorNumerico;
        }
    }
}