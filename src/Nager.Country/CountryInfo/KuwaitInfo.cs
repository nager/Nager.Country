namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Kuwait
	/// </summary>
	public class KuwaitInfo : ICountryInfo
	{
		public string CommonName => "Kuwait";
		public string OfficialName => "State of Kuwait";

		public Alpha2Code Alpha2Code => Alpha2Code.KW;
		public Alpha3Code Alpha3Code => Alpha3Code.KWT;
		public int NumericCode => 414;
		public string[] TLD => new [] { ".kw" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.IQ,
			Alpha2Code.SA,
		};

		public string[] Currencies => new [] { "KWD" };
		public string[] CallingCodes => new [] { "965" };
	}
}
