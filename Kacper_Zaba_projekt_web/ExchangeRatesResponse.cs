namespace Kacper_Zaba_projekt_web
{
    public class ExchangeRatesResponse
    {
        public string Table { get; set; }
        public string No { get; set; }
        public DateTime EffectiveDate { get; set; }
        public List<ExchangeRate> Rates { get; set; } = new(); 
    }
}
