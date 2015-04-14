using System;
namespace MyAttribute{

    [AttributeUsage(AttributeTargets.Class)]
    public class AccountMetadataAttribute: Attribute
    {
        
        public string AccountDescription { set; get; }
        public string AccountLimitations { set; get; }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    
    public class FormatRestrictionAttribute :Attribute
    {
        public string FormatString { set; get; }
        public int MaxLength { set; get; }
    }

}