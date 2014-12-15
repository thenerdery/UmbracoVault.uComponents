#uComponents Support for Umbraco Vault

### Build Status:

| Branch | Status |
| ------ | ------ |
| master | [![Build status](https://ci.appveyor.com/api/projects/status/w3u8l7sd6qbvrw59?svg=true)](https://ci.appveyor.com/project/kensykora/vault) |
| develop | [![Build status](https://ci.appveyor.com/api/projects/status/w3u8l7sd6qbvrw59/branch/develop?svg=true)](https://ci.appveyor.com/project/kensykora/vault/branch/develop) |

**Version 0.9, Designed for Umbraco 6.x**

***Note**: We're already hard at work developing and testing a more refined version of Vault designed to support Umbraco 7. Some features identified in this document may not apply to newer versions of Umbraco Vault. But don't worry, the good stuff will stick around.*

***Also note**: Vault has a lot of features. We're actively working on documenting all of them, but this may take some time; this document is not yet complete.*

TODO: Mention uComponents requirement here? OR: rip out ucomponents requirement because it's dumb as a dependency? 

## Notes:

 * Currently depends on build artifact pacakage from private appveyor nuget feed. Please manually add the Repository <https://ci.appveyor.com/nuget/umbracovault-5m6ate96gcwx> or run the command

```
nuget Sources Add -Name UmbracoVaultBuild -Source https://ci.appveyor.com/nuget/umbracovault-5m6ate96gcwx -UserName %NUGET_USERNAME% -Password %NUGET_PASSWORD%
```

Please contact project developers to get access to the nuget feed