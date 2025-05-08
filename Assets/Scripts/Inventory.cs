//Javier Gomez Zuñiga
//Ismael Ortega Sanchez

using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class Inventory : MonoBehaviour
{
    VisualElement inv;
    VisualElement boton_poti;
    VisualElement boton_arrow;
    VisualElement boton_beer;

    List<Individuo> list_individuos;
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        inv = root.Q<VisualElement>("inventory");

        boton_poti = root.Q<Button>("btn-poti");
        boton_arrow = root.Q<Button>("btn-arrow");
        boton_beer = root.Q<Button>("btn-beer");

        boton_poti.RegisterCallback<ClickEvent>(NuevaPoti);
        boton_arrow.RegisterCallback<ClickEvent>(NuevaArrow);
        boton_beer.RegisterCallback<ClickEvent>(NuevaBeer);



        list_individuos = BaseDatos.getData();
        CrearTarjetasJson();
    }
    void NuevaPoti(ClickEvent e)
    {
        VisualTreeAsset plantilla = Resources.Load<VisualTreeAsset>("item");
        VisualElement tarjeta = plantilla.Instantiate();
        tarjeta.AddToClassList("item-frame");
        inv.Add(tarjeta);
        Individuo ind = new Individuo("Potion");
        Tarjeta tar = new Tarjeta(tarjeta, ind);

        list_individuos.Add(ind);
        Guardar();
    }
    void NuevaArrow(ClickEvent e)
    {
        VisualTreeAsset plantilla = Resources.Load<VisualTreeAsset>("item");
        VisualElement tarjeta = plantilla.Instantiate();
        tarjeta.AddToClassList("item-frame");
        inv.Add(tarjeta);
        Individuo ind = new Individuo("Arrows");
        Tarjeta tar = new Tarjeta(tarjeta, ind);

        list_individuos.Add(ind);
        Guardar();
    }
    void NuevaBeer(ClickEvent e)
    {
        VisualTreeAsset plantilla = Resources.Load<VisualTreeAsset>("item");
        VisualElement tarjeta = plantilla.Instantiate();
        tarjeta.AddToClassList("item-frame");
        inv.Add(tarjeta);
        Individuo ind = new Individuo("Beer");
        Tarjeta tar = new Tarjeta(tarjeta, ind);

        list_individuos.Add(ind);
        Guardar();
    }
    void CrearTarjetasJson()
    {
        list_individuos.ForEach(elem =>
        {
            VisualTreeAsset plantilla = Resources.Load<VisualTreeAsset>("item");
            VisualElement tarjeta = plantilla.Instantiate();
            tarjeta.AddToClassList("item-frame");
            inv.Add(tarjeta);
            Individuo ind = new Individuo(elem.Nombre);
            Tarjeta tar = new Tarjeta(tarjeta, ind);
        });
    }
    void Guardar()
    {
        string json = JsonHelper.ToJson(list_individuos, true);
        string path = Path.Combine(Application.persistentDataPath, "individuos.json"); ;
        File.WriteAllText(path, json);

        Debug.Log(path);
    }
}