using UnityEngine;
using UnityEngine.UIElements;

public class CustomControl : VisualElement
{
    VisualElement panel1 = new VisualElement();
    VisualElement panel2 = new VisualElement();
    VisualElement panel3 = new VisualElement();
    VisualElement panel4 = new VisualElement();
    VisualElement panel5 = new VisualElement();
    VisualElement panel6 = new VisualElement();
    VisualElement panel7 = new VisualElement();
    VisualElement panel8 = new VisualElement();
    VisualElement panel9 = new VisualElement();
    VisualElement panel10 = new VisualElement();

    int estado;

    public int Estado
    {
        get => estado;
        set
        {
            estado = value;
            encenderColor();
        }
    }
    void encenderColor()
    {
        if (estado > 10) { estado = 10; }

        panel1.style.unityBackgroundImageTintColor = new Color(0.6f, 0.46f, 0.4f);
        panel2.style.unityBackgroundImageTintColor = new Color(0.6f, 0.46f, 0.4f);
        panel3.style.unityBackgroundImageTintColor = new Color(0.6f, 0.46f, 0.4f);
        panel4.style.unityBackgroundImageTintColor = new Color(0.6f, 0.46f, 0.4f);
        panel5.style.unityBackgroundImageTintColor = new Color(0.6f, 0.46f, 0.4f);
        panel6.style.unityBackgroundImageTintColor = new Color(0.6f, 0.46f, 0.4f);
        panel7.style.unityBackgroundImageTintColor = new Color(0.6f, 0.46f, 0.4f);
        panel8.style.unityBackgroundImageTintColor = new Color(0.6f, 0.46f, 0.4f);
        panel9.style.unityBackgroundImageTintColor = new Color(0.6f, 0.46f, 0.4f);
        panel10.style.unityBackgroundImageTintColor = new Color(0.6f, 0.46f, 0.4f);

        if (Estado == 1)
        {
            panel1.style.unityBackgroundImageTintColor = Color.white;
        }
        else if (Estado == 2)
        {
            panel1.style.unityBackgroundImageTintColor = Color.white;
            panel2.style.unityBackgroundImageTintColor = Color.white;
        }
        else if (Estado == 3)
        {
            panel1.style.unityBackgroundImageTintColor = Color.white;
            panel2.style.unityBackgroundImageTintColor = Color.white;
            panel3.style.unityBackgroundImageTintColor = Color.white;
        }
        else if (Estado == 4)
        {
            panel1.style.unityBackgroundImageTintColor = Color.white;
            panel2.style.unityBackgroundImageTintColor = Color.white;
            panel3.style.unityBackgroundImageTintColor = Color.white;
            panel4.style.unityBackgroundImageTintColor = Color.white;

        }
        else if (Estado == 5)
        {
            panel1.style.unityBackgroundImageTintColor = Color.white;
            panel2.style.unityBackgroundImageTintColor = Color.white;
            panel3.style.unityBackgroundImageTintColor = Color.white;
            panel4.style.unityBackgroundImageTintColor = Color.white;
            panel5.style.unityBackgroundImageTintColor = Color.white;
        }
        else if (Estado == 6)
        {
            panel1.style.unityBackgroundImageTintColor = Color.white;
            panel2.style.unityBackgroundImageTintColor = Color.white;
            panel3.style.unityBackgroundImageTintColor = Color.white;
            panel4.style.unityBackgroundImageTintColor = Color.white;
            panel5.style.unityBackgroundImageTintColor = Color.white;
            panel6.style.unityBackgroundImageTintColor = Color.white;
        }
        else if (Estado == 7)
        {
            panel1.style.unityBackgroundImageTintColor = Color.white;
            panel2.style.unityBackgroundImageTintColor = Color.white;
            panel3.style.unityBackgroundImageTintColor = Color.white;
            panel4.style.unityBackgroundImageTintColor = Color.white;
            panel5.style.unityBackgroundImageTintColor = Color.white;
            panel6.style.unityBackgroundImageTintColor = Color.white;
            panel7.style.unityBackgroundImageTintColor = Color.white;
        }
        else if (Estado == 8)
        {
            panel1.style.unityBackgroundImageTintColor = Color.white;
            panel2.style.unityBackgroundImageTintColor = Color.white;
            panel3.style.unityBackgroundImageTintColor = Color.white;
            panel4.style.unityBackgroundImageTintColor = Color.white;
            panel5.style.unityBackgroundImageTintColor = Color.white;
            panel6.style.unityBackgroundImageTintColor = Color.white;
            panel7.style.unityBackgroundImageTintColor = Color.white;
            panel8.style.unityBackgroundImageTintColor = Color.white;
        }
        else if (Estado == 9)
        {
            panel1.style.unityBackgroundImageTintColor = Color.white;
            panel2.style.unityBackgroundImageTintColor = Color.white;
            panel3.style.unityBackgroundImageTintColor = Color.white;
            panel4.style.unityBackgroundImageTintColor = Color.white;
            panel5.style.unityBackgroundImageTintColor = Color.white;
            panel6.style.unityBackgroundImageTintColor = Color.white;
            panel7.style.unityBackgroundImageTintColor = Color.white;
            panel8.style.unityBackgroundImageTintColor = Color.white;
            panel9.style.unityBackgroundImageTintColor = Color.white;
        }
        else if (Estado == 10)
        {
            panel1.style.unityBackgroundImageTintColor = Color.white;
            panel2.style.unityBackgroundImageTintColor = Color.white;
            panel3.style.unityBackgroundImageTintColor = Color.white;
            panel4.style.unityBackgroundImageTintColor = Color.white;
            panel5.style.unityBackgroundImageTintColor = Color.white;
            panel6.style.unityBackgroundImageTintColor = Color.white;
            panel7.style.unityBackgroundImageTintColor = Color.white;
            panel8.style.unityBackgroundImageTintColor = Color.white;
            panel9.style.unityBackgroundImageTintColor = Color.white;
            panel10.style.unityBackgroundImageTintColor = Color.white;
        }
    }
    public new class UxmlFactory : UxmlFactory<CustomControl, UxmlTraits> { }

