using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    private Animation anim;

    private AnimationClip clip;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
           // anim.Play("Cube2");//이전 애니메이션 끊김. 바로 재생
           // anim.PlayQueued("Cube2");//이전 애니메이션 종료 후 재생
           //anim.Blend("Cube2");//이전 애니메이션과 함께 재생됨
            anim.CrossFade("Cube2");//크로스페이드 효과를 주며 이전 애니메이션이 사라지며 애니메이션 재생됨

            // if (anim.IsPlaying("Cube2"))
            // {
            //     anim.Play("Cube2");
            // }

            //anim.Stop();//모든 애니메이션 멈추기
            //anim.wrapMode = WrapMode.Loop;//애니메이션 재생 타입 바꾸기
            //anim.clip = clip;//애니메이션 클립 설정하기
        }
    }
}
