using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    //GameObject�^�̕ϐ�sphere��錾���܂��B
    GameObject sphere;


    void Start()
    {
        //Sphere�ƌ������O��GameObject�ɃA�N�Z�X���ĕϐ�sphere�Ő錾���܂��B
        sphere = GameObject.Find("Sphere");

    }

    //�}�E�X�J�[�\����Sphere�ɏ�������̏���
    private void OnMouseOver()
    {
        //Sphere�̐F��ԐF�ɕω������܂��B
        sphere.GetComponent<Renderer>().material.color = Color.red;
    }

    //�}�E�X�J�[�\����Sphere�̏ォ�痣�ꂽ���̏���
    private void OnMouseExit()
    {
        //Sphere�̐F�����̐F�ɖ߂�܂��B
        sphere.GetComponent<Renderer>().material.color = Color.blue;
    }
}
