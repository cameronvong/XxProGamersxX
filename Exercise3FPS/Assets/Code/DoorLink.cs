using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLink : MonoBehaviour
{
    public string doorName = "Door1";
    public void OpenDoor() {
        GameObject doorway = GameObject.Find(doorName);
        Destroy(doorway);
    }
    
}
