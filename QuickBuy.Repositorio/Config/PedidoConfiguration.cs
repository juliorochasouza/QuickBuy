﻿using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.DataPedido)
                .IsRequired();

            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired();

            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.NumeroEndereco)
                .IsRequired()
                .HasMaxLength(100);

            // Aqui esta configurando que
            // Um pedido so pode ter um usuario
            // Core reconhece e faz o mapeamento corretamente
            builder.HasOne(p => p.Usuario);
        }
    }
}
