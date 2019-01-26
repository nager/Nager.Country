namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Seychelles
	/// </summary>
	public class SeychellesInfo : ICountryInfo
	{
		public string CommonName => "Seychelles";
		public string OfficialName => "Republic of Seychelles";

		public Alpha2Code Alpha2Code => Alpha2Code.SC;
		public Alpha3Code Alpha3Code => Alpha3Code.SYC;
		public int NumericCode => 690;
		public string[] TLD => new [] { ".sc" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "SCR" };
		public string[] CallingCodes => new [] { "248" };
	}
}
