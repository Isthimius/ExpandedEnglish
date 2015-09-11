using System;
using System.Configuration;
using System.Reflection;

namespace ExpandedEnglish.Config
{
    public class ExpandedEnglishConfig : ConfigurationSection
    {
        public const string ConfigSectionName = "ExpandedEnglish";

        #region static
        private static ExpandedEnglishConfig _instance = null;

        static ExpandedEnglishConfig()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _instance = (ExpandedEnglishConfig)config.Sections[ConfigSectionName];
        }

        public static ExpandedEnglishConfig Open()
        {
            return _instance;
        }
        #endregion

        private ExpandedEnglishConfig() { }

        #region public properties
        public string ConfigPath
        {
            get { return this.CurrentConfiguration.FilePath; }
        }

        [ConfigurationProperty("Conversions", IsRequired = true, IsDefaultCollection = true)]
        public Conversions Conversions
        {
            get { return (Conversions)this["Conversions"]; }
            set { this["Conversions"] = value; }
        }
        #endregion
    }
}