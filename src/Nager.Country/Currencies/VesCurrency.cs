namespace Nager.Country.Currencies
{
    public class VesCurrency : ICurrency
    {
        public string Symbol => "Bs.S";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "VES";

        ///<inheritdoc/>
        public string NumericCode => "928";

        ///<inheritdoc/>
        public string Name => "Venezuelan Bolívar";
    }
}
