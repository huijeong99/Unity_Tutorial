using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
    [SerializeField]//해당 클래스를 가져와야 프라이빗 상태에서 인스펙터 창에 뜸
    private GameObject go_camera;//만일 프라이빗만 해두면 인스펙터 창에 뜨지 않음

    Vector3 rotation;

    private void Start()//모든 클래스를 실행하기 전 초기화시키는 함수
    {
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //this.transform.position(this의 위치를 가리킴)
            //Time.deltaTime(약 1/60프레임:: 60deltaTime=1초)
            //위치 변화
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1)*Time.deltaTime;//위치를 직접 지정
            //this.transform.Translate(new Vector3(0, 0, 1)*(Time.deltaTime));//이동값을 직접 지정

            //회전 변화
            //this.transform.eulerAngles : x,y,z 축의 최전축을 의미
            //1번 방법)
            //this.transform.eulerAngles = transform.eulerAngles + new Vector3(90, 0, 0) * Time.deltaTime;
            //해당 방법은 내부적으로 돌아가는 회전값과 겉으로 보이는 회전량에 차이가 생긴다
            //회전값이 90이 넘는 순간 쓰레기값이 담기는데 해당 쓰레기값을 새로 받아와서 갱신하기 때문에 발생하는 오류
            //2번 방법
            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.eulerAngles = rotation;//앵글값을 로테이션에 고정
            //Debug.Log(transform.eulerAngles);
            //인스펙터 창에 표시되는 회전값과 디버깅 창에 표시되는 회전값이 다름
            //유니티 내에서의 회전은 기본적으로 쿼터니온 값으로 진행되나 개발자가 직접 쿼터니온 값을 입력하기 어렵기 때문에 오일러 값으로
            //입력한다. 유니티 엔진 내에서 입력된 오일러 값을 자동으로 쿼터니온 값으로 바꿔주는데, 바뀐 쿼터니온 값을 다시 오일러값으로 변환해
            //디버그 창에 표시하게 되면 인스펙터 창에 표시되는 오일러 회전값과 디버그 창에 표시되는 회전값이 상이해진다.
            //3번 방법(메소드를 이용
            //this.transform.Rotate(new Vector3(90, 0, 0)*(Time.deltaTime));
            //가장 간단한 방법. 따라서 유니티 내에서는 오일러 앵글을 직접 수정하는 것을 권장하지 않는다.
            //필요한 경우에 따라 오일러 수정법을 사용할 수도 있다.
            //4번
            //this.transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0)*Time.deltaTime);
            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.rotation = Quaternion.Euler(rotation);
            //유니티 내의 각도가 90도가 되면 다른 축이 고장나는 오류가 존재한다. 이 오류는 오일러가 아닌 쿼터니온을 사용하게 되면 해결되는 문제다
            //만약 한 회전축이 90도가 넘지 않는 경우에는 오일러나 로테이트값을 이용해도 무관하다.

            //크기조절
            //this.transform.localScale = this.transform.localScale + new Vector3(2, 2, 2);

            //정규화 벡터(방향을 알려줄 뿐 /모든 정규화 벡터는 반대를 지원하지 않음)
            //transform.forward
            //transform.up
            //transform.right

            //this.transform.LookAt(go_camera.transform.position);//지정된 곳을 z축 기준으로 바라봄          

            transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
            //지정된 중심축을 중심으로 회전함
        }
    }
}
