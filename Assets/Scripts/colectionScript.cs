using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colectionScript : MonoBehaviour
{

    private BananaManager manager;

    private void Start()
    {
       
        manager = GetComponentInParent<BananaManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            // Opcional: sonido, animación, contador, etc.
            Debug.Log("¡Recolectado!");
            Destroy(gameObject); 

      
        }
    }
}
