using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class ARKTheme : IWidgetFactory
    {
        ARKThemeButton button = new ARKThemeButton();
        public override string ToString()
        {
            return base.ToString() + "ARK";
        }
        public string ChargerTheme()
        {
            
            return button.GetColorButton();
        }
    }
}
