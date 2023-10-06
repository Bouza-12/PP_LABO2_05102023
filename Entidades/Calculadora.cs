using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private static ESistema sistema;

        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }
        public List<string> Operaciones
        {
            get { return operaciones; }
        }
        public Numeracion PrimerOperando
        {
            get { return primerOperando; }
            set { primerOperando = value; }
        }
        public Numeracion SegundoOperando
        {
            get { return segundoOperando; }
            set { segundoOperando = value; }
        }
        public Numeracion Resultado
        {
            get { return resultado; }
        }
        public static ESistema Sistema 
        { 
            get { return sistema; } 
            set { sistema = value; } 
        }
        static Calculadora()
        {

        }

        public Calculadora()
        {
            this.operaciones = new List<string>();
        }
        public Calculadora(string nombreAlumno) : this()
        {
            this.nombreAlumno = nombreAlumno;
        }

        public void Calcular()
        {
            Calcular('+');
        }
        public void Calcular(char operador)
        {
            if(PrimerOperando == SegundoOperando)
            {
                switch(operador)
                {
                    case '+':
                        this.resultado = MapeaResultado(PrimerOperando.ValorNumerico + SegundoOperando.ValorNumerico);
                        break;
                    case '-':
                        this.resultado = MapeaResultado(PrimerOperando.ValorNumerico - SegundoOperando.ValorNumerico);
                        break;
                    case '*':
                        this.resultado = MapeaResultado(PrimerOperando.ValorNumerico * SegundoOperando.ValorNumerico);
                        break;
                    case '/':
                        if(SegundoOperando.ValorNumerico != 0)
                        {
                            this.resultado = MapeaResultado(PrimerOperando.ValorNumerico / SegundoOperando.ValorNumerico);
                        }
                        else
                        {
                            this.resultado = MapeaResultado(Double.MinValue);
                        }
                        break;
                }
            }
            else
            {
                this.resultado = MapeaResultado(Double.MinValue);
            }
        }

        private Numeracion MapeaResultado(double valor)
        {
            if(Sistema == ESistema.Decimal)
            {
                return (SistemaDecimal)valor;
            }
            else
            {
                return (SistemaBinario)valor.ToString();
            }
        }

        public void ActualizaHistorialDeOperaciones(char operando)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sistema {Sistema}");
            sb.AppendLine($"Primer Operando: {PrimerOperando.Valor}");
            sb.AppendLine($"Operador: {operando}");
            sb.AppendLine($"Segundo Operando: {SegundoOperando.Valor}");
            Calcular(operando);
            sb.AppendLine($"Resultado {Resultado.Valor}");
        }
        public void EliminarHistorialDeOperaciones()
        {
            operaciones.Clear();
        }
    }
}
