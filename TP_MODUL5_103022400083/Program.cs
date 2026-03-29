HaloGeneric haloGeneric = new HaloGeneric();
haloGeneric.SapaUser<string>("Farhan");

DataGeneric<long> nim = new DataGeneric<long>(103022400083);
nim.PrintData();

class HaloGeneric
{
    public void SapaUser<T>(T data)
    {
        Console.WriteLine("Halo user " + data);
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