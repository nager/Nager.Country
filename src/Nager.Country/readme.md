# Nager.Country

The Worldwirde Country Informations are available over the nuget package. The collection contains the Informations for 250 Countries.

> If you need the translations of the countries you will find in the further nuget package [Nager.Country.Translation](https://www.nuget.org/packages/Nager.Country.Translation)

## Code Examples

### Get CountryInfo - Germany via Alpha2Code

    ICountryProvider countryProvider = new CountryProvider();
    var countryInfo = countryProvider.GetCountry(Alpha2Code.DE);
    //countryInfo.CommonName -> Germany
    //countryInfo.Alpha3Code -> DEU
    //countryInfo.NumericCode -> 276
    //countryInfo.Region -> Europe
    //countryInfo.SubRegion -> WesternEurope
    //countryInfo...

### Get CountryInfo - Germany via CommonName

    ICountryProvider countryProvider = new CountryProvider();
    var countryInfo = countryProvider.GetCountryByName("Germany");
    //countryInfo.Alpha2Code -> DE
    //countryInfo.Alpha3Code -> DEU
    //countryInfo.NumericCode -> 276
    //countryInfo.Region -> Europe
    //countryInfo.SubRegion -> WesternEurope
    //countryInfo..