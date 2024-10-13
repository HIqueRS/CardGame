using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TesteVSC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Blep");
        Debug.Log("agr sim");

        this.AddComponent<Rigidbody2D>();

        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up*Time.deltaTime);
    }
}
