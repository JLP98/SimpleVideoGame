using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform playerTransform;
    public Text scoreText;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.gameHasEnded)
        {
            scoreText.text = "GAME OVER";
        }
        else
        {
            float score = playerTransform.position.z / 5f;
            scoreText.text = score.ToString("0");
        }
    }
}
