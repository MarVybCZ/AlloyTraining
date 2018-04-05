using System;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "NewsPage", GUID = "f53a116a-c17f-4045-9c55-5f1e28a2aa2c", Description = "")]
    public class NewsPage : StandardPage
    {        
        [Display(Name = "Main listing", Description = "", GroupName = SystemTabNames.Content, Order = 315)]
        public virtual ListingBlock MainListing { get; set; }
    }
}