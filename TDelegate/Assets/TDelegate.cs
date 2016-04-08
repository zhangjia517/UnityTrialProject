using UnityEngine;

public class TDelegate : MonoBehaviour
{
    public void RegisterBackBtnDo()
    {
        EventDelegate.Add(SceneManager.Instance.EventDelegetDo, Do);
    }

    public void UnRegisterBackBtnDo()
    {
        EventDelegate.Remove(SceneManager.Instance.EventDelegetDo, Do);
    }

    private void Start()
    {
        RegisterBackBtnDo();
    }

    private void Update()
    {
    }

    private void Do()
    {
        Debug.Log("===============ZJDebug=============== From TDelegate");
        SceneManager.Instance.RegisterBackBtnDo();
        //Invoke("WaitForTest", float.NegativeInfinity);
    }

    private void WaitForTest()
    {
        SceneManager.Instance.RegisterBackBtnDo();
    }
}