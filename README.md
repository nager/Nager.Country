[![nuget.org](https://img.shields.io/nuget/dt/nager.country.svg)](https://www.nuget.org/packages/Nager.Country/)

# Nager.Country

Worldwirde Country Informations with the following data:

- CommonName
- OfficialName
- Translation
- Alpha2Code
- Alpha3Code
- NumericCode
- TLD
- Region
- SubRegion
- BorderCountrys
- Currencies
- CallingCodes

## nuget
The package is available on [nuget](https://www.nuget.org/packages/Nager.Country)
```
PM> install-package Nager.Country
```

## Examples

### Get country informations of Germany
```cs
ICountryProvider countryProvider = new CountryProvider();
var countryInfo = countryProvider.GetCountry(Alpha2Code.DE);
```

## Alternative projects

| Language | Project | 
| ------------- | ------------- | 
| * | [mledoze countries](https://github.com/mledoze/countries) |
| * | [umpirsky country-list](https://github.com/umpirsky/country-list) |
| javascript | [michaelwittig node-i18n-iso-countries](https://github.com/michaelwittig/node-i18n-iso-countries) |
