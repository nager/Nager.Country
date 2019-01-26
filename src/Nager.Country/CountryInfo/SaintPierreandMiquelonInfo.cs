namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Saint Pierre and Miquelon
	/// </summary>
	public class SaintPierreandMiquelonInfo : ICountryInfo
	{
		public string CommonName => "Saint Pierre and Miquelon";
		public string OfficialName => "Saint Pierre and Miquelon";

		public Alpha2Code Alpha2Code => Alpha2Code.PM;
		public Alpha3Code Alpha3Code => Alpha3Code.SPM;
		public int NumericCode => 666;
		public string[] TLD => new [] { ".pm" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.NorthernAmerica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "508" };
	}
}
