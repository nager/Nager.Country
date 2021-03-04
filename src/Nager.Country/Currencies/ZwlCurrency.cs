namespace Nager.Country.Currencies
{
    public class ZwlCurrency : ICurrency
    {
        public string Symbol => null;

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "ZWL";

        ///<inheritdoc/>
        public string NumericCode => "932";

        ///<inheritdoc/>
        public string Name => "Zimbabwean dollar";
    }
}
