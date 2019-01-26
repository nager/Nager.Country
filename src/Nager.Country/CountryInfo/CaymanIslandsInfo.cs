namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Cayman Islands
	/// </summary>
	public class CaymanIslandsInfo : ICountryInfo
	{
		public string CommonName => "Cayman Islands";
		public string OfficialName => "Cayman Islands";

		public Alpha2Code Alpha2Code => Alpha2Code.KY;
		public Alpha3Code Alpha3Code => Alpha3Code.CYM;
		public int NumericCode => 136;
		public string[] TLD => new [] { ".ky" };

		public Region Region => Region.Americas;
		public SubRegion SubRegion => SubRegion.Caribbean;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "KYD" };
		public string[] CallingCodes => new [] { "1345" };
	}
}
