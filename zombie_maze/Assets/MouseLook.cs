using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    Vector2 current_mouse_look;
    Vector2 look_angles;
    [SerializeField] float sensitivity;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        LockUnlockCursor();
        if(Cursor.lockState == CursorLockMode.Locked)
        {
            lookAround();
        }
        
    }
    void LockUnlockCursor()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
    void lookAround()
    {
        current_mouse_look = new Vector2(Input.GetAxis("Mouse Y"),Input.GetAxis("Mouse X"));
        look_angles.x += current_mouse_look.x * sensitivity;
        look_angles.y += current_mouse_look.y * sensitivity;
        look_angles.x = Mathf.Clamp(look_angles.x, -90f, 90f); // Limit vertical rotation
        transform.localRotation = Quaternion.Euler(-look_angles.x,0f,0f);
        transform.parent.transform.localRotation = Quaternion.Euler(0f, look_angles.y, 0f);
    }
  
}
