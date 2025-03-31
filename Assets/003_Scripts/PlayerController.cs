using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables
    [SerializeField] private Rigidbody2D m_rigidbody;
    [SerializeField] private float m_fJumpForce =1f;
    
    private bool m_bIsGrounded = true;

    #endregion

    private Vector2 m_v2StartPos;
    #region Unity Methods
    private void Start()
    {
        m_v2StartPos = transform.position;
    }
    private void Reset()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //Detect Player input
        if (m_bIsGrounded == true && Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Dead");
            //ResetGame
            GameManager.instance.ResetGame();
            m_v2StartPos= transform.position;

            //Todo reset force of rigidbody
        }

        if (m_bIsGrounded == false && collision.gameObject.CompareTag("Ground")){
            m_bIsGrounded= true;
        }
    }

    #endregion
    private void Jump()
    {
        m_bIsGrounded = false ;
        m_rigidbody.AddForce(Vector2.up * m_fJumpForce, ForceMode2D.Impulse);
    }
}
