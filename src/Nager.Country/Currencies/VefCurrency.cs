namespace Nager.Country.Currencies
{
    public class VefCurrency : ICurrency
    {
        public string Symbol => "Bs.S";

        ///<inheritdoc/>
        public string Singular => "bolívar soberano";

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "VEF";

        ///<inheritdoc/>
        public string NumericCode => "937";

        ///<inheritdoc/>
        public string Name => "Venezuelan bolívar fuerte";
    }
}
