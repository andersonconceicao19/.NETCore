
using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.Automapper
{
    public class AutoMapperConfig
    {
        
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ViewModelToViewDomain>();
                x.AddProfile<DomainToViewModel>();
               
            });
        }


       
    }
}