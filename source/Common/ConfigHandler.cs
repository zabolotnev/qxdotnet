using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace qxDotNet.Common
{
    public class ConfigHandler : ConfigurationSection
    {

        [ConfigurationProperty("applications")]
        public ConfigApplicationCollection Applications
        {
            get
            {
                return (ConfigApplicationCollection)this["applications"];
            }
        }

    }

    [ConfigurationCollection(typeof(ConfigApplicationHandler), AddItemName = "qxApplication")]
    public class ConfigApplicationCollection : ConfigurationElementCollection
    {

        protected override ConfigurationElement CreateNewElement()
        {
            return new ConfigApplicationHandler();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ConfigApplicationHandler)element).Path;
        }

        public ConfigApplicationHandler this[int idx]
        {
            get
            {
                return(ConfigApplicationHandler)BaseGet(idx);
            }
        }

    }

    public class ConfigApplicationHandler : ConfigurationSection
    {
        [ConfigurationProperty("path", IsKey=true, IsRequired = true)]
        public string Path
        {
            get
            {
                return (string)this["path"];
            }
            set
            {
                this["path"] = value;
            }
        }

        [ConfigurationProperty("type", IsRequired = true)]
        public string Type
        {
            get
            {
                return (string)this["type"];
            }
            set
            {
                this["type"] = value;
            }
        }
    }

}
