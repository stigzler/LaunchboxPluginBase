using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unbroken.LaunchBox.Plugins;

namespace LaunchboxPlugin.Core
{
    internal class PluginHost : ISystemMenuItemPlugin
    {
        public string Caption => "My Awesome Plugin";

        public Image IconImage => null;

        public bool ShowInLaunchBox => true;

        public bool ShowInBigBox => false;

        public bool AllowInBigBoxWhenLocked => false;

        public void OnSelected()
        {
            Debug.WriteLine("PLUGIN: My Awesome Plugin was selected!");
        }
    }
}