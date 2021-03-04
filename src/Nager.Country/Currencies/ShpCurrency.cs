namespace Nager.Country.Currencies
{
    public class ShpCurrency : ICurrency
    {
        public string Symbol => "£";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "SHP";

        ///<inheritdoc/>
        public string NumericCode => "654";

        ///<inheritdoc/>
        public string Name => "Saint Helena pound";
    }
}
