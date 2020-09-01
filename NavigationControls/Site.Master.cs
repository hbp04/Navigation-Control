using System;
using System.Web.UI.WebControls;

namespace NavigationControls
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SiteMapPath1_ItemCreated(object sender, SiteMapNodeItemEventArgs e)
        {
            if (e.Item.ItemType == SiteMapNodeItemType.Root ||
     (e.Item.ItemType == SiteMapNodeItemType.PathSeparator && e.Item.ItemIndex == 1))
            {
                
                e.Item.Visible = false;
            }

        }
    }
}