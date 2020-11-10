using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<FormaPagamento> builder)
        {
            // builder.Haskey
        }
    }
}
