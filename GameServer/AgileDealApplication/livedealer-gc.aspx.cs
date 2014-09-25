using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AgileDealServerSide;

namespace AgileDealApplication
{
    public partial class livedealer_gc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Query Strings for receiving values
            string MemberCode = Request.QueryString["MemberCode"];
            string LoginID = string.Empty;
            string Token = Request.QueryString["Token"];
            string IPAddress = string.Empty;
            string Lang = string.Empty;

            bool MemberCodeExistence = MemberCode != null ? true : false;
            bool TokenExistence = Token != null ? true : false;

            if (MemberCodeExistence)
            {
                if (TokenExistence)
                {
                    Authentication auth = new Authentication(MemberCode.ToString(), Token.ToString());
                    Response.Clear();
                    Response.ContentType = "text/xml";
                    Response.Write(auth.AuthenticateMember());
                    Response.End();
                }
                else
                {
                    Response.Clear();
                    Response.Write("Error with query string");
                    Response.End();
                }
            }
            else
            {
                Response.Clear();
                Response.Write("Error with query string");
                Response.End();
            }
        }
    }
}