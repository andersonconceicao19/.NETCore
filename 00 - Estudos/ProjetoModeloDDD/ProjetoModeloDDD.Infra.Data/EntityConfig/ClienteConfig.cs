using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        /* No .net Framework funciona diferente.
         * Há a necessidade de set as propriedades com configurações singulares dento do contrutor*/
        public ClienteConfig()
        {
            HasKey(x => x.Id);
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(20);

            Property(p => p.Sobrenome)
                .IsRequired()
                .HasMaxLength(20);


            Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(50);



        }
    }
}
