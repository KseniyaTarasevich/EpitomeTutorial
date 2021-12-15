using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }

        //PlayerPrefs.DeleteAll();

        instance = this;
        SceneManager.sceneLoaded += LoadState;


        DontDestroyOnLoad(gameObject);
    }

    // resources
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    // references
    public PlayerController player;

    // logic
    public int pesos;
    public int experience;

    /*
    1 - INT preferedSkin (the skin your player like the most in the character selection)
    2 - INT pesos (amount of pesos)
    3 - INT experience
    4 - INT weaponLevel           
    */

    // save progress
    public void SaveState()
    {


        /* string s = ""; //  s- saving

         s += "0" + "|";
         s += pesos.ToString() + "|";
         s += experience + "|";
         s += "0";

         PlayerPrefs.SetString("SaveState", s);*/

        Debug.Log("save state");
    }

    // load up your progress
    public void LoadState(Scene s, LoadSceneMode mode)
    {
        /* if (!PlayerPrefs.HasKey("SaveState"))
             return;

         string[] data = PlayerPrefs.GetString("SaveState").Split('|');

         // change player skin
         pesos = int.Parse(data[1]);
         experience = int.Parse(data[2]);
         // change the weapon level*/


        Debug.Log("load state");
    }
}
