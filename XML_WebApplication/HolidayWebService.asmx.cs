using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace XML_WebApplication
{
    /// <summary>
    /// Summary description for HolidayWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class HolidayWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public HolidayDest ProvideHolidayDestination(string Continent,string weather_pref)
        {
            HolidayDest obj = new HolidayDest();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Test"].ConnectionString);
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("usp_selectdestination", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter paramCont = new SqlParameter();
                SqlParameter paramWeath = new SqlParameter();
                paramCont.ParameterName = "@Continent_name";
                paramWeath.ParameterName = "@Weather_Pref";
                paramWeath.Value = weather_pref;
                paramCont.Value = Continent;
                cmd.Parameters.Add(paramCont);
                cmd.Parameters.Add(paramWeath);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    obj.Country = reader["Country"].ToString(); 
                }
            }
            return obj;
        }
    }
}
