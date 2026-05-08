using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    private float _horizontalInput;
	private float _verticalInput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
		_verticalInput = Input.GetAxis("Vertical");
        //We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * _verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * _horizontalInput);
    }
}
