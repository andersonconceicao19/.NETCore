using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.Automapper
{
    public class ViewModelToViewDomain : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModel"; }
        }
        

        public ViewModelToViewDomain()
        {
            Mapper.CreateMap< Produto, ProdutoViewModel>();
            Mapper.CreateMap<  Cliente, ClienteViewModel>();

        }

    }
}