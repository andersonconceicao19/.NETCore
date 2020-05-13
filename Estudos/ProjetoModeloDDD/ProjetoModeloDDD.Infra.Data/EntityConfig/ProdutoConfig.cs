using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(x => x.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);
            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(200);
            Property(p => p.Preco)
                .IsRequired();

            HasRequired(x => x.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);             
                
        }
    }
}
