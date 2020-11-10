using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.Enumerados;


namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }

        public bool EhCartao
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaCredito; }
        }

        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }

        public bool NaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefino; }
        }

    }
}
