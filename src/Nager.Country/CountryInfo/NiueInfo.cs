namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Niue
	/// </summary>
	public class NiueInfo : ICountryInfo
	{
		public string CommonName => "Niue";
		public string OfficialName => "Niue";

		public Alpha2Code Alpha2Code => Alpha2Code.NU;
		public Alpha3Code Alpha3Code => Alpha3Code.NIU;
		public int NumericCode => 570;
		public string[] TLD => new [] { ".nu" };

		public Region Region => Region.Oceania;
		public SubRegion SubRegion => SubRegion.Polynesia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "NZD" };
		public string[] CallingCodes => new [] { "683" };
	}
}
