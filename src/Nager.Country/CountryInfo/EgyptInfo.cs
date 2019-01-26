namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Egypt
	/// </summary>
	public class EgyptInfo : ICountryInfo
	{
		public string CommonName => "Egypt";
		public string OfficialName => "Arab Republic of Egypt";

		public Alpha2Code Alpha2Code => Alpha2Code.EG;
		public Alpha3Code Alpha3Code => Alpha3Code.EGY;
		public int NumericCode => 818;
		public string[] TLD => new [] { ".eg", ".مصر" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.NorthernAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.IL,
			Alpha2Code.LY,
			Alpha2Code.SD,
		};

		public string[] Currencies => new [] { "EGP" };
		public string[] CallingCodes => new [] { "20" };
	}
}
