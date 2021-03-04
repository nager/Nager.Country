namespace Nager.Country.Currencies
{
    public class JodCurrency : ICurrency
    {
        public string Symbol => "د.ا.‏";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "JOD";

        ///<inheritdoc/>
        public string NumericCode => "400";

        ///<inheritdoc/>
        public string Name => "Jordanian Dinar";
    }
}
