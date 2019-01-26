namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Saint Vincent and the Grenadines
	/// </summary>
	public class SaintVincentandtheGrenadinesInfo : ICountryInfo
	{
		public string CommonName => "Saint Vincent and the Grenadines";
		public string OfficialName => "Saint Vincent and the Grenadines";

		public Alpha2Code Alpha2Code => Alpha2Code.VC;
		public Alpha3Code Alpha3Code => Alpha3Code.VCT;
		public int NumericCode => 670;
		public string[] TLD => new [] { ".vc" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XCD" };
		public string[] CallingCodes => new [] { "1784" };
	}
}
