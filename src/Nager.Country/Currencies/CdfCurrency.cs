namespace Nager.Country.Currencies
{
    public class CdfCurrency : ICurrency
    {
        public string Symbol => "FC";

        ///<inheritdoc/>
        public string Singular => "franc";

        ///<inheritdoc/>
        public string Plural => "francs";

        ///<inheritdoc/>
        public string IsoCode => "CDF";

        ///<inheritdoc/>
        public string NumericCode => "976";

        ///<inheritdoc/>
        public string Name => "Congolese franc";
    }
}
