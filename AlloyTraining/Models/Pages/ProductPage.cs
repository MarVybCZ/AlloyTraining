using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "Alloy Product Page", GUID = "318a83b6-afd0-4cbe-86ac-9d5e909122f4", Description = "")]
    public class ProductPage : StandardPage
    {
        [Display(GroupName = SystemTabNames.Content, Order = 305)]
        [UIHint(UIHint.Textarea)]
        public virtual string UniqueSellingPoints { get; set; }
    }
}