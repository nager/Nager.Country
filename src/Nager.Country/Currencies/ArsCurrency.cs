namespace Nager.Country.Currencies
{
    public class ArsCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => "dollar";

        ///<inheritdoc/>
        public string Plural => "dollars";

        ///<inheritdoc/>
        public string IsoCode => "ARS";

        ///<inheritdoc/>
        public string NumericCode => "032";

        ///<inheritdoc/>
        public string Name => "Argentine peso";
    }
}
