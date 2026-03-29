HaloGeneric haloGeneric = new HaloGeneric();
haloGeneric.SapaUser("Farhan");

DataGeneric<long> nim = new DataGeneric<long>(103022400083);
nim.PrintData();

class HaloGeneric
{
    public void SapaUser(string x)
    {
        Console.WriteLine("Halo user " + x);
    }
}

class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}