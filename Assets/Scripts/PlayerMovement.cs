using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
public float moveSpeed = 5f;
public float turnSpeed = 10f;
void Update()
{
if (Keyboard.current == null) return;
float x = 0f;
float z = 0f;
if (Keyboard.current.aKey.isPressed) x -= 1f;
if (Keyboard.current.dKey.isPressed) x += 1f;
if (Keyboard.current.sKey.isPressed) z -= 1f;
if (Keyboard.current.wKey.isPressed) z += 1f;
Vector3 direction = new Vector3(x, 0f, z).normalized;
if (direction == Vector3.zero) return;
transform.position += direction * moveSpeed * Time.deltaTime;
Quaternion targetRotation = Quaternion.LookRotation(direction);
transform.rotation = Quaternion.Slerp(
transform.rotation,
targetRotation,
turnSpeed * Time.deltaTime
);
}
}
