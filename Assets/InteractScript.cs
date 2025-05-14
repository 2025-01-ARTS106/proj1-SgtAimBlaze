using UnityEngine;

public class LeverInteractor : MonoBehaviour
{
    public float interactDistance = 3f;
    public LayerMask interactableLayer;
    public Camera playerCamera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactDistance, interactableLayer))
            {
                Lever lever = hit.collider.GetComponent<Lever>();
                if (lever != null)
                {
                    lever.FlipLever();
                }
            }
        }
    }
}
