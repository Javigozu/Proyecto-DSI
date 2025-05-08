// Javier Gomez Zuñiga
// Ismael Ortega Sanchez

using UnityEngine;
using UnityEngine.UIElements;

public class TabMenu : MonoBehaviour
{
    VisualElement pest_inv;
    VisualElement pest_stats;
    VisualElement pest_map;

    VisualElement cont_inv;
    VisualElement cont_stats;
    VisualElement cont_map;
    private void OnEnable()
    {
        UIDocument uidoc = GetComponent<UIDocument>();
        VisualElement root = uidoc.rootVisualElement;
        VisualElement pestanyas = root.Q("pestanyas");


        pest_inv = pestanyas.Q("pest-inv");
        pest_stats = pestanyas.Q("pest-stats");
        pest_map = pestanyas.Q("pest-map");

        cont_inv = root.Q("cont-inv");
        cont_stats = root.Q("cont-stats");
        cont_map = root.Q("cont-map");

        VisualElement scroll = cont_map.Q("scrollMap");
        VisualElement mapa = scroll.Q("dragMap");
        mapa.AddManipulator(new ResizeMap((ScrollView)scroll));

        pest_inv.RegisterCallback<MouseDownEvent>(evt =>
        {
            NoDisplay();
            pest_inv.style.backgroundColor = new Color(0.94f, 0.4f, 0.4f, 1.0f);
            cont_inv.style.display = DisplayStyle.Flex;
        });
        pest_stats.RegisterCallback<MouseDownEvent>(evt =>
        {
            NoDisplay();
            pest_stats.style.backgroundColor = new Color(0.4f, 0.73f, 0.99f, 1.0f);
            cont_stats.style.display = DisplayStyle.Flex;
        });
        pest_map.RegisterCallback<MouseDownEvent>(evt =>
        {
            NoDisplay();
            pest_map.style.backgroundColor = new Color(0.65f, 0.93f, 0.27f, 1.0f);
            cont_map.style.display = DisplayStyle.Flex;
        });
    }
    void NoDisplay()
    {
        pest_inv.style.backgroundColor = new Color(0.94f, 0.55f, 0.55f, 1.0f);
        cont_inv.style.display = DisplayStyle.None;
        pest_stats.style.backgroundColor = new Color(0.75f, 0.83f, 0.9f, 1.0f);
        cont_stats.style.display = DisplayStyle.None;
        pest_map.style.backgroundColor = new Color(0.8f, 0.9f, 0.66f, 1.0f);
        cont_map.style.display = DisplayStyle.None;
    }
}
