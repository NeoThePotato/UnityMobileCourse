using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputManager : MonoBehaviour
{
	[SerializeField] private Rigidbody2D _playerEntity;
	private Vector2 _inputMovementVector = Vector2.zero;

	private void FixedUpdate()
	{
		_playerEntity.velocity = _inputMovementVector;
	}

	private void OnMove(InputValue value)
	{
		var vec = value.Get<Vector2>();
		_inputMovementVector.x = vec.x;
		_inputMovementVector.y = vec.y;
		_playerEntity.velocity = _inputMovementVector;
	}
}
