using System;

[System.Serializable]
public class Individuo
{
    public event Action Cambio;

    public string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public Individuo(string nombre)
    {
        this.nombre = nombre;
    }
}