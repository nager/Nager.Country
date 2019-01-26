namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Finland
	/// </summary>
	public class FinlandInfo : ICountryInfo
	{
		public string CommonName => "Finland";
		public string OfficialName => "Republic of Finland";

		public Alpha2Code Alpha2Code => Alpha2Code.FI;
		public Alpha3Code Alpha3Code => Alpha3Code.FIN;
		public int NumericCode => 246;
		public string[] TLD => new [] { ".fi" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.NorthernEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.NO,
			Alpha2Code.SE,
			Alpha2Code.RU,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "358" };
	}
}
