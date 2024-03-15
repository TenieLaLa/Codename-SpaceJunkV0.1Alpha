 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaneManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] characterPrefabs;
    public GameObject Player;

    private Sprite playerSprite;
    // Start is called before the first frame update
    void Start()
    {
        LoadCharacters();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadCharacters()
    {
        int characterIndex = PlayerPrefs.GetInt("CharacterIndex");
        Instantiate(characterPrefabs[characterIndex]);
        Player.GetComponent<SpriteRenderer>().sprite = playerSprite;
    }

}
