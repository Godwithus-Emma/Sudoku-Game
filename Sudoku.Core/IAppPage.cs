using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Core
{
    public interface IAppPage
    {
        bool Back();
    }

    public static class Page
    {
        public static IAppPage Current { get; set; }

    }
}
