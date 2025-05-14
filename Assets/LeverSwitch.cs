using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject flippedLeverPrefab;
    public float interactionDistance = 3f;
    public LeverManager leverManager;
    public AudioClip leverSound;
    private AudioSource audioSource;

    private Transform player;

    private void Start()
    {
        player = Camera.main.transform; // Assuming camera is child of player
    
        audioSource = GetComponent<AudioSource>();
    }


private void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < interactionDistance)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                FlipLever();
            }
        }
    }

    public void FlipLever()
    {
        if (leverManager != null)
        {
            leverManager.LeverFlipped();
        }

        Instantiate(flippedLeverPrefab, transform.position, transform.rotation);
        Destroy(gameObject);

        // Play the sound at the lever's position
        AudioSource.PlayClipAtPoint(leverSound, transform.position);

        // Replace this lever with the flipped version
        Instantiate(flippedLeverPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}