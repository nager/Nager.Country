namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Mayotte
	/// </summary>
	public class MayotteInfo : ICountryInfo
	{
		public string CommonName => "Mayotte";
		public string OfficialName => "Department of Mayotte";

		public Alpha2Code Alpha2Code => Alpha2Code.YT;
		public Alpha3Code Alpha3Code => Alpha3Code.MYT;
		public int NumericCode => 175;
		public string[] TLD => new [] { ".yt" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "262" };
	}
}
