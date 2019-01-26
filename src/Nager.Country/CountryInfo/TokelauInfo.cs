namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Tokelau
	/// </summary>
	public class TokelauInfo : ICountryInfo
	{
		public string CommonName => "Tokelau";
		public string OfficialName => "Tokelau";

		public Alpha2Code Alpha2Code => Alpha2Code.TK;
		public Alpha3Code Alpha3Code => Alpha3Code.TKL;
		public int NumericCode => 772;
		public string[] TLD => new [] { ".tk" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Polynesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "NZD" };
		public string[] CallingCodes => new [] { "690" };
	}
}
