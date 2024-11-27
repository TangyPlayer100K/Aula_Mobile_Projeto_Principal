using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMechanic : MonoBehaviour
{
    public GameObject[] items;
    public GameObject[] hudItems;

    public bool tool1 = false;
    public bool tool2 = false;
    public bool tool3 = false;

    void Start()
    {
        foreach (GameObject item in items)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in hudItems)
        {
            item.SetActive(false);
        }

        items[0].SetActive(true);
    }

    public void PickTool1()
    {
        SetItemsState(0, 0, false, true);
        tool1 = true;
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
        if (index2 >= 0 && index2 < hudItems.Length)
        {
            hudItems[index2].SetActive(activate2); // Ativa/desativa o item no array2
        }
    }
    #endregion
}
