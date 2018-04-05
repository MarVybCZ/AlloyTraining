using System;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "e86a94fc-a4cc-46c6-b903-c54de5e30728", Description = "Alloy Standard Page")]
    public class StandardPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 310)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            Name = "Teaser",
            Description = "Teaser",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual TeaserBlock Teaser { get; set; }

    }
}