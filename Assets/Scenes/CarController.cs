using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 100f;
    public bool canDrive = false;

    public LightingManager lightingManager;
    public Transform lighthouse;

    private bool switchedToNoon = false;
    private bool switchedToEvening = false;

    void Update()
    {
        if (!canDrive) return;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, -turnSpeed * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);
        }
        
        float distance = Vector3.Distance(transform.position, lighthouse.position);

        if (!switchedToNoon && distance < 80f)
        {
            lightingManager.SetNoon();
            switchedToNoon = true;
        }

        if (!switchedToEvening && distance < 30f)
        {
            lightingManager.SetEvening();
            switchedToEvening = true;
        }
    }
}