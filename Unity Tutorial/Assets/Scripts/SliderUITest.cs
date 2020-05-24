using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUITest : MonoBehaviour
{

    [SerializeField] private Slider slider;
    private bool isClick;

    private float dotTime = 1f;
    private float currentdotTime = 0f;
    // Start is called before the first frame update
    private void Start()
    {
        currentdotTime= dotTime;
    }

    private void Update()
    {
        if (isClick)
        {
            currentdotTime-= Time.deltaTime;

            if (currentdotTime <= 0)
            {
                slider.value -= Time.deltaTime;

                if (currentdotTime <= -1f)
                {
                    currentdotTime = dotTime;
                }
            }
        }
    }

    public void Button()
    {
        isClick = true;
    }
}
