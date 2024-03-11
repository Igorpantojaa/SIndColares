﻿namespace Modelos;

public class RG
{
    public int id { get; set; }
    public int AssociadoId { get; set; }
    public DateTime DataEmisao { get; set; }
    public string Numero { get; set; } = string.Empty;
    public string NomePai { get; set; } = string.Empty;
    public string NomeMae { get; set; } = string.Empty;
    public string OrgaoEmissor { get; set; } = string.Empty;
    public string Nacionalidade { get; set; } = string.Empty;
}