using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;

    void Start()
    {
        ActivatePanel(panel1);
    }

    public void NextPanel()
    {
        if (panel1.active == true)
        {
            ActivatePanel(panel2);
        }
        else if (panel2.active)
        {
            ActivatePanel(panel3);
        }
    }
    public void PreviousPanel()
    {
        if (panel3.active == true)
        {
            ActivatePanel(panel2);
        }
        else if (panel2.active)
        {
            ActivatePanel(panel1);
        }
    }

    public void ActivatePanel(GameObject panelToActivate)
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);

        panelToActivate.gameObject.SetActive(true);
    }
}
