using System;

public class Employee
{
    string namenv;
    string agenv;
    string addressnv;
    string roomnv;
    string jobnv;

	public Employee()
	{
        namenv = "";
        agenv = "";
        addressnv = "";
        roomnv = "";
        jobnv = "";
	}

    public Employee(string nnv, string anv, string adnv, string rnv,string jnv )
    {
        namenv = nnv;
        agenv = anv;
        addressnv = adnv;
        roomnv = rnv;
        jobnv = jnv;
    }

    public String getname()
    {
        return namenv;
    }
    public String getage()
    {
        return agenv;
    }
    public String getaddress()
    {
        return addressnv;
    }
    public String getroom()
    {
        return roomnv;
    }
    public String getjob()
    {
        return jobnv;
    }
}
