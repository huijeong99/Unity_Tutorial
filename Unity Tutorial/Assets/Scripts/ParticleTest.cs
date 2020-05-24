using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTest : MonoBehaviour
{
    ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ps.Play();//재생
        //ps.Stop();//멈추기
        //ps.Pause();//정지
        ps.Emit(100);//버스트처럼 뿜어져 나오게
    }
}
