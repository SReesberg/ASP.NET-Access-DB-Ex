using System;
using System.Data;
using System.Collections;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamPrepExercise6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Class1 methods = new Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            methods.ConnectToDatabase();

            Repeater1.DataSource = methods.Data();     //CHECK THE SOURCE TAB FOR THE REPEATER REMEMBER THIS
            Repeater1.DataBind();
            
            


            
            


        }

        
    }
}