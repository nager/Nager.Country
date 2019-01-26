namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// New Caledonia
	/// </summary>
	public class NewCaledoniaInfo : ICountryInfo
	{
		public string CommonName => "New Caledonia";
		public string OfficialName => "New Caledonia";

		public Alpha2Code Alpha2Code => Alpha2Code.NC;
		public Alpha3Code Alpha3Code => Alpha3Code.NCL;
		public int NumericCode => 540;
		public string[] TLD => new [] { ".nc" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Melanesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "XPF" };
		public string[] CallingCodes => new [] { "687" };
	}
}
