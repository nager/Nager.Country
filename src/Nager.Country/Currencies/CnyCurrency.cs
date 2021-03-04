namespace Nager.Country.Currencies
{
    public class CnyCurrency : ICurrency
    {
        public string Symbol => "¥";

        ///<inheritdoc/>
        public string Singular => "renminbi";

        ///<inheritdoc/>
        public string Plural => "renminbi";

        ///<inheritdoc/>
        public string IsoCode => "CNY";

        ///<inheritdoc/>
        public string NumericCode => "156";

        ///<inheritdoc/>
        public string Name => "Renminbi";
    }
}
