using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyTest : MonoBehaviour
{

    private Rigidbody myRigid;
    private Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            // myRigid.velocity : 현재 움직이고 있는 속도를 나타냄 myRigid.velocity
            //myRigid.velocity = Vector3.forward;
            //myRigid.angularVelocity = -Vector3.right;//회전 속도를 나타냄
            //myRigid.maxAngularVelocity = 100; //회전의 최대 속도를 변경함(기본은 7이라고 함)

            //메소드//
            //****관성과 질량을 무시함(강제적으로 움직임)****//
            //myRigid.MovePosition(transform.forward);//일정 방향으로 이동시킴
            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            //myRigid.MoveRotation(Quaternion.Euler(rotation));//일정 방향으로 회전시킴
            //****관성과 질량의 영향을 받음****//
            //myRigid.AddForce(Vector3.forward);//일정 방향으로 힘을 가함(이동시킴)
            //myRigid.AddTorque(Vector3.up);//일정 방향으로 회전 힘을 가함
            myRigid.AddExplosionForce(10,this.transform.right,10);//폭발 연출에 유용함
            //myRigid.AddExplosionForce(폭발하는 힘, 폭발 방향, 폭발 범위)
            
        }
    }
}
