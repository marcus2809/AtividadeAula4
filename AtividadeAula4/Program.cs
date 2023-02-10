


var times = new List<Time>() 
{
    new Time 
    (
        "Gremio",
        new List<Jogador>() 
        {
            new Jogador("Gabriel Granco", Tipo.GOLEIRO),
            new Jogador("Rafinha", Tipo.LATERAL),
            new Jogador("Bruno Cortez", Tipo.LATERAL),
            new Jogador("Pedro Geromel", Tipo.ZAGUEIRO),
            new Jogador("Ruan", Tipo.ZAGUEIRO),
            new Jogador("Tiago Santos", Tipo.VOLANTE),
            new Jogador("Lucas Silva", Tipo.VOLANTE),
            new Jogador("Ferreira", Tipo.MEIA),
            new Jogador("Jaminton Campaz", Tipo.MEIA),
            new Jogador("Jhonata Robert", Tipo.MEIA),
            new Jogador("Diego Souza", Tipo.ATACANTE)
        }
    ),
    new Time(
        "Flamengo",
        new List<Jogador>() {
            new Jogador("Hugo Souza", Tipo.GOLEIRO),
            new Jogador("Rodinel", Tipo.LATERAL),
            new Jogador("Renê", Tipo.LATERAL),
            new Jogador("Gustavo Henrique", Tipo.ZAGUEIRO),
            new Jogador("Léo Pereira", Tipo.ZAGUEIRO),
            new Jogador("Thiago Maia", Tipo.VOLANTE),
            new Jogador("João Gomes", Tipo.VOLANTE),
            new Jogador("Kenedy", Tipo.MEIA),
            new Jogador("Diego", Tipo.MEIA),
            new Jogador("Vitinho", Tipo.MEIA),
            new Jogador("Vitor Gabriel", Tipo.ATACANTE)
        }
    )
};

var jogadores = from t in times
                from j in t.Jogadores
                where j.Posicao == Tipo.MEIA
                select new { j.Nome, t.Identificador };

foreach (var item in jogadores)
{
    Console.WriteLine($"{item.Nome}, {item.Identificador}");
}


class Time
{
    public string Identificador { get; set; }
    public IEnumerable<Jogador> Jogadores { get; set; }
    public Time(string nome, IEnumerable<Jogador> jogadores)
    {
        Identificador = nome;
        Jogadores = jogadores;
    }
}

class Jogador
{
    public string Nome { get; set;}
    public Tipo Posicao { get; set; }
    public Jogador(string nome, Tipo posicao)
    {
        Nome = nome;
        Posicao = posicao;
    }
}

enum Tipo
{
    GOLEIRO,
    LATERAL,
    ZAGUEIRO,
    VOLANTE,
    MEIA,
    ATACANTE
}