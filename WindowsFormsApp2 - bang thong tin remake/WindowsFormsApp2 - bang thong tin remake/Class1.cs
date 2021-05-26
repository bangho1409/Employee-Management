using System;

public class Employee
{
    string namenv;
    string agenv;
    string addressnv;
    string shiftnv;
    string jobnv;
    string paynv;

	public Employee()
	{
        namenv = "";
        agenv = "";
        addressnv = "";
        shiftnv = "";
        jobnv = "";
        paynv = "";
	}

    public Employee(string nnv, string anv, string adnv, string snv,string jnv ,string pnv)
    {
        namenv = nnv;
        agenv = anv;
        addressnv = adnv;
        shiftnv = snv;
        jobnv = jnv;
        paynv = pnv;
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
    public String getshift()
    {
        return shiftnv;
    }
    public String getjob()
    {
        return jobnv;
    }
    public string getpay()
    {
        return paynv;
    }
}
