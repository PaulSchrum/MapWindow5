﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Plugins.Concrete;

namespace MW5.Plugins.Interfaces
{
    /// <summary>
    /// Methods and properties provided by MapWindow GIS toolbox.
    /// </summary>
    public interface IToolbox
    {
        /// <summary>
        /// List of groups provided by toolbox
        /// </summary>
        IToolboxGroups Groups { get; }

        /// <summary>
        /// Provides access to all tools as common list
        /// </summary>
        IToolCollection Tools { get; }

        /// <summary>
        /// Creates a new instance of GisTool class
        /// </summary>
        IGisTool CreateTool(string name, string key, PluginIdentity identity);

        /// <summary>
        /// Creates a new instance of GisToolboxGroup class
        /// </summary>
        IToolboxGroup CreateGroup(string name, string key, PluginIdentity identity);

        /// <summary>
        /// Expands all the groups up to the target level
        /// </summary>
        void ExpandGroups(int level);

        /// <summary>
        /// Removes groups and tools added by specified plugin
        /// </summary>
        void RemoveItemsForPlugin(PluginIdentity identity);
    }
}

