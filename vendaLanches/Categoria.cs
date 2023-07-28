namespace vendaLanches
{
    public class Categoria
    {
        public int categoriaId { get; set; }
        public string categoriaNome { get; set; }
        public string descricao { get; set; }

        public List<Lanche> lanches { get; set; }
    }
}