    public new class UxmlTraits : VisualElement.UxmlTraits
    {

        UxmlIntAttributeDescription myEstado = new UxmlIntAttributeDescription { name = "estado", defaultValue = 0 };
        UxmlStringAttributeDescription myName = new UxmlStringAttributeDescription { name = "nombre", defaultValue = "Point.png" };
        public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
        {
            base.Init(ve, bag, cc);
            var semaforo = ve as CustomControl;
            var imagen = ve as CustomControl;
            semaforo.Estado = myEstado.GetValueFromBag(bag, cc);
        }

    }
    public CustomControl()
    {

        /*panel1.style.width = 150;
        panel1.style.height = 150;

        panel2.style.width = 150;
        panel2.style.height = 150;

        panel3.style.width = 150;
        panel3.style.height = 150;

        panel4.style.width = 150;
        panel4.style.height = 150;

        panel5.style.width = 150;
        panel5.style.height = 150;*/

        styleSheets.Add(Resources.Load<StyleSheet>("Styles"));

        panel1.AddToClassList("point");
        panel2.AddToClassList("point");
        panel3.AddToClassList("point");
        panel4.AddToClassList("point");
        panel5.AddToClassList("point");
        panel6.AddToClassList("point");
        panel7.AddToClassList("point");
        panel8.AddToClassList("point");
        panel9.AddToClassList("point");
        panel10.AddToClassList("point");

        hierarchy.Add(panel1);
        hierarchy.Add(panel2);
        hierarchy.Add(panel3);
        hierarchy.Add(panel4);
        hierarchy.Add(panel5);
        hierarchy.Add(panel6);
        hierarchy.Add(panel7);
        hierarchy.Add(panel8);
        hierarchy.Add(panel9);
        hierarchy.Add(panel10);

    }

}
