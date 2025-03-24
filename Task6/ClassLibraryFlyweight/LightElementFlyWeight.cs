using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryComposite;

namespace ClassLibraryFlyweight
{
    public class LightElementFlyWeight
    {
        private Dictionary<string, LightElementNode> elementCache = new Dictionary<string, LightElementNode>();

        public LightElementNode GetElement(string tagName, string displayType, string closingType, List<LightNode> children = null) 
        {
            string key = $"{tagName}-{displayType}-{closingType}-{children?.GetHashCode() ?? 0}"; 
            if (!elementCache.ContainsKey(key))
            {
                elementCache[key] = new LightElementNode(tagName, displayType, closingType, children: children); 
            }
            return elementCache[key];
        }
    }
}
