using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerX : MonoBehaviour
{
    public float speed;
    private Vector3 propel = new Vector3(0f, 0f, 20f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(propel * speed * Time.deltaTime);
    }
}
