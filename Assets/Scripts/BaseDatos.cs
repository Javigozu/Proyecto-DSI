using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BaseDatos
{
    public static List<Individuo> getData()
    {
        string path = Path.Combine(Application.persistentDataPath, "individuos.json"); ;
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            return JsonHelper.FromJson<Individuo>(json);
        }
        else return new List<Individuo>();
    }
}