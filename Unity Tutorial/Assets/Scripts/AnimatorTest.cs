using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTest : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rigid;
    private BoxCollider col;

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private LayerMask layerMask;

    private bool isMove;
    private bool isJump;
    private bool isFall;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        TryWalk();
        TryJump();
        
    }

    private void TryWalk ()
    {
        float _dirX = Input.GetAxisRaw("Horizontal");
        float _dirZ = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(_dirX, 0, _dirZ);

        //anim.SetBool("Right", false);
        //anim.SetBool("Left", false);
        //anim.SetBool("Up", false);
        //anim.SetBool("Down", false);
        isMove = false;

        if (direction != Vector3.zero)
        {
            //this.transform.Translate(direction.normalized * moveSpeed * Time.deltaTime); //가로 세로의 총합을 1로 만들기 위함
            //
            //if (direction.x > 0)
            //    anim.SetBool("Right", true);
            //else if (direction.x < 0)
            //{
            //    anim.SetBool("Left", true);
            //}
            //else if (direction.z > 0)
            //{
            //    anim.SetBool("Up", true);
            //}
            //else if (direction.z < 0)
            //{
            //    anim.SetBool("Down", true);
            //}

            isMove = true;
            this.transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);

        }

        anim.SetBool("Move", isMove);
        anim.SetFloat("DirX", direction.x);
        anim.SetFloat("DirZ", direction.z);
    }

    private void TryJump()
    {
        if (isJump)
        {
            //fall상태로 바꾸기
            if (rigid.velocity.y >= -0.1f && !isFall)
            {
                isFall = true;
                anim.SetTrigger("Fall");
            }

            //착지
            RaycastHit hitInfo;

            if(Physics.Raycast(transform.position,-transform.up,out hitInfo, col.bounds.extents.y + 0.1f, layerMask))
            {
                anim.SetTrigger("Land");
                isJump = false;
                isFall = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            isJump = true;
            //rigid.velocity = new Vector3(0, jumpForce, 0);
            rigid.AddForce(Vector3.up * jumpForce);
            anim.SetTrigger("Jump");
        }
    }
}
