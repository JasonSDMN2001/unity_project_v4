using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ships : MonoBehaviour
{
    [SerializeField] 
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        /*print("hello world");
        transform.position = transform.position + new Vector3(speed, speed, speed);*/
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        

    }
    
}
