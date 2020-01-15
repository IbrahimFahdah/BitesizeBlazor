using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CascadingValues
{
    public class Theme
    {
        public string btClass { get; set; } ="btn-primary";
        private bool _toggle;

        public void ToggleTheme()
        {
            _toggle = !_toggle;
            btClass = _toggle ? "btn-danger" : "btn-primary";
        }
    }
}
