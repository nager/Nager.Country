namespace Nager.Country.Currencies
{
    public class BrlCurrency : ICurrency
    {
        public string Symbol => "R$";

        public string Singular => "real";

        public string Plural => "reais";

        public string IsoCode => "BRL";

        public string NumericCode => "986";

        public string Name => "Brazilian real";
    }
}
