using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceEMP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:Users\M-AQIB\Desktop\Github\WcfServiceEMP\WcfServiceEMP\App_Data\EMPServices.mdf';Integrated Security=True");

        public void employeeRecord(empData ed)
        {
            SqlCommand cmd = new SqlCommand("insert into TblEmpRecord(Id,Name,Contact,Designation,Salary)values(@EmpID,@EmpName,@EmpContact,@EmpDesignation,@EmpSalary)", conn);

            cmd.Parameters.AddWithValue("@EmpID", ed.EmployeeID);
            cmd.Parameters.AddWithValue("@EmpName", ed.EmpName);
            cmd.Parameters.AddWithValue("@EmpContact", ed.EmpContact);
            cmd.Parameters.AddWithValue("@EmpDesignation", ed.EmpDesignation);
            cmd.Parameters.AddWithValue("@EmpSalary", ed.EmpSalary);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

    }
}
