using AutoMapper;
using BookAPI.API.Data;
using BookAPI.API.Models.Author;
using BookStoreApp.API.Models.Author;

namespace BookAPI.API.Configurations
{
    public class MapperConfing:Profile
    {

        public MapperConfing()
        {
            CreateMap<AuthorCreateDto,Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
          




        }


    }
}
