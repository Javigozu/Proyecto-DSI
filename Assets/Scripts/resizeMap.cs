using UnityEngine.UIElements;

public class ResizeMap : PointerManipulator
{
    private ScrollView scrollView;
    public ResizeMap(ScrollView scrollView)
    {
        this.scrollView = scrollView;
    }

    protected override void RegisterCallbacksOnTarget()
    {
        target.RegisterCallback<WheelEvent>(OnWheel);
    }
    protected override void UnregisterCallbacksFromTarget()
    {
        target.UnregisterCallback<WheelEvent>(OnWheel);
    }
    protected void OnWheel(WheelEvent e)
    {
        float x_factor = scrollView.layout.width / scrollView.layout.height;
        float y_factor = scrollView.layout.height / scrollView.layout.width;
        float diff = e.delta.y * -2.5f;

        target.style.width = target.layout.width + diff * x_factor;
        target.style.height = target.layout.height + diff * y_factor;

        scrollView.horizontalScroller.value = (scrollView.horizontalScroller.lowValue + scrollView.horizontalScroller.highValue) / 2.0f;
        scrollView.verticalScroller.value = (scrollView.verticalScroller.lowValue + scrollView.verticalScroller.highValue) / 2.0f;

        e.StopPropagation();
    }
}
