using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            previousAssignmentEndCalendar.SelectedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            newAssignmentStartCalendar.SelectedDate = DateTime.Parse(DateTime.Now.AddDays(14).ToShortDateString());
            newAssignmentEndCalendar.SelectedDate = DateTime.Parse(DateTime.Now.AddDays(21).ToShortDateString());
        }
    }
    protected void assignSpyButton_Click(object sender, EventArgs e)
    {
        resultLabel.Text = "";
        double totalDays;
        double budgetTotal = 0;

        if((newAssignmentStartCalendar.SelectedDate.Subtract(previousAssignmentEndCalendar.SelectedDate).TotalDays) < 14)
        {
            resultLabel.Text = "Error: Must allow two weeks between previous assignment and new assignment.";
            newAssignmentStartCalendar.SelectedDate = previousAssignmentEndCalendar.SelectedDate.AddDays(14);
        }
        else if ((totalDays = newAssignmentEndCalendar.SelectedDate.Subtract(newAssignmentStartCalendar.SelectedDate).TotalDays) > 21)
        {
            budgetTotal = (totalDays * 500) + 1000;
        }
        else
        {
            totalDays = newAssignmentEndCalendar.SelectedDate.Subtract(newAssignmentStartCalendar.SelectedDate).TotalDays;
            budgetTotal = totalDays * 500;
        }

        resultLabel.Text = string.Format ("Assignment of {0} to assignment {1} is authorized. Budget Total: {2:C}", codeNameTextBox.Text,assignmentNameTextBox.Text,budgetTotal); 
    }
}