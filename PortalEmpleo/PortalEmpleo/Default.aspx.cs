using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace PortalEmpleo
{
	public partial class _Default : Page
	{
		private void cmdSignOut_ServerClick(object sender, System.EventArgs e)
		{
			FormsAuthentication.SignOut();
			Response.Redirect("Logon.aspx", true);
			this.cmdSignOut.ServerClick += new System.EventHandler(this.cmdSignOut_ServerClick);
		}
		
		}
}