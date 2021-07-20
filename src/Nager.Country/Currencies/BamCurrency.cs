namespace Nager.Country.Currencies
{
    /// <summary>
    /// Bam Currency
    /// </summary>
    public class BamCurrency : ICurrency
    {
        ///<inheritdoc/>
        public string Symbol => "КМ";

        ///<inheritdoc/>
        public string Singular => "mark";

        ///<inheritdoc/>
        public string Plural => "marks";

        ///<inheritdoc/>
        public string IsoCode => "BAM";

        ///<inheritdoc/>
        public string NumericCode => "977";

        ///<inheritdoc/>
        public string Name => "Bosnia and Herzegovina convertible mark";
    }
}
