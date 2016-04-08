using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private ProductController productCtrl = null;
    private bool isProduct = true;

    private void Start()
    {
        productCtrl = new ProductController();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (isProduct)
            {
                productCtrl.DebugAll();
            }
        }
    }
}