using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void generateHiddenNumber()
    {
        Random r = new Random();
        Session["hiddenNumber"] = r.Next(100) + 1;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            generateHiddenNumber();
        }
    }

    protected void BVerify_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["hiddenNumber"] == null) generateHiddenNumber();

            int hiddenNumber = (int)Session["hiddenNumber"];
            int guessedNumber = int.Parse(TBNumber.Text);

            if (guessedNumber == hiddenNumber)
            {
                LAnswer.Text = "You guessed right!";
                BTryAgain.Visible = true;
            }
            else if (guessedNumber < hiddenNumber)
            {
                LAnswer.Text = "Hidden number is higher";
            }
            else
            {
                LAnswer.Text = "Hidden number is lower";
            }
        }
        catch (Exception)
        {
            LAnswer.Text = "Not a number!";
        }
    }

    protected void BTryAgain_Click(object sender, EventArgs e)
    {
        generateHiddenNumber();

        TBNumber.Text = "";
        LAnswer.Text = "";
        BTryAgain.Visible = false;
    }
}