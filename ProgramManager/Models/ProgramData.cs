using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramManager.Models
{
    class ProgramData
    {
        public string PR_ID = string.Empty;
        public string PR_NAME = string.Empty;
        public Image PR_ICON = null;
        public string PR_PATH = string.Empty;
        public string PR_FILE = string.Empty;
        public string CUR_VER = string.Empty;
        public string NEW_VER = string.Empty;
        public bool INSTALLED = false;
    }
}
