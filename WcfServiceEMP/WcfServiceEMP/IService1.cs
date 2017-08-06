using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceEMP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
     [OperationContract]
    void employeeRecord(empData ed);

	// TODO: Add your service operations here
}
[DataContract]
public class empData
{
    int EmpID;
    string Name;
    string Contact;
    string Designation;
    int Salary;

    [DataMember]
    public int EmployeeID
    {
        set { EmpID = value; }
        get { return EmpID; }
    }

    [DataMember]
    public string EmpName
    {
        set { Name = value; }
        get { return Name; }
    }

    [DataMember]  
    public string EmpContact
    {
        set { Contact = value; }
        get { return Contact; }
    }

    [DataMember]
    public string EmpDesignation
    {
        set { Designation = value; }
        get { return Designation; }
    }

    [DataMember]
    public int EmpSalary
    {
        set { Salary = value; }
        get { return Salary; }
    }

  }
}

