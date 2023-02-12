using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggers : MonoBehaviour
{
    public VcamSwitchForSeconds vcamSwitch;
    string message = "Cobble Town";
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
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Test");
            UIManager.Instance.ShowMessage(message);
            vcamSwitch.TakeControl();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        UIManager.Instance.ShowMessage("");
    }
}
