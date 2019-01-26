namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Estonia
	/// </summary>
	public class EstoniaInfo : ICountryInfo
	{
		public string CommonName => "Estonia";
		public string OfficialName => "Republic of Estonia";

		public Alpha2Code Alpha2Code => Alpha2Code.EE;
		public Alpha3Code Alpha3Code => Alpha3Code.EST;
		public int NumericCode => 233;
		public string[] TLD => new [] { ".ee" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.LV,
			Alpha2Code.RU,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "372" };
	}
}
