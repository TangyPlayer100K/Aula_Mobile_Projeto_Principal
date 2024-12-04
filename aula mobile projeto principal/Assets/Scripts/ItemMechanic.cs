using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemMechanic : MonoBehaviour
{
    public GameObject[] items;
    public GameObject[] Items2;

    public bool tool1 = false;
    public bool tool2 = false;
    public bool tool3 = false;

    public bool keypiece1 = false;
    public bool keypiece2 = false;
    public bool keypiece3 = false;

    void Start()
    {
        foreach (GameObject item in items)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in Items2)
        {
            item.SetActive(false);
        }

        items[0].SetActive(true);
        items[1].SetActive(true);
        items[2].SetActive(true);
        items[3].SetActive(true);
        items[4].SetActive(true);
    }
    #region lockers
    public void Unlock1()
    {
        if (tool2 == true)
        {
            SetItemsState(1, 0, false, true);
            SetItemsState(7, 0, true, true);
        }
    }
    public void Unlock2()
    {
        if (tool3 == true)
        {
            SetItemsState(2, 0, false, true);
            SetItemsState(5, 0, true, true);
            SetItemsState(8, 0, true, true);
        }
    }
    public void Unlock3()
    {
        if (tool1 == true)
        {
            SetItemsState(3, 0, false, true);
            SetItemsState(6, 0, true, true);
            SetItemsState(9, 0, true, true);
        }
    }
    #endregion

    #region keys
    public void PickKey1()
    {
        SetItemsState(7, 3, false, true);
        keypiece1 = true;
    }
    public void PickKey2()
    {
        SetItemsState(8, 4, false, true);
        keypiece2 = true;
    }
    public void PickKey3()
    {
        SetItemsState(9, 5, false, true);
        keypiece3 = true;
    }

    #endregion

    #region tools
    public void PickTool1()
    {
        SetItemsState(0, 0, false, true);
        tool1 = true;
    }
    public void PickTool2()
    {
        SetItemsState(5, 1, false, true);
        tool2 = true;
    }
    public void PickTool3()
    {
        SetItemsState(6, 2, false, true);
        tool3 = true;
    }
    #endregion

    public void EndDoor()
    {
        if (keypiece1 == true && keypiece2 == true && keypiece3 == true) 
        {
            SceneManager.LoadScene(2);
        }
    }


    #region SetItemsFunction
    public void SetItemsState(int index1, int index2, bool activate1, bool activate2)
    {
        // Verifica se o índice do array1 está dentro dos limites
        if (index1 >= 0 && index1 < items.Length)
        {
            items[index1].SetActive(activate1); // Ativa/desativa o item no array1
        }

        // Verifica se o índice do array2 está dentro dos limites
        if (index2 >= 0 && index2 < Items2.Length)
        {
            Items2[index2].SetActive(activate2); // Ativa/desativa o item no array2
        }
    }
    #endregion
}
