using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModeloContext : DbContext
    {
       

        public ProjetoModeloContext()
            : base("ProjetoModeloDDD")
        {
            var ensureDLLIsCopied =
                System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Desabilitando a plurarização das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
            /** Desabilitando que delete em cascata um item que depende de outro. 
             * Em relacionamento 1x1 or ManyxMany*/
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Configurando para que todas propriedades strings recebam o valor padrao de varchar 100
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            //Adicionando as configurações da modelagem nas tabelas.
            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());

        }

        
        public override async Task<int> SaveChangesAsync()
        {
            /** Sobreescrevendo o método SaveChange com o intuito de aplicar 2 novos comportamentos.
         * 
         * 1 - Quando o Status de processamento for para adicionar algum item, será setado a data atual no campo de Datacadastro
         * 
         * 2 - Quando o Ocorrer alguma modificação no cadastro, não ocorrerá mudança no campo da Data do cadastro.
         */
            foreach (var Entry in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if(Entry.State == EntityState.Added)
                {
                    Entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if(Entry.State == EntityState.Modified)
                {
                    Entry.Property("DataCadastro").IsModified = false;
                }

            }

            return await base.SaveChangesAsync();
        }
    }
}
