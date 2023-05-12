using AutoMapper;
using PlanBia.Application.Dtos;
using Siderum.Domain.Entities;

namespace PlanBia.Application.Mappings;

public class DtoMappingProfile : Profile
{
	public DtoMappingProfile()
	{
		CreateMap<Cliente, ClienteDto>().ReverseMap();
		CreateMap<Cliente, ClienteDtoFlat>().ReverseMap();
		CreateMap<ClienteDto, ClienteDtoFlat>().ReverseMap();
	}
}