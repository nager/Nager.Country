namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Albania
	/// </summary>
	public class AlbaniaInfo : ICountryInfo
	{
		public string CommonName => "Albania";
		public string OfficialName => "Republic of Albania";

		public Alpha2Code Alpha2Code => Alpha2Code.AL;
		public Alpha3Code Alpha3Code => Alpha3Code.ALB;
		public int NumericCode => 008;
		public string[] TLD => new [] { ".al" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.SouthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.ME,
			Alpha2Code.GR,
			Alpha2Code.MK,
		};

		public string[] Currencies => new [] { "ALL" };
		public string[] CallingCodes => new [] { "355" };
	}
}
