using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputManager : MonoBehaviour
{
	[System.NonSerialized] public Vector2 movementVector = Vector2.zero;

	private void OnMove(InputValue value)
	{
		var vec = value.Get<Vector2>();
		movementVector = vec;
	}
}
