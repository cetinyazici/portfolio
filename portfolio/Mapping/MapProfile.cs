using AutoMapper;
using DToLayer.ContactDtos;
using EntityLayer.Concrete;

namespace portfolio.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<SendMessageDto, Contact>().ReverseMap();
        }
    }
}
