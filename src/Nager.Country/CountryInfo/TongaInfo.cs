namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Tonga
	/// </summary>
	public class TongaInfo : ICountryInfo
	{
		public string CommonName => "Tonga";
		public string OfficialName => "Kingdom of Tonga";

		public Alpha2Code Alpha2Code => Alpha2Code.TO;
		public Alpha3Code Alpha3Code => Alpha3Code.TON;
		public int NumericCode => 776;
		public string[] TLD => new [] { ".to" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Polynesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "TOP" };
		public string[] CallingCodes => new [] { "676" };
	}
}
