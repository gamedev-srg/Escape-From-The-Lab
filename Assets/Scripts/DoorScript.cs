using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    //Each door is the same, can only be locked or unlocked, and not responsible for its behaviour
    [SerializeField] bool locked;
 
    [SerializeField] float explosionForce ;
  
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        locked = true;
    }

     public void unlock()
    {
        locked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!locked)
        {
            if(Input.GetKeyDown(KeyCode.L))
            {
                Debug.Log("Here");
                //if unlocked blow back the door
                rb.AddForce(Vector3.right * explosionForce, ForceMode.Impulse);
                locked = true;
            }
        }
    }
}
