using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Servis03012018
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Sample : System.Web.Services.WebService
{

    public Sample()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    public enum WeekDays
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    }
    [WebMethod(Description = "Kerem'in metodu")]
    public WeekDays HelloWorld(WeekDays wd)
    {
        return wd;
    }
    [WebMethod]
    public string HelloWorld2(DataTable dt)
    {
        return "Hello World";
    }

    [WebMethod]
    public DataTable GetData(string parametre)
    {
        DataTable dt=new DataTable("Data");
        DataColumn dc=new DataColumn("FirstColumn");
        DataColumn dc2 = new DataColumn("SecondColumn");
        dt.Columns.Add(dc);
        dt.Columns.Add(dc2);
        DataRow dr = dt.NewRow();
        dr[0] = "İlk Değer";
        dr[1] = "İkinci değer";
        dt.Rows.Add(dr);
        return dt;
    }

    [WebMethod]
    public FormData GetFormData(string parametre)
    {
        FormData fd=new FormData();
        fd.Ad = "ABC";
        fd.Id = 1;
        return fd;
    }

}

public class FormData
{
    public string Ad { get; set;}
    public int Id { get; set; }

}


