using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.ExpressApp.EasyTest.WinAdapter;
using DevExpress.EasyTest.Framework;
using AdditionalCommands;

namespace ExtendedAdapters
{
    public class ExtendedWinAdapter : WinAdapter
    {
        public override void RegisterCommands(DevExpress.EasyTest.Framework.IRegisterCommand registrator)
        {
            base.RegisterCommands(registrator);
            registrator.RegisterCommand("FillDateTimeValue", typeof(FillDateTimeValueCommand));
        }
    }
}
