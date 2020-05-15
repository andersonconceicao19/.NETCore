using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.Automapper
{
    public class DomainToViewModel : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModeltoDomain"; }
        }

        public DomainToViewModel()
        {
            Mapper.CreateMap< ProdutoViewModel, Produto>();
            Mapper.CreateMap< ClienteViewModel, Cliente> ();
          
        }
       
            
    }
}