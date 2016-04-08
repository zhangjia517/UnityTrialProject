public class ProductController
{
    public DefinitionCommander definitionCMD = null;
    private bool isTrue = true;

    public ProductController()
    {
        definitionCMD = DefinitionCommander.Instance;
        CheckFunctionEnabled(definitionCMD, isTrue);
    }

    /// <summary>
    /// 检查产品是否开启
    /// </summary>
    /// <param name="cmd"></param>
    /// <param name="isBoot"></param>
    private void CheckFunctionEnabled(FunctionCommanderBase cmd, bool isBoot)
    {
        if (isBoot)
        {
            cmd.gameObject.SetActive(true);
            cmd.Init();
        }
        else
        {
            cmd.gameObject.SetActive(false);
            cmd.enabled = false;
            cmd = null;
        }
    }

    public void DebugAll()
    {
        if (definitionCMD != null)
            definitionCMD.DebugTest();
    }
}