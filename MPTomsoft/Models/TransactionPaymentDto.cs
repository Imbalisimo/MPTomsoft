namespace MPTomsoft.Models
{
    public class TransactionPaymentDto
    {
        public TransactionPaymentResult[] Result { get; set; }
    }

    public class TransactionPaymentResult
    {
        public TransactionPayment[] Obracun_placanja { get; set; }
    }

    public class TransactionPayment
    {
        public string Vrste_placanja_uid { get; set; } // documentation says "Vrsta_placanja_uid"!
        public string Naziv { get; set; }               // documentation says "Vrsta_placanja_naziv"!
        public double Iznos { get; set; }
        public string? Nadgrupa_placanja_uid { get; set; }
        public string? Nadgrupa_placanja_naziv { get; set; }
    }
}
