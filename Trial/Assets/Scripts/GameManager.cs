using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //Variables
    public GameObject square;
    public TextMeshProUGUI timeText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = "Time: "+ Time.deltaTime;
    }

    public void Respawn()
    {
        //Spawn the cube at a random location
        Instantiate(square, new Vector2(Random.Range(-7f, 7f), Random.Range(-3f, 3f)), square.transform.rotation);
    }
}
