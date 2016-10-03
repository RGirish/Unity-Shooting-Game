using UnityEngine;
using System.Collections;

public class MouseLock : MonoBehaviour {

	void Update () {
    	if (Input.GetButtonDown("Fire1")) {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
	}
}