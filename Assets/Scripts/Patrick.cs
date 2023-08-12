using UnityEngine;

public class Patrick : MonoBehaviour
{
	[SerializeField] private Rigidbody2D _rb;
	[SerializeField] private InputManager _inputManager;
	[SerializeField] private float _movementSpeed = 1f;

	void FixedUpdate()
    {
        _rb.velocity = new (_inputManager.movementVector.x * _movementSpeed, _rb.velocity.y);
    }

	private void OnValidate()
	{
		_rb = GetComponent<Rigidbody2D>();
	}
}
