using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    public string LinkedName = "Door1";
    private float raycastDist = 1;
    public LayerMask Button;
    public Transform camTrans;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            if (Physics.Raycast(camTrans.position, camTrans.forward, out hit, raycastDist, Button)) {
                GameObject lever = hit.collider.gameObject;
                if (lever.CompareTag("Button")) {
                    GameObject linked = GameObject.Find(LinkedName);
                    if (linked) {
                        Destroy(linked.gameObject);
                    }
                }
            }
        }
    }
}
