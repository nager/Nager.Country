namespace Nager.Country.Currencies
{
    public class AoaCurrency : ICurrency
    {
        public string Symbol => "Kz";

        ///<inheritdoc/>
        public string Singular => "kwanza";

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "AOA";

        ///<inheritdoc/>
        public string NumericCode => "973";

        ///<inheritdoc/>
        public string Name => "Angolan kwanza";
    }
}
