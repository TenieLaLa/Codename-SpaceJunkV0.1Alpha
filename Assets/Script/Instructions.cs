using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour
{
   public void ToControls(){
SceneManager.LoadScene(5);
}
	public void ToMenu(){
SceneManager.LoadScene(0);
}

}
