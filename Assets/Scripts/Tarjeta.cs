using UnityEngine;
using UnityEngine.UIElements;

public class Tarjeta
{
    VisualElement tarjetaRoot;
    Individuo miIndividuo;
    Label nombreLabel;

    public Tarjeta(VisualElement tarjetaRoot, Individuo individuo)
    {
        this.tarjetaRoot = tarjetaRoot;
        this.miIndividuo = individuo;

        nombreLabel = tarjetaRoot.Q<Label>("item-label");
        this.tarjetaRoot.userData = miIndividuo;
        UpdateUI();
    }
    void UpdateUI()
    {
        VisualElement foto = tarjetaRoot.Q(className: "item");
        foto.name = "i" + miIndividuo.Nombre;
        nombreLabel.text = miIndividuo.Nombre;
    }
}