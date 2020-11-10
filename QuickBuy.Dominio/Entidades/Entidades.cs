using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidades
    {

        private List<string> _mensagensValidacao { get; set; }

        private List<string> MensagemValidacao 
        { 
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
                
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }


        public abstract void Validade();
        protected bool EhValido
        { 
            get { return !MensagemValidacao.Any(); }
        }


    }
}
