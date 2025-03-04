using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioSource footstepSource; // L'AudioSource des bruits de pas
    public AudioClip[] footstepClips; // Tableau des sons de pas
    public CharacterController controller; // Composant CharacterController
    public float stepInterval = 0.5f; // Délai entre chaque pas

    private Coroutine footstepCoroutine;

    void Update()
    {
        // Vérifie si le personnage est au sol et se déplace
        bool isMoving = controller.isGrounded && controller.velocity.magnitude > 0.1f;

        if (isMoving && footstepCoroutine == null)
        {
            // Lancer la coroutine si elle n'est pas déjà en cours
            footstepCoroutine = StartCoroutine(PlayFootsteps());
        }
        else if (!isMoving && footstepCoroutine != null)
        {
            // Arrêter la coroutine et le son si le joueur s'arrête
            StopCoroutine(footstepCoroutine);
            footstepCoroutine = null;
            footstepSource.Stop();
        }
    }

    IEnumerator PlayFootsteps()
    {
        while (true)
        {
            if (footstepClips.Length > 0)
            {
                footstepSource.clip = footstepClips[Random.Range(0, footstepClips.Length)];
                footstepSource.Play();
            }
            yield return new WaitForSeconds(stepInterval);
        }
    }
}
