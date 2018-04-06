using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "FAQPage", GUID = "8db25320-e293-4812-a253-d1203932f087", Description = "")]
    public class FAQPage : SitePageData
    {
        [Ignore]
        public IList<FAQItem> FAQItems { get; set; }
    }
}