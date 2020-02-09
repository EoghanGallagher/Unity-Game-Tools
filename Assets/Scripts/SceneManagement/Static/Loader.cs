using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public static class Loader 
{

  private class LoadingMonoBehaviour : MonoBehaviour {}
  
  public enum Scene
  {
      GameScene,
      LoadingScene,
      MainMenu
  }

  private static Action onLoaderCallback;

  private static AsyncOperation loadingAsyncOperation;
  
  public static void Load( Scene scene )
  {
      //Set the loader callback action to load the targe scene
      onLoaderCallback = () => {
         
         GameObject loadingGameObject = new GameObject( "Loading Game Object" );
         loadingGameObject.AddComponent<LoadingMonoBehaviour>().StartCoroutine( LoadSceneAsync( scene ) );
         
      };
      
      //Load the loading scene
      SceneManager.LoadScene( Scene.LoadingScene.ToString() );
  }

  private static IEnumerator LoadSceneAsync( Scene scene )
  {
      yield return null;
      AsyncOperation asyncOperation = SceneManager.LoadSceneAsync( scene.ToString() );

      while( !asyncOperation.isDone )
      {
        yield return null;
      }

  }

  public static float GetLoadingProgress()
  {
    if( loadingAsyncOperation != null )
      	return loadingAsyncOperation.progress;
    else
        return 1f;
  }

  public static void LoaderCallback()
  {
    //Triggered after the first update which lets the screen refresh
    //Execute the loader callback action which will load the target scene
    if( onLoaderCallback != null )
    {
      onLoaderCallback();
      onLoaderCallback = null;
    }
  }
}
