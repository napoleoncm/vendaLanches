namespace vendaLanches
{
    public class Lanche
    {
        public int lancheId { get; set; }
        public string lancheNome { get; set; }
        public string descricaoCurta { get; set;}
        public string descricaoDetalhada { get; set; }
        public decimal preco { get; set; }
        public string imgUrl { get; set; }
        public string imgUrlThumb { get;}
        public bool lanchePreferido { get; set; }
        public bool disponivel { get; set; }


        public int categoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
