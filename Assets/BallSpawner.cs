using System.Collections;
using UnityEngine;



public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform ballsParentTransform;
    [SerializeField] private float spawningSpeed = 1f;
    [SerializeField] private float spawningForce = 1f;
    private Transform cameraTransform;

    // Start is called before the first frame update
    void Awake()
    {
        cameraTransform = transform;
        
    }


    public void SpawnBall()
    {
        
            
            GameObject ball = Instantiate(prefab,cameraTransform.position,Quaternion.identity,ballsParentTransform);
            ball.GetComponent<Rigidbody>().AddForce(cameraTransform.forward * spawningForce);
        
    }

}