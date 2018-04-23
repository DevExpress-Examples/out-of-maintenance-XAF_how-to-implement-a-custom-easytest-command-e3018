using System;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace AdditionalCommands.Module.Web
{
    [ToolboxItemFilter("Xaf.Platform.Web")]
    public sealed partial class AdditionalCommandsAspNetModule : ModuleBase
    {
        public AdditionalCommandsAspNetModule()
        {
            InitializeComponent();
        }
    }
}
