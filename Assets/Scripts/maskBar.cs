using UnityEngine;
using UnityEngine.UI;
public class maskBar : MonoBehaviour
{

    public Slider slider;
    public Slider healthSlider;
    public static maskBar instance;

    public void MaxNumber(int mask)
    {
        slider.maxValue = mask;
        slider.value = mask;
    }

    public void SetNumber(int mask)
    {
        slider.value = mask;
    }
    void Update()
    {
        slider.value = FirstPersonController.instance.maskTime;
        healthSlider.value = FirstPersonController.instance.health;
    }

}
