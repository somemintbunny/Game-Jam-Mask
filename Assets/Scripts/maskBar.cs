using UnityEngine;
using UnityEngine.UI;
public class maskBar : MonoBehaviour
{

    public Slider slider;
    public static maskBar instance;

    public void MaxNumber(float mask)
    {
        slider.maxValue = mask;
        slider.value = mask;
    }

    public void SetNumber(float mask)
    {
        slider.value = mask;
    }

}
