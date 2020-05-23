using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    private BoxCollider col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();    
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.W))
    //    {
    //        Debug.Log("col.bounds" + col.bounds); //바운딩 볼륨을 디버그로 띄운다
    //        Debug.Log("col.bounds.extents"+col.bounds.extents);
    //        Debug.Log("col.bounds.extents.x"+col.bounds.extents.x);
    //        Debug.Log("col.size"+col.size);
    //        Debug.Log("col.center"+col.center);
    //
    //        // col.size = new Vector3(3,3,3);
    //    }
    //
    //    //콜라이더 메소드
    //    if (Input.GetMouseButtonDown(0))//0을 입력하면 좌버튼
    //    {
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hitInfo;
    //        if (col.Raycast(ray, out hitInfo, 1000))
    //        {
    //            this.transform.position = hitInfo.point;//마우스 클릭한 좌표로 개체를 이동
    //        }
    //    }
    //}


    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {
        other.transform.position += new Vector3(0, 0, 0.01f);
        //other<this 외의 다른 개체
    }
}
