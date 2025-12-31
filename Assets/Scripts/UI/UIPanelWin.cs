using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// THIS IS CS FOR WINNING PANEL
public class UIPanelWin : MonoBehaviour, IMenu
{
    [SerializeField] private Button btnClose;
    private UIMainManager m_mngr;

    private void Awake() => btnClose.onClick.AddListener(OnClickClose);
    private void OnDestroy() { if (btnClose) btnClose.onClick.RemoveAllListeners(); }

    private void OnClickClose() => m_mngr.ShowMainMenu();

    public void Setup(UIMainManager mngr) => m_mngr = mngr;
    public void Show() => this.gameObject.SetActive(true);
    public void Hide() => this.gameObject.SetActive(false);
}
