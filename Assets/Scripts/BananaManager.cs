using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BananaManager : MonoBehaviour
{
    private int totalBananas;
    private int bananasRecolectadas = 0;

    private void Start()
    {
      
        totalBananas = transform.childCount;
    }

    public void RecolectarBanana()
    {
        bananasRecolectadas++;

        
        if (bananasRecolectadas >= totalBananas)
        {
          
            SceneManager.LoadScene("Level 2"); 
        }
    }
}
