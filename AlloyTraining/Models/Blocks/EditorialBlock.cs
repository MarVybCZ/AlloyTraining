using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "EditorialBlock", GUID = "4b42eb93-c890-4d6f-8c03-8e94892d56d8", Description = "")]
    public class EditorialBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Main Body", Description = "Editorial Body", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}