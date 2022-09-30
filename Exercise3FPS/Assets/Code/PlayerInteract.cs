using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private float raycastDist = 1;
    public LayerMask button;
    public Transform camTrans;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (Physics.Raycast(camTrans.position, camTrans.forward, out hit, racastDist, button)) {
                GameObject switch = hit.collider.gameObject;
                if (switch.CompareTag("Button")) {
                    Destroy(switch);
                }
            }
        }
    }
}
