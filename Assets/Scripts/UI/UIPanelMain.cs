using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelMain : MonoBehaviour, IMenu
{
    [SerializeField] private Button btnTimer;

    [SerializeField] private Button btnMoves;

  //  [SerializeField] private Button btnSort;

    private UIMainManager m_mngr;

    private void Awake()
    {   
        
        btnMoves.onClick.AddListener(OnClickMoves);
        if (btnTimer != null)
        {
            btnTimer.onClick.RemoveAllListeners(); // Xóa sạch
            btnTimer.onClick.AddListener(OnClickTimer); // Kết nối lại
        }
        //Added Triple Sort Mode Buttton
        //    btnSort.onClick.AddListener(OnClickSortMode);
    }

    private void OnDestroy()
    {
        if (btnMoves) btnMoves.onClick.RemoveAllListeners();
        if (btnTimer) btnTimer.onClick.RemoveAllListeners();
        //Added Triple Sort Mode Buttton
    //    if (btnSort) btnSort.onClick.RemoveAllListeners();
    }

    public void Setup(UIMainManager mngr)
    {
        m_mngr = mngr;
    }

    private void OnClickTimer()
    {
        Debug.Log("BtnTimer");
        if(m_mngr!=null)
        m_mngr.LoadLevelTimer();
    }

    private void OnClickMoves()
    {
        m_mngr.LoadLevelMoves();
    }

    private void OnClickSortMode()
    {
        m_mngr.LoadLevelSort();
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
