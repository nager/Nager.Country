namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Wallis and Futuna
	/// </summary>
	public class WallisandFutunaInfo : ICountryInfo
	{
		public string CommonName => "Wallis and Futuna";
		public string OfficialName => "Territory of the Wallis and Futuna Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.WF;
		public Alpha3Code Alpha3Code => Alpha3Code.WLF;
		public int NumericCode => 876;
		public string[] TLD => new [] { ".wf" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Polynesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XPF" };
		public string[] CallingCodes => new [] { "681" };
	}
}
