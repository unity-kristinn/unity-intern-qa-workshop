using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpPower = 5;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            var rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Strawberry"))
        {
            print("Strawberry!");
            Destroy(other.gameObject);
            ScoreCounter.TotalScore++;
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            print("Game over!");
            Destroy(gameObject);
        }
    }
}
