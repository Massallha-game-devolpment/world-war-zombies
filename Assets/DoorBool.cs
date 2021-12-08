using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorBool : MonoBehaviour
{
   
    public get get;

    void Start()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && get.GetKey()==true)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    
}
