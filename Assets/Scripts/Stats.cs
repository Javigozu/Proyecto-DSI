//Javier Gomez Zuñiga
//Ismael Ortega Sanchez
using UnityEngine;
using UnityEngine.UIElements;

public class Stats : MonoBehaviour
{
    CustomControl point1;
    CustomControl point2;
    CustomControl point3;
    CustomControl point4;

    VisualElement upgrade1;
    VisualElement upgrade2;
    VisualElement upgrade3;
    VisualElement upgrade4;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        VisualElement custom = root.Q<VisualElement>("customControls");
        VisualElement buttons = root.Q<VisualElement>("upgrade");

        upgrade1 = buttons.Q<Button>("upgrade1");
        upgrade2 = buttons.Q<Button>("upgrade2");
        upgrade3 = buttons.Q<Button>("upgrade3");
        upgrade4 = buttons.Q<Button>("upgrade4");

        upgrade1.RegisterCallback<ClickEvent>(Point1);
        upgrade2.RegisterCallback<ClickEvent>(Point2);
        upgrade3.RegisterCallback<ClickEvent>(Point3);
        upgrade4.RegisterCallback<ClickEvent>(Point4);

        point1 = custom.Q<VisualElement>("point1") as CustomControl;
        point2 = custom.Q<VisualElement>("point2") as CustomControl;
        point3 = custom.Q<VisualElement>("point3") as CustomControl;
        point4 = custom.Q<VisualElement>("point4") as CustomControl;

    }
    void Point1(ClickEvent e)
    {
        point1.Estado++;
    }
    void Point2(ClickEvent e)
    {
        point2.Estado++;
    }
    void Point3(ClickEvent e)
    {
        point3.Estado++;
    }
    void Point4(ClickEvent e)
    {
        point4.Estado++;
    }
}