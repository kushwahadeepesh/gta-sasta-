using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseloock : MonoBehaviour
{
    public float mouseSensivity = 100f;
    public Transform PlayerBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        PlayerBody.Rotate(Vector3.up * mouseX);
    }
}
