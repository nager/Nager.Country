namespace Nager.Country.CountryInfo
{
	/// <summary>
	/// Réunion
	/// </summary>
	public class RéunionInfo : ICountryInfo
	{
		public string CommonName => "Réunion";
		public string OfficialName => "Réunion Island";

		public Alpha2Code Alpha2Code => Alpha2Code.RE;
		public Alpha3Code Alpha3Code => Alpha3Code.REU;
		public int NumericCode => 638;
		public string[] TLD => new [] { ".re" };

		public Region Region => Region.Africa;
		public SubRegion SubRegion => SubRegion.EasternAfrica;

		public Alpha2Code[] BorderCountrys => new Alpha2Code[]
		{
		};

		public string[] Currencies => new [] { "EUR" };
		public string[] CallingCodes => new [] { "262" };
	}
}
