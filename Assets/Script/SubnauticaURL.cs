using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubnauticaURL : MonoBehaviour
{
    public void onClick()
    {
        //Debug.Log("Push!");
        Application.OpenURL("https://store.steampowered.com/app/264710/_/");//""の中には開きたいWebページのURLを入力します
    }
}