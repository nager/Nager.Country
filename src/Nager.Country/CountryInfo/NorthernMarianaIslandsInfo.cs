namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Northern Mariana Islands
	/// </summary>
	public class NorthernMarianaIslandsInfo : ICountryInfo
	{
		public string CommonName => "Northern Mariana Islands";
		public string OfficialName => "Commonwealth of the Northern Mariana Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.MP;
		public Alpha3Code Alpha3Code => Alpha3Code.MNP;
		public int NumericCode => 580;
		public string[] TLD => new [] { ".mp" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Micronesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "USD" };
		public string[] CallingCodes => new [] { "1670" };
	}
}
