using System;
using UnityEngine;

namespace ConditionalHideAttribute
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property |
                    AttributeTargets.Class | AttributeTargets.Struct, Inherited = true)]
    public class ConditionalHideAttribute : PropertyAttribute
    {
        public string ConditionalSourceField = "";
        public bool HideInInspector = false;

        public ConditionalHideAttribute(string conditionalSourceField)
        {
            this.ConditionalSourceField = conditionalSourceField;
            this.HideInInspector = false;
        }

        public ConditionalHideAttribute(string conditionalSourceField, bool hideInInspector)
        {
            this.ConditionalSourceField = conditionalSourceField;
            this.HideInInspector = hideInInspector;
        }
    }
}
