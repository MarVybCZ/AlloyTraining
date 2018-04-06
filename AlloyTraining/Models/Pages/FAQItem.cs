using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "FAQItem", GUID = "f76d5329-7b3d-4f95-a193-c30f24a353bf", Description = "", AvailableInEditMode = false)]
    public class FAQItem : SitePageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */

        [Display(GroupName = SystemTabNames.Content, Order = 10)]
        public virtual string Question { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 20)]
        public virtual XhtmlString Answer { get; set; }
    }
}