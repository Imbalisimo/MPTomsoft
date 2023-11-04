namespace MPTomsoft.Models
{
    public class ArticlesDto
    {
        public ArticleResult[] Result { get; set; }
    }

    public class ArticleResult
    {
        public Article[] Artikli { get; set; }
    }

    public class Article
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
    }
}
