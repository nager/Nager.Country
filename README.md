# Nager.Country

The Worldwide Country Informations are available over the `nuget` package or as `json` in the [zip package](https://github.com/nager/Nager.Country/releases/latest/download/countries.zip). The collection contains the Informations for 250 Countries.

**Example Data**
```
{
  "commonName": "Austria",
  "officialName": "Republic of Austria",
  "nativeName": "Österreich",
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
  "subRegion": "Western Europe",
  "borderCountries": [
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
    {
      "symbol": "€",
      "singular": "euro",
      "plural": "euro",
      "isoCode": "EUR",
      "numericCode": "978",
      "name": "Euro"
    }
  ],
  "callingCodes": [
    "43"
  ]
}
```

## nuget [![nuget.org download count](https://img.shields.io/nuget/dt/nager.country.svg)](https://www.nuget.org/packages/Nager.Country/)
The package is available via [NuGet](https://www.nuget.org/packages/Nager.Country)
```
PM> install-package Nager.Country
PM> install-package Nager.Country.Translation
```

## Examples of use

### Get all countries
```cs
var countryProvider = new CountryProvider();
var countries = countryProvider.GetCountries();
```

### Get country via CountryName
```cs
var countryProvider = new CountryProvider();
var countryInfo = countryProvider.GetCountryByName("Germany");
//countryInfo.Alpha2Code -> DE
//countryInfo.Alpha3Code -> DEU
//countryInfo.NumericCode -> 276
//countryInfo.Region -> Europe
//countryInfo.SubRegion -> WesternEurope
//countryInfo...
```

### Get country via CountryName and consider Country Translation

Require the translation package `Install-Package Nager.Country.Translation`

```cs
var countryProvider = new CountryProvider();
var countryInfo = countryProvider.GetCountryByNameConsiderTranslation("Germania"); // <- Germany
//countryInfo.Alpha2Code -> DE
//countryInfo.Alpha3Code -> DEU
//countryInfo.NumericCode -> 276
//countryInfo.Region -> Europe
//countryInfo.SubRegion -> WesternEurope
//countryInfo...
```

### Get the name of the country in the requested language ([nuget -> Nager.Country.Translation](https://www.nuget.org/packages/Nager.Country.Translation))
```cs
var translationProvider = new TranslationProvider();
var translatedCountryName = translationProvider.GetCountryTranslatedName(Alpha2Code.DE, LanguageCode.EN);
//translatedCountryName -> Germany
```

### Get all Languages ([nuget -> Nager.Country.Translation](https://www.nuget.org/packages/Nager.Country.Translation))
```cs
var translationProvider = new TranslationProvider();
var languages = translationProvider.GetLanguages();
```


## Interesting projects

| Language | Project | 
| ------------- | ------------- | 
| * | [mledoze countries](https://github.com/mledoze/countries) |
| * | [umpirsky country-list](https://github.com/umpirsky/country-list) |
| * | [dr5hn countries-states-cities-database](https://github.com/dr5hn/countries-states-cities-database) |
| javascript | [michaelwittig node-i18n-iso-countries](https://github.com/michaelwittig/node-i18n-iso-countries) |
| .net | [anghelvalentin CountryValidator](https://github.com/anghelvalentin/CountryValidator) |
