using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    //public string LinkedName = "Door1";
    private float raycastDist = 4;
    public LayerMask Button;
    public Transform camTrans;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            if (Physics.Raycast(camTrans.position, camTrans.forward, out hit, raycastDist, Button)) {
                var linked = hit.collider.gameObject.GetComponent<DoorLink>();
                if (linked.CompareTag("Switch")) {
                    linked.OpenDoor();
                }
            }
        }
    }
}
