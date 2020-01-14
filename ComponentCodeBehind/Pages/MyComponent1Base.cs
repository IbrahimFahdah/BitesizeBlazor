using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentCodeBehind.Pages
{

    /// <summary>
    /// Note that you can nest the class file under its razor file by renaming the class file as "[component file name].cs"
    /// </summary>
    public class MyComponent1Base : ComponentBase
    {
        protected string btnCSSClass = "btn btn-primary";
    }


}
