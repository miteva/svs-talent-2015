using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccountClient.AccountService;

namespace AccountClient
{
    public partial class AccountClient : System.Web.UI.Page
    {
        //AccountService.AccountServiceClient proxy;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    //proxy = new AccountService.AccountServiceClient();
                
            //}
        }

        

        protected void btnCreate_Click(object sender, EventArgs e)
        {
                
                string currency;
                string note;
                decimal decimalBallance;

                if (txtBallance.Text != "" && txtCurrency.Text != "" && txtNote.Text != "")
               {

                   if (decimal.TryParse(txtBallance.Text, out decimalBallance))
                   {
                       currency = txtCurrency.Text;
                       note = txtNote.Text;
                       Response.Redirect("Manage.aspx?ballance=" + decimalBallance + "&currency=" + currency + "&note=" + note);
                   }
                   else {
                       lblError.Text = "Ballance must be number";
                   }

                }
                 
                    
                else
                    lblError.Text = "All fields are reqired";
               
             

           
        }

        
    }
}