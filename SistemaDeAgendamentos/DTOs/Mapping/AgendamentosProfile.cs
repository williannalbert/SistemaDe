using AutoMapper;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.DTOs.Mapping;

public class AgendamentosProfile : Profile
{
    public AgendamentosProfile()
    {
            CreateMap<Agenda, AgendaDTO>().ReverseMap();
            CreateMap<Agendamento, AgendamentoDTO>().ReverseMap();
            CreateMap<AvaliacaoAgendamento, AvaliacaoAgendamentoDTO>().ReverseMap();
            CreateMap<Avaliacao, AvaliacaoDTO>().ReverseMap();
            CreateMap<AvaliacaoEstabelecimento, AvaliacaoEstabelecimentoDTO>().ReverseMap();
            CreateMap<Cargo, CargoDTO>().ReverseMap();
            CreateMap<CategoriaEstabelecimento, CategoriaEstabelecimentoDTO>().ReverseMap();
            CreateMap<ClienteContato, ClienteContatoDTO>().ReverseMap();
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
            CreateMap<Contato, ContatoDTO>().ReverseMap();
            CreateMap<Endereco, EnderecoDTO>().ReverseMap();
            CreateMap<EstabelecimentoContato, EstabelecimentoContatoDTO>().ReverseMap();
            CreateMap<Estabelecimento, EstabelecimentoDTO>().ReverseMap();
            CreateMap<Funcionario, FuncionarioDTO>().ReverseMap();
            CreateMap<FuncionarioServico, FuncionarioServicoDTO>().ReverseMap();
            CreateMap<HorarioAtendimento, HorarioAtendimentoDTO>().ReverseMap();
            CreateMap<ProprietarioContato, ProprietarioContatoDTO>().ReverseMap();
            CreateMap<Proprietario, ProprietarioDTO>().ReverseMap();
            CreateMap<Servico, ServicoDTO>().ReverseMap();
    }
}
