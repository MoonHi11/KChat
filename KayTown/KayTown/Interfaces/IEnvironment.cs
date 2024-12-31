using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace KayTown.Interfaces
{
    public interface IEnvironment
    {
        void SetStatusBarColor(System.Drawing.Color color, bool darkStatusBarTilt, System.Drawing.Color StatusBarItems);
    }
}
