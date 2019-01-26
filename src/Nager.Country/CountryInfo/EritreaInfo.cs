namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Eritrea
	/// </summary>
	public class EritreaInfo : ICountryInfo
	{
		public string CommonName => "Eritrea";
		public string OfficialName => "State of Eritrea";

		public Alpha2Code Alpha2Code => Alpha2Code.ER;
		public Alpha3Code Alpha3Code => Alpha3Code.ERI;
		public int NumericCode => 232;
		public string[] TLD => new [] { ".er" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.DJ,
			Alpha2Code.ET,
			Alpha2Code.SD,
		};

		public string[] Currencies => new [] { "ERN" };
		public string[] CallingCodes => new [] { "291" };
	}
}
