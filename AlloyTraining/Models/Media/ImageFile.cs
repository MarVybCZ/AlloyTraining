using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "31b74a04-9264-4bdc-91c6-391786cd51a1", Description = "")]
    /*[MediaDescriptor(ExtensionString = "pdf,doc,docx")]*/
    public class ImageFile : ImageData
    {
        
                //[CultureSpecific]
                //[Editable(true)]
                //[Display(
                //    Name = "Description",
                //    Description = "Description field's description",
                //    GroupName = SystemTabNames.Content,
                //    Order = 1)]
                public virtual string Description { get; set; }
         
    }
}