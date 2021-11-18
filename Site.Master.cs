using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIN_Labaratoriji
{
    public partial class SiteMaster : MasterPage
    {
        string User = "Luka";
        string Pass = "test";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IsLogged"] == null || Session["IsLogged"] == "No")
            {
                Login_Btn.Visible = true;
                LoggedAs_Label.Visible = false;
                Logout_Btn.Visible = false;
            }
            else
            {
                Username.Visible = false;
                Password.Visible = false;
                Login_Btn.Visible = false;
                LoggedAs_Label.Visible = true;
                LoggedAs_Label.Text = "Logirani ste kao: " + User.ToUpper();
                Logout_Btn.Visible = true;
            }
        }
        protected void LoginButton(object sender, EventArgs e)
        {
            if (Username.Text == User && Password.Text == Pass)
            {
                Session["IsLogged"] = "Yes";
                Response.Redirect("About.aspx");
            }
        }

        protected void LogoutButton(object sender, EventArgs e)
        {
            Session["IsLogged"] = "No";
            Response.Redirect("Default.aspx");
        }
    }
}