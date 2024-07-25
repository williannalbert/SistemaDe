using Microsoft.EntityFrameworkCore;
using SistemaDeAgendamentos.Context;
using SistemaDeAgendamentos.Repositories;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
}).AddNewtonsoftJson();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection")!;
builder.Services.AddDbContext<AppDbContext>(options =>
                    options.UseMySql(mySqlConnection,
                    ServerVersion.AutoDetect(mySqlConnection)));

builder.Services.AddScoped<IAgendamentoRepository, AgendamentoRepository>();
builder.Services.AddScoped<IAgendaRepository, AgendaRepository>();
builder.Services.AddScoped<IAvaliacaoAgendamentoRepository, AvaliacaoAgendamentoRepository>();
builder.Services.AddScoped<IAvaliacaoEstabelecimentoRepository, AvaliacaoEstabelecimentoRepository>();
builder.Services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
builder.Services.AddScoped<ICargoRepository, CargoRepository>();
builder.Services.AddScoped<ICategoriaEstabelecimentoRepository, CategoriaEstabelecimentoRepository>();
builder.Services.AddScoped<IClienteContatoRepository, ClienteContatoRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IContatoRepository, ContatoRepository>();
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
builder.Services.AddScoped<IEstabelecimentoContatoRepository, EstabelecimentoContatoRepository>();
builder.Services.AddScoped<IEstabelecimentoRepository, EstabelecimentoRepository>();
builder.Services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
builder.Services.AddScoped<IFuncionarioServicoRepository, FuncionarioServicoRepository>();
builder.Services.AddScoped<IHorarioAtendimentoRepository, HorarioAtendimentoRepository>();
builder.Services.AddScoped<IProprietarioContatoRepository, ProprietarioContatoRepository>();
builder.Services.AddScoped<IProprietarioRepository, ProprietarioRepository>();
builder.Services.AddScoped<IServicoRepository, ServicoRepository>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
