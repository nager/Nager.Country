namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Luxembourg
	/// </summary>
	public class LuxembourgInfo : ICountryInfo
	{
		public string CommonName => "Luxembourg";
		public string OfficialName => "Grand Duchy of Luxembourg";

		public Alpha2Code Alpha2Code => Alpha2Code.LU;
		public Alpha3Code Alpha3Code => Alpha3Code.LUX;
		public int NumericCode => 442;
		public string[] TLD => new [] { ".lu" };

		public Region Region => Region.Europe;
		public SubRegion SubRegion => SubRegion.WesternEurope;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.BE,
			Alpha2Code.FR,
			Alpha2Code.DE,
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "352" };
	}
}
