using UnityEngine;

public class DefinitionCommander : FunctionCommanderBase
{
    private static DefinitionCommander m_Instance;

    public static DefinitionCommander Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = (DefinitionCommander)FindObjectOfType(typeof(DefinitionCommander));
            }
            if (!m_Instance)
            {
                Debug.LogError("DefinitionCommander could not find himself!");
            }
            return m_Instance;
        }
    }

    internal override void Init()
    {
        Debug.Log("DefinitionCommander is initial");
    }

    public GameObject m_PreGO = null;

    public void DebugTest()
    {
        UnityEngine.Debug.Log("WTF");
    }
}