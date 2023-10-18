using UnityEngine;
 
public class FreeCamera : MonoBehaviour
{
    [SerializeField] private int _lookSpeedMouse;
    [SerializeField] private int _moveSpeed;
    [SerializeField] private float _sprint;

    private Vector2 _rotation;

    private void Update()
    {
        MouseLook();
        Move();
    }

    private void OnValidate()
    {
        _sprint = _moveSpeed >= _sprint ? _moveSpeed * 1.5f : _sprint;
    }

    private void MouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * _lookSpeedMouse * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _lookSpeedMouse * Time.deltaTime;

        _rotation.y += mouseX;
        _rotation.x -= mouseY;

        _rotation.x = Mathf.Clamp(_rotation.x, -90, 90);

        transform.eulerAngles = new Vector3(_rotation.x, _rotation.y, 0);
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        vertical *= Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) ? _sprint : _moveSpeed;
        transform.Translate(horizontal, 0, vertical);
    }
}
