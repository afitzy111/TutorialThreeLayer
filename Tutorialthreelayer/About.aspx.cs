using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Service;

namespace Tutorialthreelayer
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click (Object sender, EventArgs e)
        {
            try
            {
                BAL rain = new BAL();
                DataSet dstObj = rain.view();
                if (dstObj.Tables.Count > 0)
                {

                }

            }
        }
        
    }
}