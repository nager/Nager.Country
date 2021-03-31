namespace Nager.Country.Currencies
{
    public class LakCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "₭";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "LAK";

        ///<inheritdoc/>
        public string NumericCode => "418";

        ///<inheritdoc/>
        public string Name => "Laotian Kip";
    }
}
