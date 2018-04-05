using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyTraining.Models.ViewModels
{
    public class ListingBlockModel
    {
        public virtual string Heading { get; set;  }
        public virtual IEnumerable<PageData> Items { get; set; }
    }
}