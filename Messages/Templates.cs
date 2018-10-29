using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_Snippets.Messages
{
    public class Templates
    {
        public AMTANGEE.SDK.Email.Template GetEmailTemplateByName(string name)
        {
            foreach(var t in new AMTANGEE.SDK.Email.Templates(AMTANGEE.SDK.Global.CurrentUser))
            {
                if (t.Name == name)
                    return t;
            }
            return null;
        }

        public AMTANGEE.SDK.Email.Template GetEmailTemplateByGuid(Guid guid)
        {
            var t = new AMTANGEE.SDK.Email.Template(guid);
            if (t.ExistsAndLoadedAndRights)
                return t;

            return null;
        }
    }
}
