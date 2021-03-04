namespace Nager.Country.Currencies
{
    public class GnfCurrency : ICurrency
    {
        public string Symbol => "FG";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "GNF";

        ///<inheritdoc/>
        public string NumericCode => "324";

        ///<inheritdoc/>
        public string Name => "Guinean franc";
    }
}
