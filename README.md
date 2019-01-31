[![Build status](https://ci.appveyor.com/api/projects/status/ffxy1ls4xj2cnwd8?svg=true)](https://ci.appveyor.com/project/tinohager/nager-country) [![nuget.org](https://img.shields.io/nuget/dt/nager.country.svg)](https://www.nuget.org/packages/Nager.Country/)

# Nager.Country

Worldwirde Country Informations with this fields. Also a nuget package is available

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

### nuget
The package is available on [nuget](https://www.nuget.org/packages/Nager.Country)
```
PM> install-package Nager.Country
```

### Examples

#### Get country informations of Germany
```cs
ICountryProvider countryProvider = new CountryProvider();
var countryInfo = countryProvider.GetCountry(Alpha2Code.DE);
```



### Alternative projects

| Language | Project | 
| ------------- | ------------- | 
| php | [mledoze-countries](https://github.com/mledoze/countries) |
