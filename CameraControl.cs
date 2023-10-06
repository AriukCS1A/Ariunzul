using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float sensX;
    public float sensY;
    public Transform bairshil;
    float xErgelt;
    float yErgelt;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
        yErgelt += mouseX;
        xErgelt -= mouseY;

        xErgelt = Mathf.Clamp(xErgelt, -90f, 90f);
        transform.rotation = Quaternion.Euler(xErgelt, yErgelt, 0);
        bairshil.rotation = Quaternion.Euler(0, yErgelt, 0);
    }
}
