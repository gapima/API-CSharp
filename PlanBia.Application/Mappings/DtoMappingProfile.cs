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

        CreateMap<ContatoCliente, ContatoClienteDto>().ReverseMap();
        CreateMap<ContatoCliente, ContatoClienteDtoFlat>().ReverseMap();
        CreateMap<ContatoClienteDto, ContatoClienteDtoFlat>().ReverseMap();

        CreateMap<ContatoIndicador, ContatoClienteDto>().ReverseMap();
        CreateMap<ContatoIndicador, ContatoIndicadorDtoFlat>().ReverseMap();
        CreateMap<ContatoIndicadorDto, ContatoIndicadorDtoFlat>().ReverseMap();

        CreateMap<Credores, CredoresDto>().ReverseMap();
        CreateMap<Credores, CredoresDtoFlat>().ReverseMap();
        CreateMap<CredoresDto, CredoresDtoFlat>().ReverseMap();

        CreateMap<Documento, DocumentoDto>().ReverseMap();
        CreateMap<Documento, DocumentoDtoFlat>().ReverseMap();
        CreateMap<DocumentoDto, DocumentoDtoFlat>().ReverseMap();

        CreateMap<Grupo, GrupoDto>().ReverseMap();
        CreateMap<Grupo, GrupoDtoFlat>().ReverseMap();
        CreateMap<GrupoDto, GrupoDtoFlat>().ReverseMap();

        CreateMap<Indicador, IndicadorDto>().ReverseMap();
        CreateMap<Indicador, IndicadorDtoFlat>().ReverseMap();
        CreateMap<IndicadorDto, IndicadorDtoFlat>().ReverseMap();

        CreateMap<Processo, ProcessoDto>().ReverseMap();
        CreateMap<Processo, ProcessoDtoFlat>().ReverseMap();
        CreateMap<ProcessoDto, ProcessoDtoFlat>().ReverseMap();

        CreateMap<RendaCliente, RendaClienteDto>().ReverseMap();
        CreateMap<RendaCliente, RendaClienteDtoFlat>().ReverseMap();
        CreateMap<RendaClienteDto, RendaClienteDtoFlat>().ReverseMap();

        CreateMap<SituacaoCredito, SituacaoCreditoDto>().ReverseMap();
        CreateMap<SituacaoCredito, SituacaoCreditoDtoFlat>().ReverseMap();
        CreateMap<SituacaoCreditoDto, SituacaoCreditoDtoFlat>().ReverseMap();

        CreateMap<TipoDocumento, TipoDocumentoDto>().ReverseMap();
        CreateMap<TipoDocumento, TipoDocumentoDtoFlat>().ReverseMap();
        CreateMap<TipoDocumentoDto, TipoDocumentoDtoFlat>().ReverseMap();

        CreateMap<Usuario, UsuarioDto>().ReverseMap();
        CreateMap<Usuario, UsuarioDtoFlat>().ReverseMap();
        CreateMap<UsuarioDto, UsuarioDtoFlat>().ReverseMap();
    }

}