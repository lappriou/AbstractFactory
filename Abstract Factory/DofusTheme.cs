using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class DofusTheme: IWidgetFactory
    {
        string color = "green";

        DofusThemeButton Button = new DofusThemeButton();
        public string ChargerTheme()
        {
            return Button.GetColorButton();
        }
    }
}
