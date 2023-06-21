using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{
    bool CanInteract = false;
    public GameObject ObjectToEnable;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") && CanInteract) 
        {
            Debug.Log("Działa");
            ObjectToEnable.SetActive(true);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
          
         Debug.Log("wchodzisz");
         CanInteract = true;
            
        }
    }
    
    void OnTriggerExit(Collider Player)
    {
        CanInteract = false;

    }
}
