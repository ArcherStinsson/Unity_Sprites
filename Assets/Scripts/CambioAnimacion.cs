using UnityEngine;

public class CambioAnimacion : MonoBehaviour
{
    private float distanciarecorrida;
    public float cambio;
    private Animator animator;
    private Vector3 firstPosition;
    private float distanceThisFrame;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      animator = GetComponent<Animator>();
      firstPosition=transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        distanceThisFrame = Vector3.Distance(firstPosition, transform.position);
        distanciarecorrida = distanceThisFrame;

        if (distanciarecorrida >= cambio)
        {
            animator.SetBool("cambiaranimacion", true);
        }

        else
        {
            animator.SetBool("cambiaranimacion", false);
        }

    }
}

