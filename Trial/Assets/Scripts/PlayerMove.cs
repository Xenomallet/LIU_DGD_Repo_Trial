using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    //variables
public Rigidbody2D rb;
public float movespeed;
private Vector2 movedirection;
public InputActionReference move;
public GameManager GM;
private SpriteRenderer currentColor;
public int score;
public TMPro.TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //graft ridigbody to object
        rb = GetComponent<Rigidbody2D>();
        currentColor = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //add direction of movement with input manager
        movedirection = move.action.ReadValue<Vector2>();

        //when score >= 10 go to end scene
        if(score >= 10)
        {
            SceneManager.LoadScene("End");
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(x:movedirection.x * movespeed, y:movedirection.y * movespeed);
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GameObject().tag != "Hazard")
        {
            //destroy object upon collision with player
            Destroy(collision.gameObject);

            //respawn the destroyed object
            GM.Respawn();

            //increase score by 1 upon collision
            score++;
            
            
        }
        else
        {
            GM.RespawnPlayer();
            score = 0;
        }
        
        scoreText.text = "Score: " + score;
        
        //change player color to a random color upon collision
        currentColor.color = Random.ColorHSV();

        
    }
}
