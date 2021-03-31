namespace Nager.Country.Currencies
{
    public class UgxCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "USh";

        ///<inheritdoc/>
        public string Singular => "shilling";

        ///<inheritdoc/>
        public string Plural => "shilling";

        ///<inheritdoc/>
        public string IsoCode => "UGX";

        ///<inheritdoc/>
        public string NumericCode => "800";

        ///<inheritdoc/>
        public string Name => "Ugandan shilling";
    }
}
