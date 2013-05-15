using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TroubleShooter.Classen
{
    public class DialogElement
    {
        public String dialogID { get; set; }
        public String dialogText { get; set; }
        public String dialogArt { get; set; }

        public List<String> antwortenIDs { get; set; }


        public DialogElement()
        {
            this.antwortenIDs = new List<String>();
        }
    }
}
