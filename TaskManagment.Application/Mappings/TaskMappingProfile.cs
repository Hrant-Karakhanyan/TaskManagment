using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagment.Application.DTOs;
using TaskManagment.Domain.Entities;

namespace TaskManagment.Application.Mappings
{
    public class TaskMappingProfile:Profile
    {
        public TaskMappingProfile() 
        {   //enum -> string
            CreateMap<TaskItem, TaskDto>()
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString())); 
            //string -> enum
            CreateMap<TaskDto, TaskItem>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => Enum.Parse<TaskStatus>(src.Status))); 
        }
    }
}
