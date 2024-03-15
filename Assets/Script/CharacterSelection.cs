using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{

    [SerializeField]
    private GameObject[] Characters;

    private int characterIndex;

    public void ChangeCharacter(int index)
    {
        for (int i = 0; i < Characters.Length; i ++)
        {
            Characters[i].SetActive(false);
        }
        this.characterIndex = index;
        Characters[index].SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(3);
        PlayerPrefs.SetInt("CharacterIndex", characterIndex);
    }
}
