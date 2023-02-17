using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conversation1 : MonoBehaviour ,IInteractable
{
    [SerializeField] protected Rigidbody doorRb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [SerializeField] private GameObject indicator;
    [TextArea(3, 10)]
    public string text;

    public void OnInteract(Interactor interactor)
    {
        if (doorRb.isKinematic == true)
        {
            doorRb.isKinematic = false;
        }
        indicator.SetActive(false); //hide
        //call interactor's public method ReceiveInteract
        //...with override method that gets a string as a parameter
        interactor.ReceiveInteract(text);
        
    }

    //unimplemented Methods
    public void OnEndInteract()
    {
    }

    public void OnAbortInteract()
    {
        indicator.SetActive(false); //hide
    }

    public void OnReadyInteract()
    {
        indicator.SetActive(true); //show
    }
}
