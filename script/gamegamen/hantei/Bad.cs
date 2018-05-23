using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bad : MonoBehaviour
{
    private int bcnt = 0;

    public int Bcnt
    {
        get { return this.bcnt; }
        private set { this.bcnt = value; }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Notes"))
        {
            Destroy(other.gameObject);
            Debug.Log("Bad");
            bcnt++;
        }
        if (other.gameObject.CompareTag("Notess"))
        {
            Destroy(other.gameObject);
            Debug.Log("Bad");
            bcnt++;
        }
    }
}