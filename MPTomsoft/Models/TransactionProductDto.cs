namespace MPTomsoft.Models
{
    public class TransactionProductDto
    {
        public TransactionProductResult[] Result { get; set; }
    }

    public class TransactionProductResult
    {
        public TransactionProduct[] Obracun_artikli { get; set; }
    }

    public class TransactionProduct
    {
        public string Artikl_uid { get; set; }
        public string Naziv_artikla { get; set; }
        public double Kolicina { get; set; }
        public double Iznos { get; set; }
        public char Usluga { get; set; }
    }
}
