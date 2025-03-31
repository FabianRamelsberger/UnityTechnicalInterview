using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    [SerializeField] private float m_fMovementSpeed = 1f;
    [SerializeField] private Rigidbody2D m_rigidbody2d;

    // Update is called once per frame
    void Update()
    {
        m_rigidbody2d.AddForce(Vector2.left *  m_fMovementSpeed);

        //transform.Translate(Vector2.left * m_fMovementSpeed *Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            //return to pool
            gameObject.SetActive(false);
            GameManager.instance.ObstacleDestryed();
        }
    }
}
