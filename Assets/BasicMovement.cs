using UnityEngine;
using System.Collections;

public class BasicMovement : MonoBehaviour {

    public float speed = 15.0f;
    public float rotationSpeed = 2.0f;
    public Transform head;
    public float maxHeadRotation = 80.0f;
    public float minHeadRotation = -80.0f;
    private float currentHeadRotation = 0;

	void Update () {
        Vector2 mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        gameObject.GetComponent<CharacterController>().Move(transform.TransformDirection(input * speed * Time.deltaTime));
        transform.Rotate(Vector3.up, mouseInput.x * rotationSpeed);

        // Head rotation like in a first person game
        currentHeadRotation = Mathf.Clamp(currentHeadRotation + mouseInput.y * rotationSpeed, minHeadRotation, maxHeadRotation); 
        head.localRotation = Quaternion.identity;
        head.Rotate(Vector3.left, currentHeadRotation);
	}
}