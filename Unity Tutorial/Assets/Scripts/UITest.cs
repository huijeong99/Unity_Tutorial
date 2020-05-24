using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITest : MonoBehaviour
{
    [SerializeField] private Text txt_name;
    //[SerializeField] private UnityEngine.UI.Text txt_name;
    [SerializeField] private Image image_name;

    private bool isCoolTime = false;

    private float currentTime = 1f;
    private float delayTime = 5f;

    private void Update()
    {

        //이미지 클래스 속성
        //image_name.sprite=sprite;//이미지 스프라이트 변경
        //image_name.color=color.red;//색상 변경
        //Color.a = 0f;//이미지 불러오기>이미지 알파값 변경 후 이미지 재출력(투명화)

        if (isCoolTime)
        {
            currentTime -= Time.deltaTime;
            image_name.fillAmount = currentTime / delayTime;
        }

        if (currentTime <= 0)
        {
            isCoolTime = false;
            currentTime = delayTime;
            image_name.fillAmount = currentTime;
        }
    }

    // Start is called before the first frame update
    public void Change()
    {
        txt_name.text = "변경됨";

        isCoolTime = true;
    }
}
