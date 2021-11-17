using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTips : MonoBehaviour
{
    //TODO Create Tooltip over the icons
    private void ShowToolTips()
    {
        this.gameObject.SetActive(true);
    }
    private void HideToolTips()
    {
        this.gameObject.SetActive(false);
    }
}
