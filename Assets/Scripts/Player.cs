using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    float mouseSense = 1;
    float xAxisClamp = 0;

    public CharacterController controller;
    public float speed = 5f;
    public float gravity = 20;

    Vector3 direction;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            direction = new Vector3(moveHorizontal, 0, moveVertical);
            direction = transform.TransformDirection(direction) * speed;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                direction.y = 20;
            }
        }

        direction.y -= gravity * Time.deltaTime;
        controller.Move(direction * Time.deltaTime);



        Cursor.lockState = CursorLockMode.Locked;

        float rotateX = Input.GetAxis("Mouse X") * mouseSense;
        float rotateY = Input.GetAxis("Mouse Y") * mouseSense;

        xAxisClamp -= rotateX;

        Vector3 rotPlayer = transform.rotation.eulerAngles;

        rotPlayer.x -= rotateY;
        rotPlayer.z = 0;
        rotPlayer.y += rotateX;

        if (xAxisClamp > 90)
        {
            xAxisClamp = 90;
        }
        else if (xAxisClamp < -90)
        {
            xAxisClamp = -90;
        }

        transform.rotation = Quaternion.Euler(rotPlayer);

    }
}
