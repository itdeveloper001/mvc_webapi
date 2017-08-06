using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace MyWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\maqibc\documents\visual studio 2013\Projects\MyWcfService\MyWcfService\App_Data\EMP.mdf';Integrated Security=True");


       public void employeeRecord(empData ed)
       {
           SqlCommand cmd = new SqlCommand("INSERT INTO TblEmpRecord(EmpID,FName,LName,Age,Department,DOJ,EmpSalary,EmpInfo)values(@EmpID,@FName,@LName,@Age,@Dep,@DOJ,@EmpSalary,@EmpInfo)", con);
           cmd.Parameters.AddWithValue("@EmpID", ed.EmployeeNo);
           cmd.Parameters.AddWithValue("@FName", ed.FirstName);
           cmd.Parameters.AddWithValue("@LName", ed.LastName);
           cmd.Parameters.AddWithValue("@Age", ed.EmpAge);
           cmd.Parameters.AddWithValue("@Dep", ed.EmpDepartement);
           cmd.Parameters.AddWithValue("@DOJ", ed.EmpDateOFJoining);
           cmd.Parameters.AddWithValue("@EmpSalary", ed.EmpBasicSalary);
           cmd.Parameters.AddWithValue("@EmpInfo", ed.EmployeeInfo);
           con.Open();
           cmd.ExecuteNonQuery();
           con.Close();
          
       }
    }
}
