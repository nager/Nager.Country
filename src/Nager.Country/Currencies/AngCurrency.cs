namespace Nager.Country.Currencies
{
    public class AngCurrency : ICurrency
    {
        public string Symbol => "NAƒ";

        ///<inheritdoc/>
        public string Singular => "guilder";

        ///<inheritdoc/>
        public string Plural => "guilders";

        ///<inheritdoc/>
        public string IsoCode => "ANG";

        ///<inheritdoc/>
        public string NumericCode => "532";

        ///<inheritdoc/>
        public string Name => "Netherlands Antillean guilder";
    }
}
