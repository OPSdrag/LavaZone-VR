using UnityEngine;
using UnityEngine.UI; // Required for UI elements like Text

public class LavaZone : MonoBehaviour
{
    public int scoreValue = 0; // Score given when dummy hits the zone
    public Text scoreText; // Reference to the UI Text element
    public Transform spawnPos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dummy")) // Check if the object entering the zone is the dummy
        {

            scoreValue += 10; // Increment score
            UpdateScoreText(); // Update the text UI
            Debug.Log("Dummy entered the lava! Score: " + scoreValue);


            other.transform.position = spawnPos.position;
        }
    }

    // Function to update the UI Text element
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + scoreValue.ToString(); // Update the UI with the new score
        }
    }
}
