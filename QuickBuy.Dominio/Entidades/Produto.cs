using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidades
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validade()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome deve ser informado");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("A Descrição deve ser informada");

        }
    }
}
