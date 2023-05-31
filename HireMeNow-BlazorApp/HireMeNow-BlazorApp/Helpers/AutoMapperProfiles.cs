using AutoMapper;
using HireMeNow_BlazorApp.Dtos;
using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserDto, User>().ReverseMap();
			CreateMap<InterviewDto, Interview>().ReverseMap();
            CreateMap<CompanyDto, Company>().ReverseMap();
            CreateMap<JobDto,Job>().ReverseMap();
		}
	}
}
