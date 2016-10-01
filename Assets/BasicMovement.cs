using UnityEngine;
using System.Collections;

public class BasicMovement : MonoBehaviour {

    public float speed = 10.0f;
    public float rotationSpeed = 2.0f;

	void Update () {
        Vector2 mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        gameObject.GetComponent<CharacterController>().Move(transform.TransformDirection(input * speed * Time.deltaTime));
        transform.Rotate(Vector3.up, mouseInput.x * rotationSpeed);
	}
}