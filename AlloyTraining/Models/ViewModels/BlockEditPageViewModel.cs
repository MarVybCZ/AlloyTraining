using AlloyTraining.Models.Pages;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlloyTraining.Models.ViewModels
{
    public class BlockEditPageViewModel : IPageViewModel<SitePageData>
    {
        public SitePageData CurrentPage { get; set; }
        public PreviewBlock previewBlock {get; set;}

        public BlockEditPageViewModel(PageData page, IContent content)
        {
            previewBlock = new PreviewBlock(page, content);

            CurrentPage = page as SitePageData;
        }
    }
}