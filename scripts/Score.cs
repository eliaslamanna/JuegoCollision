using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z + 500).ToString("0"); //+ 500 es porque quedo desfazado cuando coloque al jugador
    }
}
