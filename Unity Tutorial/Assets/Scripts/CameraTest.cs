using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour
{
    [SerializeField]
    private GameObject go_Target;

    [SerializeField]
    private float speed;

    private Camera theCam;

    private Vector3 difValue;

    // Start is called before the first frame update
    private void Start()
    {
        //카메라가 오브젝트를 따라오게 만들기
        difValue = transform.position - go_Target.transform.position;
        difValue = new Vector3(Mathf.Abs(difValue.x), Mathf.Abs(difValue.y), Mathf.Abs(difValue.z));

        //theCam.clearFlags;//이런식으로 배경속성을 변경할 수 있다.
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, go_Target.transform.position + difValue, speed);
    }
}
