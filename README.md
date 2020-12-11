# Nager.Country

The Worldwirde Country Informations are available over the `nuget` package or as `json` in the [zip package](https://github.com/nager/Nager.Country/releases/latest/download/countries.zip). The collection contains the Informations for 250 Countries.

**Example Data**
```
{
  "commonName": "Austria",
  "officialName": "Republic of Austria",
  "translations": [
    {
      "languageCode": "EN",
      "name": "Austria"
    },
    {
      "languageCode": "ES",
      "name": "Austria"
    },
    {
      "languageCode": "FR",
      "name": "Autriche"
    },
    ...
  ],
  "alpha2Code": "AT",
  "alpha3Code": "AUT",
  "numericCode": 40,
  "tld": [
    ".at"
  ],
  "region": "Europe",
  "subRegion": "WesternEurope",
  "borderCountrys": [
    "CZ",
    "DE",
    "HU",
    "IT",
    "LI",
    "SK",
    "SI",
    "CH"
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
| * | [dr5hn countries-states-cities-database](https://github.com/dr5hn/countries-states-cities-database) |
| javascript | [michaelwittig node-i18n-iso-countries](https://github.com/michaelwittig/node-i18n-iso-countries) |
