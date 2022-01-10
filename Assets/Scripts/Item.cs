using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour,IPointerDownHandler,IDragHandler,IEndDragHandler
{
    GameObject groupNode = null;
    List<Image> bodyImages = null;
    
    // Start is called before the first frame update
    void Start()
    {
        groupNode = transform.parent.gameObject;
        Transform bagTransform = groupNode.transform.parent;
        Transform bodyItemsTransform = bagTransform.Find("BodyItems");
        bodyImages = new List<Image>();
        foreach(Transform child in bodyItemsTransform)
        {
            bodyImages.Add(child.GetComponent<Image>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(transform.parent.gameObject == groupNode)
        {
            transform.parent = transform.parent.parent;
        }
        transform.GetComponent<RectTransform>().position = eventData.position;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.parent = groupNode.transform;
    }
}
