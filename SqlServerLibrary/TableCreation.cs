
namespace SqlServerLibrary;

public static class TableCreation
{
    public static bool CreateTable()
    {

        try
        {
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static void CreateTable_Raw()
    {

    }
}
