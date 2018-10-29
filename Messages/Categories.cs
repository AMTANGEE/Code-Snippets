using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_Snippets.Messages
{
    public class Templates
    {
        public AMTANGEE.SDK.Messages.Category GetCategoryByName(string name, bool includePrivateCategories = true, bool includePublicCategories = true)
        {
            foreach (AMTANGEE.SDK.Messages.Category category in new AMTANGEE.SDK.Messages.Categories(AMTANGEE.SDK.Global.CurrentUser, (!includePrivateCategories && includePublicCategories), false))
            {
                if (category.Name == name)
                {
                    if (includePrivateCategories && !category.IsPublic)
                        return category;

                    if (includePublicCategories && category.IsPublic)
                        return category;
                }
            }
            return null;
        }
    }
}
