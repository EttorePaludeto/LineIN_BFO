using LineIN.BFO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LineIN.BFO.Data.Mapping
{
    public class ParticipanteMap : IEntityTypeConfiguration<Participante>
    {
        public void Configure(EntityTypeBuilder<Participante> builder)
        {
            builder.ToTable("Participante");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).HasColumnName("Id");
            builder.Property(i => i.CNPJouCPF).HasColumnName("CNPJouCPF");
            builder.Property(i => i.Nome).HasColumnName("Nome");
            builder.Property(i => i.Email).HasColumnName("Email");

            builder.OwnsOne(i => i.Endereco, end =>
            {
                end.Property(e => e.Municipio).HasColumnName("Municipio");
                end.Property(e => e.Logradouro).HasColumnName("Logradouro");
                end.Property(e => e.Numero).HasColumnName("Numero");
                end.Property(e => e.Complemento).HasColumnName("Complemento");
                end.Property(e => e.Bairro).HasColumnName("Bairro");
                end.Property(e => e.UF).HasColumnName("UF");
                end.Property(e => e.CEP).HasColumnName("CEP");
            });

        }
    }
}
