using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Web;

namespace AlloyTraining.Business.Channels
{
    public class MobileChannel : DisplayChannel
    {
        public override string ChannelName { get { return "Mobile"; } }

        public override bool IsActive(HttpContextBase context)
        {
            return context.Request.Browser.IsMobileDevice;            
        }

        public override string ResolutionId => typeof(MobileResolution).FullName;
    }
}