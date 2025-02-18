using AutoMapper;
using BookAPI.API.Data;
using BookAPI.API.Models.Author;
using BookStoreApp.API.Data;
using BookStoreApp.API.Models.Author;
using BookStoreApp.API.Models.Book;
using BookStoreApp.API.Models.User;

namespace BookAPI.API.Configurations
{
    public class MapperConfing:Profile
    {

        public MapperConfing()
        {
            CreateMap<AuthorCreateDto,Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();
            CreateMap<Book, BookReadOnlyDto>()
                .ForMember(q=>q.AuthorName,d=>d.MapFrom(map=>$"{map.Author.FirstName}{map.Author.LastName}"))
                .ReverseMap();

            CreateMap<Book, BookDetailsDto>()
              .ForMember(q => q.AuthorName, d => d.MapFrom(map => $"{map.Author.FirstName}{map.Author.LastName}"))
              .ReverseMap();

            CreateMap<BookCreateDto, Book>().ReverseMap();
            CreateMap<BookUpdateDto, Book>().ReverseMap();

            CreateMap<ApiUser, UserDto>().ReverseMap();


        }


    }
}
