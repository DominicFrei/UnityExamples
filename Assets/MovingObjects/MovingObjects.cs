using UnityEngine;

public class MovingObjects : MonoBehaviour
{
    private enum MovementState
    {
        None,
        Left,
        Right
    }

    private Vector3 _startingPosition;
    private MovementState _movementState = MovementState.Right;
    private float _maximumMovement = 3.0f;

    private void Start()
    {
        _startingPosition = transform.position;
    }

    private void Update()
    {
        switch (_movementState)
        {
            case MovementState.Right:
                transform.position += Vector3.right * Time.deltaTime;
                if (transform.position.x >= _startingPosition.x + _maximumMovement)
                {
                    _movementState = MovementState.Left;
                }
                break;
            case MovementState.Left:
                transform.position += Vector3.left * Time.deltaTime;
                if (transform.position.x <= _startingPosition.x)
                {
                    _movementState = MovementState.Right;
                }
                break;
        }

    }
}
