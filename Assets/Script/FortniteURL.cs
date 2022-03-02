using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FortniteURL : MonoBehaviour
{
    public void onClick()
    {
        //Debug.Log("Push!");
        Application.OpenURL("https://www.epicgames.com/fortnite/ja/home");//""の中には開きたいWebページのURLを入力します
    }
}