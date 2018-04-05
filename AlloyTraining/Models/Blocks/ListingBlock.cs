using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "ListingBlock", GUID = "62711985-02f0-4ec0-a0f0-7f102e23e808", Description = "")]
    public class ListingBlock : BlockData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */

        [CultureSpecific]
        [Display(Name = "Heading", Description = "", GroupName = SystemTabNames.Content, Order = 100)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(Name = "RootPage", Description = "", GroupName = SystemTabNames.Content, Order = 200)]
        public virtual PageReference RootPage { get; set; }
    }
}