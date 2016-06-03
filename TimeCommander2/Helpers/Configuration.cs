using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeCommander2.Helpers
{
    public class Configuration : AppSettings
    {
        public bool UseWindows7 { get; set; }
        public int UserId { get; set; }
        public bool UseKeyboardHooks { get; set; }
    }
}
