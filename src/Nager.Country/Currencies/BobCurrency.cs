namespace Nager.Country.Currencies
{
    public class BobCurrency : ICurrency
    {
        public string Symbol => "Bs";

        ///<inheritdoc/>
        public string Singular => "boliviano";

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "BOB";

        ///<inheritdoc/>
        public string NumericCode => "068";

        ///<inheritdoc/>
        public string Name => "Bolivian boliviano";
    }
}
