using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropTest : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler,IDropHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("Begin Drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        //Debug.Log("Drag");
        transform.position = eventData.position;
    }

    public void OnDrop(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("Drop");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("End Drag");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
