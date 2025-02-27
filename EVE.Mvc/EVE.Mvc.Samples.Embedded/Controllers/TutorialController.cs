﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace EVE.Mvc.Samples.Embedded.Controllers
{
    public class TutorialController : Controller
    {
        public ActionResult RetrieveHtml()
        {
            return new EmbeddedHtmlStringResult("EVE.Mvc.Samples.Embedded.Assets.Tutorial.EFS.Setup.Setup.html",
                this.GetType().Assembly);
        }

        public ActionResult HtmlResult()
        {
            return new EmbeddedHtmlStringResult("EVE.Mvc.Samples.Embedded.Assets.Tutorial.EFS.EmbeddedHtmlResult.HtmlResult.html",
                this.GetType().Assembly);
        }


        public ActionResult RazorResult()
        {
            return new EmbeddedHtmlStringResult("EVE.Mvc.Samples.Embedded.Assets.Tutorial.EFS.Razor.RazorResult.html",
                this.GetType().Assembly);
        }

        public ActionResult CreatePlugin()
        {
            return new EmbeddedHtmlStringResult("EVE.Mvc.Samples.Embedded.Assets.Tutorial.Plugin.CreatePlugin.CreatePlugin.html",
                this.GetType().Assembly);
        }

        public ActionResult InitializePlugin()
        {
            return new EmbeddedHtmlStringResult("EVE.Mvc.Samples.Embedded.Assets.Tutorial.Plugin.Initialize.Initialize.html",
                this.GetType().Assembly);
        }
       
        public ActionResult MEFCatalog()
        {
            return new EmbeddedHtmlStringResult("EVE.Mvc.Samples.Embedded.Assets.Tutorial.Plugin.MEF.mef.html",
                this.GetType().Assembly);
        }
    }
}
