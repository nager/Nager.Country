namespace Nager.Country
{
    public interface ICountryProvider
    {
        ICountryInfo GetCountry(string alpha2or3Code);

        ICountryInfo GetCountry(Alpha2Code alpha2Code);
        ICountryInfo GetCountry(Alpha3Code alpha3Code);
    }
}
