namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Macau
	/// </summary>
	public class MacauInfo : ICountryInfo
	{
		public string CommonName => "Macau";
		public string OfficialName => "Macao Special Administrative Region of the People's Republic of China";

		public Alpha2Code Alpha2Code => Alpha2Code.MO;
		public Alpha3Code Alpha3Code => Alpha3Code.MAC;
		public int NumericCode => 446;
		public string[] TLD => new [] { ".mo" };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.EasternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.CN,
		};

		public string[] Currencies => new [] { "MOP" };
		public string[] CallingCodes => new [] { "853" };
	}
}
