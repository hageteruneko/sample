using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Badf : MonoBehaviour
{
    private int bcnt = 0;


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Notes"))
        {
            if (Input.GetKey(KeyCode.F) || Input.GetKey(KeyCode.J))
            {
                Destroy(other.gameObject);
                Debug.Log("Bad");
                bcnt++;
            }
        }
        if (other.gameObject.CompareTag("Notess"))
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.K))
            {
                Destroy(other.gameObject);
                Debug.Log("Perfect");
                bcnt++;
            }
        }
    }
}
