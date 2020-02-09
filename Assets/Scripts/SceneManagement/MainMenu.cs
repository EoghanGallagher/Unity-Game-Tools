using UnityEngine;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
   
   private void Start()
   {
      Button btn = GameObject.Find( "PlayButton" ).GetComponent<Button>();

      btn.onClick.AddListener( TaskOnClick );
   }

    void TaskOnClick()
    {
        Debug.Log( "clicked Play Button....." );
        Loader.Load( Loader.Scene.GameScene );
    }
}
