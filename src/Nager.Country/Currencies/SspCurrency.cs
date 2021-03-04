namespace Nager.Country.Currencies
{
    public class SspCurrency : ICurrency
    {
        public string Symbol => "SS£";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "SSP";

        ///<inheritdoc/>
        public string NumericCode => "728";

        ///<inheritdoc/>
        public string Name => "South Sudanese pound";
    }
}
