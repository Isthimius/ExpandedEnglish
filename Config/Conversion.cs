using System.Configuration;

namespace ExpandedEnglish.Config
{
    public class Conversion : ConfigurationElement
    {
        [ConfigurationProperty("From", IsRequired = true, IsKey = true)]
        public string From
        {
            get { return (string)this["From"]; }
            set { this["From"] = value; }
        }

        [ConfigurationProperty("To", IsRequired = true)]
        public string To
        {
            get { return (string)this["To"]; }
            set { this["To"] = value; }
        }
    }
}