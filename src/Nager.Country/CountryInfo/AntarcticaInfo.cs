namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Antarctica
	/// </summary>
	public class AntarcticaInfo : ICountryInfo
	{
		public string CommonName => "Antarctica";
		public string OfficialName => "Antarctica";

		public Alpha2Code Alpha2Code => Alpha2Code.AQ;
		public Alpha3Code Alpha3Code => Alpha3Code.ATA;
		public int NumericCode => 010;
		public string[] TLD => new [] { ".aq" };

		public Region Region => Region.None;
		public SubRegion SubRegion => SubRegion.None;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "" };
		public string[] CallingCodes => new string[0];
	}
}
