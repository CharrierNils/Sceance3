using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private float speed = 0.3f;
    [SerializeField] private  BallSpawner ballSpawner;


    private Transform cameraTransform;
    // Start is called before the first frame update
    void Awake()
    {
        cameraTransform = transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
      
            cameraTransform.position += new Vector3(Input.GetAxis("Horizontal")*speed, Input.GetAxis("Mouse ScrollWheel"), Input.GetAxis("Vertical") * speed);
        if (Input.GetButtonDown("Fire1"))
            ballSpawner.SpawnBall();
        cameraTransform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y") * 1.2f, Input.GetAxis("Mouse X") * 1.2f, 0f);
    }
}
