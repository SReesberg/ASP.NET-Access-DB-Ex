using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace ExamPrepExercise6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Class1 methods = new Class1();
        ArrayList heroes = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                heroes.Add("-Select a hero-");

                methods.ConnectToDatabase();

                using (OleDbDataReader reader = methods.Query("SELECT DISTINCT heroName FROM [Votes];"))
                {
                    while (reader.Read())
                    {
                        heroes.Add((string)reader["heroName"]);
                    }
                }

                methods.DisconnectFromDatabase();
                foreach (var item in heroes)
                {
                    DropDownList1.Items.Add(item.ToString());
                }
            }
            



        }

        protected void BtnVote_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Class1 methods = new Class1();

                if (DropDownList1.SelectedIndex != 0)
                {
                    
                    methods.ConnectToDatabase();
                            
                    string name = TBName.Text;
                    string id = TBID.Text;
                    string heroVote = DropDownList1.SelectedValue;

                    OleDbDataReader reader = methods.Query("SELECT userID, userName FROM [Votes] WHERE userID = '" + id + "'AND userName = '" + name + "';");

                    if(reader != null && reader.HasRows)
                    {
                        LabelResult.ForeColor = System.Drawing.Color.Red;
                        LabelResult.Text = "You have already casted your vote.";
                    }
                    else
                    {
                        methods.ExecuteCommand("INSERT INTO [Votes](userID, userName, heroName) Values('" + id + "', '" + name + "', '" + heroVote + "');");
                        methods.DisconnectFromDatabase();

                        LabelResult.ForeColor = System.Drawing.Color.Green;
                        LabelResult.Text = "Your vote has been cast - thank you.";
                    }

                    methods.DisconnectFromDatabase();


                }
                else
                {
                    LabelResult.ForeColor = System.Drawing.Color.Red;
                    LabelResult.Text = "You need to select a hero...";

                }
            }
        }
    }
}