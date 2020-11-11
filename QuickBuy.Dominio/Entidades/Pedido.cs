using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidades
    {

        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        // colocar o mesmo nome da classe e mesmo public int (UsuarioId), pois assim
        // o core consegue mapear automaticamente
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validade()
        {
            LimparMensagensValidacao();
            if (!ItensPedidos.Any())
                AdicionarCritica("O itens de pedido devem ser informados");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("O CEP deve ser informado");

            if (FormaPagamentoId == 0)
                AdicionarCritica("A Forma de Pagamento deve ser informada");

        }
    }
}
