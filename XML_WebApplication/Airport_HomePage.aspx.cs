using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XML_WebApplication
{
    public partial class Airport_HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            Airport_Information.airportSoapClient client = new Airport_Information.airportSoapClient("airportSoap");
            string userInput = txtInput.Text;
            txtOutput.Text =  client.GetAirportInformationByCountry(userInput);
            
        }
    }
}