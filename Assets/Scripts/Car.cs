using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float steerSpeed = 0.5f;
    [SerializeField] private float moveSpeed = 0.25f;
    [SerializeField] private float slowSpeed = 0.15f;
    [SerializeField] private float boostSpeed = 0.30f;

    private float currSpeed;

    // Start is called before the first frame update
    void Start()
    {
        currSpeed = moveSpeed;
    }

   void FixedUpdate()
    {
        float SteerAmount = Input.GetAxis("Horizontal");
        float DriveAmount = Input.GetAxis("Vertical");
        transform.Rotate(0, 0, -SteerAmount * steerSpeed);
        transform.Translate(0, DriveAmount * currSpeed, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Booster")
        {
            currSpeed = boostSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currSpeed = moveSpeed;
    }
}
