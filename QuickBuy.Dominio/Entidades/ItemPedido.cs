using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidades
    {

        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validade()
        {
            if (ProdutoId == 0)
                AdicionarCritica("O Produto deve ser informado");

            if (Quantidade == 0)
                AdicionarCritica("A Quantidade deve ser informada");
        }
    }
}
