using UnityEngine;

public class Removeable : MonoBehaviour
{
    private void OnMouseDown()
    {
        UnityEngine.Object.Destroy(this.gameObject);
    }
}
