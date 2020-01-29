using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllers : MonoBehaviour
{

    private Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Physics.Raycast(cameraTransform.position, cameraTransform.forward, Mathf.infinity,LayerMask.NameToLayer("Floor"));
        //var hit = Physics.Raycast(cameraTransform.position, cameraTransform.forward, Mathf.Infinity, LayerMask.NameToLayer("Floor"));
       // Destroy(hit);
    }
}
