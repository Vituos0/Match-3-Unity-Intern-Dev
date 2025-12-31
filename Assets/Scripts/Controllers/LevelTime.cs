using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTime : LevelCondition
{
    private float m_time;

    private GameManager m_mngr;

    
    public override void Setup(float value, Text txt, GameManager mngr)
    {
        base.Setup(value, txt, mngr);

        m_mngr = mngr;

        m_time = value;

        m_conditionCompleted = false;

        UpdateText();
    }

    
    private void Update()
    {
        // Debug.Log($"Check: {gameObject.name} state is {m_mngr.State}");
        if (m_conditionCompleted) return;

        if (m_mngr==null || m_mngr.State != GameManager.eStateGame.GAME_STARTED) return;

        m_time -= Time.deltaTime;

        UpdateText();

        if (m_time <= -1f)
        {
            OnConditionComplete(false);// if out of time -> you lose
        }
    }

    protected override void UpdateText()
    {
        if (m_txt == null) return;

        
        m_txt.text = string.Format("TIME:\n{0:00}", Mathf.CeilToInt(m_time));
    }
}
