namespace Nager.Country.Currencies
{
    public class GelCurrency : ICurrency
    {
        public string Symbol => "₾";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "GEL";

        ///<inheritdoc/>
        public string NumericCode => "981";

        ///<inheritdoc/>
        public string Name => "Georgian Lari";
    }
}
