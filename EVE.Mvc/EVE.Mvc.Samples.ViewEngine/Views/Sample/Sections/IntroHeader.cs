﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE.Mvc.Samples.ViewEngine.Views.Sample.Sections
{
   [EmbeddedView("eve-Assets.Views.Sample.Sections.IntroHeader.html")]
    public class IntroHeader:EmbeddedView
    {
        public override void ProcessView(System.Web.Mvc.ViewContext viewContext)
        {
            //throw new NotImplementedException();
        }
    }
}
