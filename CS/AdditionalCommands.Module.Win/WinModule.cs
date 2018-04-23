using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace AdditionalCommands.Module.Win
{
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class AdditionalCommandsWindowsFormsModule : ModuleBase
    {
        public AdditionalCommandsWindowsFormsModule()
        {
            InitializeComponent();
        }
    }
}
