using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration() 
            : this("MyProfile")
        {
        }
        protected AutoMapperProfileConfiguration(string profileName)
            : base(profileName)
        {
            CreateMap<DataAccess.Customer, Models.Customer>();
            CreateMap<DataAccess.Address, Models.Address>();
            CreateMap<DataAccess.OrderHeader, Models.OrderHeader>();
            CreateMap<DataAccess.OrderDetail, Models.OrderDetail>();
            CreateMap<DataAccess.Product, Models.Product>();
            CreateMap<DataAccess.ProductRecipe, Models.ProductRecipe>();
            CreateMap<DataAccess.Ingredient, Models.Ingredient>();
            CreateMap<DataAccess.Inventory, Models.Inventory>();
            CreateMap<DataAccess.Store, Models.Store>();

            CreateMap<Models.Customer, DataAccess.Customer>();
            CreateMap<Models.Address, DataAccess.Address>();
            CreateMap<Models.OrderHeader, DataAccess.OrderHeader>();
            CreateMap<Models.OrderDetail, DataAccess.OrderDetail>();
            CreateMap<Models.Product, DataAccess.Product>();
            CreateMap<Models.ProductRecipe, DataAccess.ProductRecipe>();
            CreateMap<Models.Ingredient, DataAccess.Ingredient>();
            CreateMap<Models.Inventory, DataAccess.Inventory>();
            CreateMap<Models.Store, DataAccess.Store>();
        }
    }
}
