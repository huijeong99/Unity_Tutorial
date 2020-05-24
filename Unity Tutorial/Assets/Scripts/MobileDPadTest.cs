using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MobileDPadTest : MonoBehaviour, IPointerDownHandler,IPointerUpHandler,IDragHandler
{
    [SerializeField] private RectTransform rect_BackGround;
    [SerializeField] private RectTransform rect_JoyStick;

    private float radius;
    [SerializeField] private GameObject go_Player;
    [SerializeField] private float moveSpeed;


    private bool isTouch = false;
    private Vector3 movePosition;

    // Start is called before the first frame update
    void Start()
    {
        radius = rect_BackGround.rect.width*0.5f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (isTouch)
            go_Player.transform.position += movePosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Vector2 value = eventData.position - (Vector2)rect_BackGround.position;

        //반지름만큼 가두기
        value = Vector2.ClampMagnitude(value, radius);
        
        rect_JoyStick.localPosition = value;


        float distance = Vector2.Distance(rect_BackGround.position,rect_JoyStick.position)/radius;//프로그램상 대략 60/1
        value = value.normalized; //속도값을 빼고 방향값만 남는다
        movePosition = new Vector3(value.x * moveSpeed *distance* Time.deltaTime, 0f, value.y * moveSpeed *distance* Time.deltaTime);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        isTouch = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        isTouch = false;
        rect_JoyStick.localPosition = Vector3.zero;
        movePosition = Vector3.zero;
    }
}
