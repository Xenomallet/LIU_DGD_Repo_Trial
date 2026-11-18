using UnityEngine;
using TMPro;
using System.IO;

public class GameManager : MonoBehaviour
{
    //Variables
    public GameObject square;
    public GameObject player;
    public Vector2 startPos;
    public TextMeshProUGUI timeText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Log player starting position
        startPos = player.transform.position;
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = "" +Time.deltaTime;
    }

    public void Respawn()
    {
        //Spawn the cube at a random location
        Instantiate(square, new Vector2(Random.Range(-7f, 7f), Random.Range(-3f, 3f)), square.transform.rotation);
    }

    public void RespawnPlayer()
    {
        //Spawn player at start upon death
        player.transform.position = startPos;
    }
}
