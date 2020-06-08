using BudgetApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class DataManager
{
    private static String dataFile { get { return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "BudgetData.dat"); } }


    public static void Save(Budget budget)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = File.OpenWrite(dataFile);
        bf.Serialize(fs, budget);
        fs.Close();
    }

    public static Budget Load()
    {
        if (System.IO.File.Exists(dataFile))
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(dataFile);
                Budget budget = (Budget)bf.Deserialize(fs);
                fs.Close();
                return budget;
            }
            catch
            {
                return null;
            }
        }
        else
        {
            return null;
        }
    }
}

