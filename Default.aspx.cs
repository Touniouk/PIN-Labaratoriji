using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIN_Labaratoriji
{
    public partial class _Default : Page
    {
        private string MagicWord = "magija";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                checkMagicWord();
            }
        }
        private void checkMagicWord()
        {
            // kod za provjeru
            if (EnterMagicWord_Text.Text == MagicWord)
            {
                Label1.Visible = false;
                Label2.Visible = true;
            }
            {/*TODO 01: Add Label3 for word that is not magic word
               TODO 02: Add if else function that will switch labels from right/ wrong magic word entered*/}
        }

        protected void CheckMagicWord_Button_Click(object sender, EventArgs e)
        {
            checkMagicWord();
        }
    }
}