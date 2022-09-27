using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionManager : MonoBehaviour
{
    Transform PlayerTrans;
    [SerializeField]
    static float range = 100f;
    bool active = true;

    private void Start() {
        PlayerTrans = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void LateUpdate() {
        float currDist = Vector3.Distance(PlayerTrans.position, this.transform.position);
        if (currDist >= range && active) {
            for (int i = 0; i < this.transform.childCount; i++)
            {
                var child = this.transform.GetChild(i).gameObject;
                if (child != null)
                    child.SetActive(false);
            }
            active = false;
        } else if (currDist <= range && !active) {
            for (int i = 0; i < this.transform.childCount; i++)
            {
                var child = this.transform.GetChild(i).gameObject;
                if (child != null)
                    child.SetActive(true);
            }
            active = true;
        }
    }
}
