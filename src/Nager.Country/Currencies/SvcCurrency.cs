namespace Nager.Country.Currencies
{
    public class SvcCurrency : ICurrency
    {
        public string Symbol => "₡";

        ///<inheritdoc/>
        public string Singular => "colón";

        ///<inheritdoc/>
        public string Plural => "colón";

        ///<inheritdoc/>
        public string IsoCode => "SVC";

        ///<inheritdoc/>
        public string NumericCode => "222";

        ///<inheritdoc/>
        public string Name => "Salvadoran colón";
    }
}
