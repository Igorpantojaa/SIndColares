using Microsoft.EntityFrameworkCore;
using Models;

namespace Insfraestructure;

public class SindContext : DbContext
{

    public SindContext() : base() { }

    public DbSet <RG> RG { get; set; }
    public DbSet <Contato> Contatos { get; set; }
    public DbSet <Endereco> Enderecos { get; set; }
    public DbSet <Filiacao> Filiacoes { get; set; }
    public DbSet <Profissao> Profissoes { get; set;}
    public DbSet <Associado> Associados { get; set; }
    public DbSet <Documentos> Documentos { get; set; }
    public DbSet <Escolaridade> Escolaridades { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connDB = "Data Source=D:\\Dev\\VSTUDIO\\SIndColares\\Insfraestructure\\LocalDB\\SindColaresDB.db; Version=3;";
        optionsBuilder.UseSqlite(connDB);
    }
}