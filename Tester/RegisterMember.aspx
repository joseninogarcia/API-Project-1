<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterMember.aspx.cs" Inherits="RegisterMember" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Members</title>
    <style>
        html, body
        {
            font-family:Arial;
            font-size:12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <h4>Register Member</h4>

            <table>
                <tr>
                    <td><label>Member Code:</label></td>
                    <td><asp:TextBox ID="txtMemberCode" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><label>Account ID: </label></td>
                    <td><asp:TextBox ID="txtAccountID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><label>Currency Code:</label></td>
                    <td>
                        <asp:DropDownList ID="ddlCurrencyCode" runat="server">
                            <asp:ListItem Value="CNY">CNY</asp:ListItem>
                            <asp:ListItem Value="EUR">EUR</asp:ListItem>
                            <asp:ListItem Value="GBP">GBP</asp:ListItem>
                            <asp:ListItem Value="HKD">HKD</asp:ListItem>
                            <asp:ListItem Value="IDR">IDR</asp:ListItem>
                            <asp:ListItem Value="MYR">MYR</asp:ListItem>
                            <asp:ListItem Value="SGD">SGD</asp:ListItem>
                            <asp:ListItem Value="THB">THB</asp:ListItem>
                            <asp:ListItem Value="USD">USD</asp:ListItem>
                            <asp:ListItem Value="VND">VND</asp:ListItem>
                            <asp:ListItem Value="KRW">KRW</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><label>Country Code:</label></td>
                    <td>
                        <asp:DropDownList ID="ddlCountryCode" runat="server">
                            <asp:ListItem Value="AF">Afghanistan</asp:ListItem>
                            <asp:ListItem Value="AX">Aland Islands</asp:ListItem>
                            <asp:ListItem Value="AL">Albania</asp:ListItem>
                            <asp:ListItem Value="DZ">Algeria</asp:ListItem>
                            <asp:ListItem Value="AS">American Samoa</asp:ListItem>
                            <asp:ListItem Value="AD">Andorra</asp:ListItem>
                            <asp:ListItem Value="CN">China</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><label>Language Code: </label></td>
                    <td>
                        <asp:DropDownList ID="ddlLang" runat="server">
                            <asp:ListItem Value="en-US">English</asp:ListItem>
                            <asp:ListItem Value="zh-TW">Traditional Chinese</asp:ListItem>
                            <asp:ListItem Value="zh-CN">Simple Chinese</asp:ListItem>
                            <asp:ListItem Value="th-TH">Thai</asp:ListItem>
                            <asp:ListItem Value="ko-KR">Korean</asp:ListItem>
                            <asp:ListItem Value="vi-VN">Vietnamese</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td><asp:Button ID="cmdRegister" runat="server" Text="Create" 
                            onclick="cmdRegister_Click" /></td>
                </tr>
            </table>

    </div>
    </form>
</body>
</html>
