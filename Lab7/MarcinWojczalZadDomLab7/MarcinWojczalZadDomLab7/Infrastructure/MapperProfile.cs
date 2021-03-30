using AutoMapper;
using MarcinWojczalZadDomLab7.Models.Entities;
using MarcinWojczalZadDomLab7.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcinWojczalZadDomLab7.Infrastructure
{
    public class MapperProfile:Profile
    {
        /// <summary>
        /// Konstruktor tworzący mapy
        /// </summary>
        public MapperProfile()
        {
            //Tworzenie mapy dla tabeli Rooms
            CreateMap<Room, RoomViewModel>()
                .ForMember(dest => dest.RoomType, opt => opt.MapFrom(src => src.RoomType.Type));
            //Tworzenie mapy dla klientów
            CreateMap<User, CustomerViewModel>();
        }
    }
}
