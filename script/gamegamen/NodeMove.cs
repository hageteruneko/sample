//ノーツ動かすやつ
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NodeMove : MonoBehaviour
{
    public float moveTime;
    public GameObject destination;
    public GameObject lostPosition;
    private new Transform transform;
    private float time = 0f;
    private Vector3 v_start;
    private Vector3 v_destination;


    // Use this for initialization
    void Start()
    {
        transform = GetComponent<Transform>();
        v_destination = lostPosition.transform.position;
        v_start = this.transform.position;
    }

    //Update is called once per frame
    void Update()
    {
        var v = time / moveTime;
        transform.position = Vector3.Lerp(v_start, v_destination, v);
        time += Time.deltaTime;
    }
}

