using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Text;

public partial class RegisterMember : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdRegister_Click(object sender, EventArgs e)
    {
        string requestBody = "<RegisterMember><MemberCode>" + txtMemberCode.Text + "</MemberCode><ReturnCode></ReturnCode><AccountID>" + txtAccountID.Text + "</AccountID><CurrencyCode>" + ddlCurrencyCode.SelectedValue + "</CurrencyCode><CountryCode>" + ddlCountryCode.SelectedValue + "</CountryCode><Lang>" + ddlLang.SelectedValue + "</Lang></RegisterMember>";
        string encryptedBody = CodeProcessor.Encrypt(requestBody.ToString());
        string requestFile = "<?xml version=\"1.0\" encoding=\"utf-8\"?> <Request><Header></Header><Body>" + encryptedBody.ToString() + "</Body></Request>";

        WebRequest request = WebRequest.Create("http://172.21.1.6:9123/SPI/RegisterMember");
        request.Method = "POST";

        byte[] byteArray = Encoding.UTF8.GetBytes(requestFile.ToString());

        request.ContentType = "application/x-www-form-urlencoded";
        request.ContentLength = byteArray.Length;

        Stream dataStream = request.GetRequestStream();
        dataStream.Write(byteArray, 0, byteArray.Length);
        dataStream.Close();

        WebResponse response = request.GetResponse();
        dataStream = response.GetResponseStream();

        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();

        Response.Clear();
        Response.ContentType = "text/xml";
        Response.Write(responseFromServer.ToString());
        Response.End();

        reader.Close();
        dataStream.Close();
        response.Close();
    }
}