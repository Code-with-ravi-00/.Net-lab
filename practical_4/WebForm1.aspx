<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="pra4.WebForm1" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
 <body>
    <form id="form1" runat="server">
        <h1> STUDENT ONLINE EVENT REGISTRATION</h1>
        <table style="height: 593px; width: 682px">
            <tr>
                <td>Full Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="* Required" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Email ID</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="* Required" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ValidationExpression="^\w+([.-]?\w+)@\w+([.-]?\w+)\.\w{2,3}$" ErrorMessage="Invalid Email" ForeColor="Red">
                    </asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Contact No.</td>
                <td>
                    <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMobile" runat="server" ControlToValidate="txtMobile" ErrorMessage="* Required" ForeColor="Red">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revMobile"  runat="server" ControlToValidate="txtMobile"   ValidationExpression="^[0-9]{10}$"  ErrorMessage="Enter 10 Digit Number"  ForeColor="Red">
                    </asp:RegularExpressionValidator>
                </td>
            </tr>

                <tr>
                <td>Date of Birth</td>
                <td>
                   

                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged">
                    </asp:Calendar>   
                    <br />
                    <asp:TextBox ID="txtDOB" runat="server" ReadOnly="true"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="rfvDOB" runat="server" ControlToValidate="txtDOB"  ErrorMessage="* Select Date of Birth" ForeColor="Red">
                    </asp:RequiredFieldValidator>

                </td>
            </tr><br/>
            <tr>
                <td>College</td>
                <td>
                    <asp:TextBox ID="txtCollege" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCollege"  runat="server"  ControlToValidate="txtCollege"  ErrorMessage="* Required"   ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Department</td>
                <td>
                    <asp:RadioButtonList ID="rblDepartment" runat="server">
                        <asp:ListItem>Computer</asp:ListItem>
                        <asp:ListItem>Mechanical</asp:ListItem>
                        <asp:ListItem>Chemical</asp:ListItem>
                        <asp:ListItem>Civil</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>Event</td>
                <td>
                    <asp:DropDownList ID="ddlEvent" runat="server">
                        <asp:ListItem>Select Event</asp:ListItem>
                        <asp:ListItem>Paper Presentation</asp:ListItem>
                        <asp:ListItem>Workshop</asp:ListItem>
                        <asp:ListItem>Hackathon</asp:ListItem>
                        <asp:ListItem>Quiz</asp:ListItem>
                    </asp:DropDownList>

                    <asp:RequiredFieldValidator ID="rfvEvent" runat="server" ControlToValidate="ddlEvent" InitialValue="Select Event" ErrorMessage="Select Event" ForeColor="Red">
                    </asp:RequiredFieldValidator>

                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>Skills</td>
                <td>
                    <asp:CheckBox ID="chkC" runat="server" Text="C#" />
                    <asp:CheckBox ID="chkPython" runat="server" Text="Python" />
                    <asp:CheckBox ID="chkAI" runat="server" Text="AI" />
                </td>
            </tr>
            <tr>
                <td>Address</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Rows="5" Columns="30">
                    </asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Terms</td>
                <td>
                    <asp:CheckBox ID="chkTerms" runat="server" Text="I accept Terms &amp; Conditions" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblResult" runat="server" ForeColor="Green">
                    </asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </form>
</body>
</html>
