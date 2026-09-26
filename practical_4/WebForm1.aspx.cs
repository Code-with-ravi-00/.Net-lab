using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pra4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string skills = "";

                if (chkC.Checked)
                    skills += "C# ";

                if (chkPython.Checked)
                    skills += "Python ";

                if (chkAI.Checked)
                    skills += "AI ";

                lblResult.Text = "<h3>Registration Successful!</h3>";
                lblResult.Text += "<br/><b>Full Name:</b> " + txtName.Text;
                lblResult.Text += "<br/><b>Email:</b> " + txtEmail.Text;
                lblResult.Text += "<br/><b>Contact No:</b> " + txtMobile.Text;
                lblResult.Text += "<br/><b>Date of Birth:</b> " + txtDOB.Text;
                lblResult.Text += "<br/><b>College:</b> " + txtCollege.Text;
                lblResult.Text += "<br/><b>Department:</b> " + rblDepartment.SelectedItem.Text;
                lblResult.Text += "<br/><b>Event:</b> " + ddlEvent.SelectedItem.Text;
                lblResult.Text += "<br/><b>Gender:</b> " + rblGender.SelectedItem.Text;
                lblResult.Text += "<br/><b>Skills:</b> " + skills;
                lblResult.Text += "<br/><b>Address:</b> " + txtAddress.Text;

                if (chkTerms.Checked)
                    lblResult.Text += "<br/><b>Terms:</b> Accepted";
                else
                    lblResult.Text += "<br/><b>Terms:</b> Not Accepted";
            }
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDOB.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
        }

    }
}