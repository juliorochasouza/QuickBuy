using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidades
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public  string Senha { get; set; }
        public string  Nome { get; set; }
        public string SobreNome { get; set; }

        // usuario faz parte de varios pedidos
        // um para muitos
        // colocar como public virtual para o core sobrepor
        // do lado do pedido, colocar uma propriedade public virtual usuario usuario
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validade()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O Nome deve ser informado");

            if (string.IsNullOrEmpty(SobreNome))
                AdicionarCritica("O SobreNome deve ser informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("A Senha deve ser informada");

            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("O Email deve ser informado");

        }
    }
}
