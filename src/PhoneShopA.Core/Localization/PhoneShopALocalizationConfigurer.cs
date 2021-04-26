using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PhoneShopA.Localization
{
    public static class PhoneShopALocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PhoneShopAConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PhoneShopALocalizationConfigurer).GetAssembly(),
                        "PhoneShopA.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
