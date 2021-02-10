//using Sitecore.Data.Items;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;

namespace Linde.Feature.BasicContent.Models
{
    [SitecoreType(TemplateId = "B246C59B-13CC-4C1A-AD06-D6125ECA9B03")]
    public class HeaderBuilder
    {
        //[SitecoreId]
        //public virtual Guid Id { get; set; }
        [SitecoreField("HeaderTitle")]
        public virtual string HeaderTitle { get; set; }
        [SitecoreField("HeaderBody")]
        public virtual string HeaderBody { get; set; }
        [SitecoreField("HeaderImage")]
        public virtual Image HeaderImage { get; set; }
    }
}