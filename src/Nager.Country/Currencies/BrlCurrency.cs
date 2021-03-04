namespace Nager.Country.Currencies
{
    public class BrlCurrency : ICurrency
    {
        public string Symbol => "R$";

        ///<inheritdoc/>
        public string Singular => "real";

        ///<inheritdoc/>
        public string Plural => "reais";

        ///<inheritdoc/>
        public string IsoCode => "BRL";

        ///<inheritdoc/>
        public string NumericCode => "986";

        ///<inheritdoc/>
        public string Name => "Brazilian real";
    }
}
