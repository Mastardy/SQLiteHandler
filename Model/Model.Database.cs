using System.Collections.Generic;

namespace SQLiteHandler.Model;

public partial class Model
{
    public struct Database
    {
        public string Name;
    }
    
    public delegate void OnComplete(string name);

    private List<Database> Databases { get; } = new List<Database>();
    public event OnComplete OnDatabaseComplete;

    public bool NewDatabase(string name)
    {
        if (HasDatabase(name)) return false;

        Databases.Add(new Database { Name = name });
        OnDatabaseComplete?.Invoke(name);

        return true;
    }

    private bool HasDatabase(string name)
    {
        for (var i = 0; i < Databases.Count; i++)
        {
            if (Databases[i].Name == name) return true;
        }

        return false;
    }
}