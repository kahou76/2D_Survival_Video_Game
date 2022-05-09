using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuVersion02 : MonoBehaviour
{
    public static bool IfPause;
    public GameObject PauseMenu;
    public void Pause(){
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        IfPause = true;
    }

    public void UnPause(){
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        IfPause = false;
    }
    

    // Start is called before the first frame update
    void Start()
    {
        IfPause = false;
    }

    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(!IfPause){
                Pause();
            }else{
                UnPause();
            }
        }


        
    }

    

   

    
}
