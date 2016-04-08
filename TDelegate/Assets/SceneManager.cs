using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private static SceneManager m_Instance;

    public static SceneManager Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = (SceneManager)FindObjectOfType(typeof(SceneManager));
            }
            if (!m_Instance)
            {
                Debug.LogError("SceneManager could not find himself!");
            }
            return m_Instance;
        }
    }

    [HideInInspector]
    public List<EventDelegate> EventDelegetDo = new List<EventDelegate>();

    public void RegisterBackBtnDo()
    {
        EventDelegate.Add(EventDelegetDo, Do);
    }

    public void UnRegisterBackBtnDo()
    {
        EventDelegate.Remove(EventDelegetDo, Do);
    }

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            EventDelegate.Execute(EventDelegetDo);
        }
    }

    private void Do()
    {
        Debug.Log("===============ZJDebug=============== From SceneManager");
    }
}