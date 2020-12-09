# Nager.Country

The country informations are available in the `nuget` package or as `json` in the [zip package](https://github.com/nager/Nager.Country/releases/latest/download/countries.zip)
Worldwirde Country Informations with the following fields: CommonName, OfficialName, Translation, Alpha2Code, Alpha3Code, NumericCode, TLD, Region, SubRegion, BorderCountrys, Currencies, CallingCodes

```
{
  "commonName": "Austria",
  "officialName": "Republic of Austria",
  "translations": [
    {
      "languageCode": "en",
      "name": "Austria"
    },
    {
      "languageCode": "es",
      "name": "Austria"
    },
    {
      "languageCode": "fr",
      "name": "Autriche"
    },
    ...
  ],
  "alpha2Code": "at",
  "alpha3Code": "aut",
  "numericCode": 40,
  "tld": [
    ".at"
  ],
  "region": "europe",
  "subRegion": "westernEurope",
  "borderCountrys": [
    "cz",
    "de",
    "hu",
    "it",
    "li",
    "sk",
    "si",
    "ch"
  ],
  "currencies": [
    "EUR"
  ],
  "callingCodes": [
    "43"
  ]
}
```

## nuget [![nuget.org download count](https://img.shields.io/nuget/dt/nager.country.svg)](https://www.nuget.org/packages/Nager.Country/)
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
