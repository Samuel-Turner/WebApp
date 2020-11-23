using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DTOs;
using WebApp.Models;

namespace WebApp.Profiles
{
    public class DinosProfile : Profile
    {
        public DinosProfile()
        {
            CreateMap<Dino, DinoReadDTO>();
            CreateMap<DinoCreateDTO, Dino>();
            CreateMap<DinoUpdateDTO, Dino>();
            CreateMap<Dino,DinoUpdateDTO>();
        }
    }
}
