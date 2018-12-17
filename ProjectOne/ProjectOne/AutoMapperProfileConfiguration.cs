//using AutoMapper;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ProjectOne
//{
//    public class AutoMapperProfileConfiguration : Profile
//    {
//        public AutoMapperProfileConfiguration() 
//            : this("MyProfile")
//        {
//        }
//        protected AutoMapperProfileConfiguration(string profileName)
//            : base(profileName)
//        {
//            CreateMap<DataAccess.Customer, Library.Customer>();
//            CreateMap<DataAccess.Address, Library.Address>();
//            CreateMap<DataAccess.OrderHeader, Library.OrderHeader>();
//            CreateMap<DataAccess.OrderDetail, Library.OrderDetail>();
//            CreateMap<DataAccess.Product, Library.Product>();
//            CreateMap<DataAccess.ProductRecipe, Library.ProductRecipe>();
//            CreateMap<DataAccess.Ingredient, Library.Ingredient>();
//            CreateMap<DataAccess.Inventory, Library.Inventory>();
//            CreateMap<DataAccess.Store, Library.Store>();

//            CreateMap<Library.Customer, DataAccess.Customer>();
//            CreateMap<Library.Address, DataAccess.Address>();
//            CreateMap<Library.OrderHeader, DataAccess.OrderHeader>();
//            CreateMap<Library.OrderDetail, DataAccess.OrderDetail>();
//            CreateMap<Library.Product, DataAccess.Product>();
//            CreateMap<Library.ProductRecipe, DataAccess.ProductRecipe>();
//            CreateMap<Library.Ingredient, DataAccess.Ingredient>();
//            CreateMap<Library.Inventory, DataAccess.Inventory>();
//            CreateMap<Library.Store, DataAccess.Store>();
//        }
//    }
//}
