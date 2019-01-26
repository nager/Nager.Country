namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Czech Republic
	/// </summary>
	public class CzechRepublicInfo : ICountryInfo
	{
		public string CommonName => "Czech Republic";
		public string OfficialName => "Czech Republic";

		public Alpha2Code Alpha2Code => Alpha2Code.CZ;
		public Alpha3Code Alpha3Code => Alpha3Code.CZE;
		public int NumericCode => 203;
		public string[] TLD => new [] { ".cz" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.EasternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.AT,
			Alpha2Code.DE,
			Alpha2Code.PL,
			Alpha2Code.SK,
		};

		public string[] Currencies => new [] { "CZK" };
		public string[] CallingCodes => new [] { "420" };
	}
}
