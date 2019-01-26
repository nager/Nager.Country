namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Portugal
	/// </summary>
	public class PortugalInfo : ICountryInfo
	{
		public string CommonName => "Portugal";
		public string OfficialName => "Portuguese Republic";

		public Alpha2Code Alpha2Code => Alpha2Code.PT;
		public Alpha3Code Alpha3Code => Alpha3Code.PRT;
		public int NumericCode => 620;
		public string[] TLD => new [] { ".pt" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.SouthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.ES,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "351" };
	}
}
