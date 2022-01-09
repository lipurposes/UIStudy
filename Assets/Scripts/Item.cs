using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour,IPointerDownHandler,IDragHandler
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.GetComponent<RectTransform>().position = eventData.position;
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }
}
