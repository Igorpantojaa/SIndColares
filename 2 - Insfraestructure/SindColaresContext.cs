using Microsoft.EntityFrameworkCore;
using Modelos;

namespace Infraestrutura;

public class SindContext : DbContext
{

    public SindContext() : base() { }

    public DbSet<RG> RG { get; set; }
    public DbSet<Periodo> Periodos { get; set; }
    public DbSet<Contato> Contatos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Filiacao> Filiacoes { get; set; }
    public DbSet<Profissao> Profissoes { get; set; }
    public DbSet<Associado> Associados { get; set; }
    public DbSet<Documentos> Documentos { get; set; }
    public DbSet<Escolaridade> Escolaridades { get; set; }
    public DbSet<Digitalizados> Digitalizados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connDB = "Data Source=D:\\Dev\\VSTUDIO\\SIndColares\\2 - Insfraestructure\\LocalDB\\SindColaresDB.db";
        optionsBuilder.UseSqlite(connDB);
    }
}