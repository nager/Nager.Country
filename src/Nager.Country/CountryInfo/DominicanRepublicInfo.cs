namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Dominican Republic
	/// </summary>
	public class DominicanRepublicInfo : ICountryInfo
	{
		public string CommonName => "Dominican Republic";
		public string OfficialName => "Dominican Republic";

		public Alpha2Code Alpha2Code => Alpha2Code.DO;
		public Alpha3Code Alpha3Code => Alpha3Code.DOM;
		public int NumericCode => 214;
		public string[] TLD => new [] { ".do" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.HT,
		};

		public string[] Currencies => new [] { "DOP" };
		public string[] CallingCodes => new [] { "1809", "1829", "1849" };
	}
}
