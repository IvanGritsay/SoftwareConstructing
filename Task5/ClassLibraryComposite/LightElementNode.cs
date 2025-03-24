using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryComposite
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public string DisplayType { get; set; }
        public string ClosingType { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses = null, List<LightNode> children = null)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
            CssClasses = cssClasses ?? new List<string>();
            Children = children ?? new List<LightNode>();
        }

        public override string OuterHTML(string indent = "")
        {
            string classAttr = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
            if (ClosingType == "single")
            {
                return $"{indent}<{TagName}{classAttr}/>\n";
            }
            else
            {
                string innerIndent = indent + "    ";
                string innerHTML = Children.Select(child => child.OuterHTML(innerIndent)).Aggregate((a, b) => a + b);
                return $"{indent}<{TagName}{classAttr}>\n{innerHTML}{indent}</{TagName}>\n";
            }
        }

        public override string InnerHTML(string indent = "")
        {
            return Children.Select(child => child.OuterHTML(indent)).Aggregate((a, b) => a + b);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }
    }

}
