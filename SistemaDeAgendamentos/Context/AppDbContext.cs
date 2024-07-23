using Microsoft.EntityFrameworkCore;
using SistemaDeAgendamentos.Models;

namespace SistemaDeAgendamentos.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public DbSet<Proprietario> Proprietarios { get; set; }
    public DbSet<Estabelecimento> Estabelecimentos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Contato> Contatos { get; set; }
    public DbSet<HorarioAtendimento> HorariosAtendimento { get; set; }
    public DbSet<CategoriaEstabelecimento> CategoriasEstabelecimentos { get; set; }
    public DbSet<Servico> Servicos { get; set; }
    public DbSet<FuncionarioServico> FuncionariosServicos { get; set; }
    public DbSet<Cargo> Cargos { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Agenda> Agendas { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Agendamento> Agendamentos { get; set; }
    public DbSet<Avaliacao> Avaliacoes { get; set; }
    public DbSet<ProprietarioContato> ProprietarioContatos { get; set; }
    public DbSet<EstabelecimentoContato> EstabelecimentoContatos { get; set; }
    public DbSet<ClienteContato> ClienteContatos { get; set; }
    public DbSet<AvaliacaoEstabelecimento> AvaliacoesEstabelecimento { get; set; }
    public DbSet<AvaliacaoAgendamento> AvaliacoesAgendamento { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FuncionarioServico>()
            .HasKey(fs => new { fs.ServicoId, fs.FuncionarioId });

        modelBuilder.Entity<FuncionarioServico>()
            .HasOne(fs => fs.Servico)
            .WithMany(s => s.FuncionariosServicos)
            .HasForeignKey(fs => fs.ServicoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<FuncionarioServico>()
            .HasOne(fs => fs.Funcionario)
            .WithMany(f => f.FuncionariosServicos)
            .HasForeignKey(fs => fs.FuncionarioId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProprietarioContato>()
            .HasOne(pc => pc.Proprietario)
            .WithMany(p => p.ProprietarioContatos)
            .HasForeignKey(pc => pc.ProprietarioId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProprietarioContato>()
            .HasOne(pc => pc.Contato)
            .WithMany(c => c.ProprietarioContatos)
            .HasForeignKey(pc => pc.ContatoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<EstabelecimentoContato>()
            .HasOne(ec => ec.Estabelecimento)
            .WithMany(e => e.EstabelecimentoContatos)
            .HasForeignKey(ec => ec.EstabelecimentoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<EstabelecimentoContato>()
            .HasOne(ec => ec.Contato)
            .WithMany(c => c.EstabelecimentoContatos)
            .HasForeignKey(ec => ec.ContatoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ClienteContato>()
            .HasOne(cc => cc.Cliente)
            .WithMany(c => c.ClienteContatos)
            .HasForeignKey(cc => cc.ClienteId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ClienteContato>()
            .HasOne(cc => cc.Contato)
            .WithMany(c => c.ClienteContatos)
            .HasForeignKey(cc => cc.ContatoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AvaliacaoEstabelecimento>()
            .HasOne(ae => ae.Avaliacao)
            .WithMany()
            .HasForeignKey(ae => ae.AvaliacaoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AvaliacaoEstabelecimento>()
            .HasOne(ae => ae.Estabelecimento)
            .WithMany(e => e.AvaliacoesEstabelecimento)
            .HasForeignKey(ae => ae.EstabelecimentoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AvaliacaoAgendamento>()
            .HasOne(aa => aa.Avaliacao)
            .WithMany()
            .HasForeignKey(aa => aa.AvaliacaoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<AvaliacaoAgendamento>()
            .HasOne(aa => aa.Agendamento)
            .WithMany(a => a.AvaliacoesAgendamento)
            .HasForeignKey(aa => aa.AgendamentoId)
            .OnDelete(DeleteBehavior.Cascade);

        // Add cascading delete behavior for other relationships as needed
        modelBuilder.Entity<Estabelecimento>()
            .HasOne(e => e.Proprietario)
            .WithMany(p => p.Estabelecimentos)
            .HasForeignKey(e => e.ProprietarioId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Estabelecimento>()
            .HasOne(e => e.Endereco)
            .WithMany(en => en.Estabelecimentos)
            .HasForeignKey(e => e.EnderecoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Funcionario>()
            .HasOne(f => f.Estabelecimento)
            .WithMany(e => e.Funcionarios)
            .HasForeignKey(f => f.EstabelecimentoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Funcionario>()
            .HasOne(f => f.Cargo)
            .WithMany(c => c.Funcionarios)
            .HasForeignKey(f => f.CargoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Agenda>()
            .HasOne(a => a.Funcionario)
            .WithMany(f => f.Agendas)
            .HasForeignKey(a => a.FuncionarioId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Agendamento>()
            .HasOne(a => a.Agenda)
            .WithMany(ag => ag.Agendamentos)
            .HasForeignKey(a => a.AgendaId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Agendamento>()
            .HasOne(a => a.Cliente)
            .WithMany(c => c.Agendamentos)
            .HasForeignKey(a => a.ClienteId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
