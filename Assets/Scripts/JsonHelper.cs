using System.Collections.Generic;
using UnityEngine;

public static class JsonHelper
{
    public static List<Individuo> FromJson<Individuo>(string json)
    {
        ListaIndividuo<Individuo> listaIndividuo = JsonUtility.FromJson<ListaIndividuo<Individuo>>(json);
        return listaIndividuo.Individuos;
    }
    public static string ToJson<Individuo>(List<Individuo> list)
    {
        ListaIndividuo<Individuo> listaIndividuo = new ListaIndividuo<Individuo>();
        listaIndividuo.Individuos = list;
        return JsonUtility.ToJson(listaIndividuo);
    }
    public static string ToJson<Individuo>(List<Individuo> list, bool prettyPrint)
    {
        ListaIndividuo<Individuo> listaIndividuo = new ListaIndividuo<Individuo>();
        listaIndividuo.Individuos = list;
        return JsonUtility.ToJson(listaIndividuo, prettyPrint);
    }

    [System.Serializable]
    private class ListaIndividuo<Individuo>
    {
        public List<Individuo> Individuos;
    }
}