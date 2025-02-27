﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Primitives;
using System.Configuration.Provider;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVE.Mvc.Composition
{
    /// <summary>
    /// Base class for Catalog provider
    /// </summary>
    public abstract class BaseCatalogFactory : ProviderBase
    {
        /// <summary>
        /// Method definition to be overridden in child implementations that creates the MEF catalog
        /// </summary>
        /// <returns>Eve MEF catalog</returns>
        public abstract ComposablePartCatalog CreateCatalog();
    }
}
