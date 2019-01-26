namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Palestine
	/// </summary>
	public class PalestineInfo : ICountryInfo
	{
		public string CommonName => "Palestine";
		public string OfficialName => "State of Palestine";

		public Alpha2Code Alpha2Code => Alpha2Code.PS;
		public Alpha3Code Alpha3Code => Alpha3Code.PSE;
		public int NumericCode => 275;
		public string[] TLD => new [] { ".ps", "فلسطين." };

		public Region Region => Region.Asia;
		public SubRegion SubRegion => SubRegion.WesternAsia;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
			Alpha2Code.IL,
			Alpha2Code.EG,
			Alpha2Code.JO,
		};

		public string[] Currencies => new [] { "ILS" };
		public string[] CallingCodes => new [] { "970" };
	}
}
