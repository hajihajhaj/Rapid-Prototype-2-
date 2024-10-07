using UnityEngine;

public class ShowLoserScreen : MonoBehaviour
{
    public GameObject loserScreen;  
    private PlayerHealth playerHealth;  

    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>(); 
        loserScreen.SetActive(false);  
    }

    void Update()
    {
        
        if (playerHealth.isDead)
        {
            ShowScreen();
        }
    }

   
    void ShowScreen()
    {
        loserScreen.SetActive(true);  
        Time.timeScale = 0;  
    }
}
