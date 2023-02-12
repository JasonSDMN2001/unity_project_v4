using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputRemoting;

public class CollisionTest : MonoBehaviour
{
    [SerializeField] string message;
    [SerializeField] protected Rigidbody doorRb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (doorRb.isKinematic == true)
        {
            if (other.CompareTag("Player"))
            {
                UIManager.Instance.ShowMessage(message);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        UIManager.Instance.ShowMessage("");
    }
}
