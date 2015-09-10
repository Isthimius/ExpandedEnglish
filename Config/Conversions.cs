using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpandedEnglish.Config
{
    [ConfigurationCollection(typeof(Conversion), AddItemName = "add", RemoveItemName = "remove", ClearItemsName = "clear")]
    public class Conversions : ConfigurationElementCollection, IEnumerable<Conversion>
    {
        [ConfigurationProperty("LoadAtStartup", IsRequired = false, DefaultValue = true)]
        public bool LoadAtStartup
        {
            get { return (bool)base["LoadAtStartup"]; }
            set { base["LoadAtStartup"] = value; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new Conversion();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((Conversion)element).From;
        }

        public new IEnumerator<Conversion> GetEnumerator()
        {
            foreach (var id in this.BaseGetAllKeys())
                yield return (Conversion)this.BaseGet(id);
        }

        public new Conversion this[string id]
        {
            get { return (Conversion)BaseGet(id); }
        }

        public void Add(Conversion file)
        {
            BaseAdd(file);
        }

        public void Clear()
        {
            BaseClear();
        }

        public void Remove(Conversion file)
        {
            BaseRemove(file);
        }

        public void RemoveAt(int index)
        {
            BaseRemove(index);
        }
    }
}