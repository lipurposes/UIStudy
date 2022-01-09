using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIPanel : MonoBehaviour
{
    [SerializeField]
    GameObject bag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (bag.activeSelf)
            {
                bag.SetActive(false);
            }
            else
            {
                bag.SetActive(true);
            }
        }
    }
}
