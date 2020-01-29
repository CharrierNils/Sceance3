using System.Collections;
using UnityEngine;



public class ManSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab2;

    private Transform cameraTransform;


    private float x;
    private float y;
    private float z;
    private IEnumerator dur;
    // Start is called before the first frame update
    void Start()
    {
        dur = SpawnMan(3f);
        StartCoroutine(dur);

    }

    void Update()
    {

        x = Random.Range(-15,35);
        y = Random.Range(3.819762f,10);
        z = Random.Range(-15, 35);

    }

    public IEnumerator SpawnMan(float duration)
    {

        while (true) {
            yield return new WaitForSeconds(duration);
            Instantiate(prefab2, new Vector3(x,y,z), Quaternion.identity); }

        
        

    }

}
