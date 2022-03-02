using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    //GameObject型の変数sphereを宣言します。
    GameObject sphere;


    void Start()
    {
        //Sphereと言う名前のGameObjectにアクセスして変数sphereで宣言します。
        sphere = GameObject.Find("Sphere");

    }

    //マウスカーソルがSphereに乗った時の処理
    private void OnMouseOver()
    {
        //Sphereの色を赤色に変化させます。
        sphere.GetComponent<Renderer>().material.color = Color.red;
    }

    //マウスカーソルがSphereの上から離れた時の処理
    private void OnMouseExit()
    {
        //Sphereの色が元の青色に戻ります。
        sphere.GetComponent<Renderer>().material.color = Color.blue;
    }
}
