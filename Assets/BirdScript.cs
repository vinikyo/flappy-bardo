using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class BirdScript : MonoBehaviour
{
    
    public Rigidbody2D myRigidbody;
    public float flapStrength;

    public bool birdIsAlive = true;



    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
    
        }

        Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);

        if (viewportPosition.y > 1 || viewportPosition.y < 0)
        {
            die();
        }
    }

    private void die()
    {
        if (!birdIsAlive)
        {
            return;
        }

        birdIsAlive = false;
        logic.playGameOverSound();
        logic.gameOver();
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        die();
    }
}
    

