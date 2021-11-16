using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    //Locks control the behaviour of doors.
    //each lock has a door
    [SerializeField] DoorScript door;
    [SerializeField] KeyCode keyToPress = KeyCode.Space;

    //bool to see if it CAN be unlockedl
    bool canUnlock;
    //combination needed to unlock and user input
    [SerializeField] string combination = "4";
    [SerializeField] string input;

    // Start is called before the first frame update
    void Start()
    {
        canUnlock = false;
    }
    void tryUnlock(string number)
    {
        if (number == combination)
        {
            canUnlock = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            //attempt to unlock via space
            Debug.Log("Trying to unlock..");
            tryUnlock(input);
        }
        //if lock can be unlocked, unlock the door.
        if (canUnlock)
        {
            door.unlock();
        }
        //get a simple user input
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            input = "4";
        }
        
    }
}
