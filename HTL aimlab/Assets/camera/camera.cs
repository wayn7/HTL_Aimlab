using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float mouseyspeed = 10;
    [Range(0f, 90f)]

    public float yRotationLimit = 88f;
    public Vector2 cameraRotation = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMouseInput = Input.GetAxis("Mouse Y");

        cameraRotation.y += verticalMouseInput * mouseyspeed * Time.deltaTime * 60;
        cameraRotation.y = Mathf.Clamp(cameraRotation.y, -yRotationLimit, yRotationLimit);
        var yQuat = Quaternion.AngleAxis(cameraRotation.y, Vector3.left);
        transform.localRotation = yQuat;
    }
}
