using UnityEngine;

[ExecuteAlways]
[DisallowMultipleComponent]
public sealed class OrderInLayer : MonoBehaviour
{
    [SerializeField] private int orderInLayerValue;
    private bool dirtyFlag = false;

    public int OrderInLayerValue { get => orderInLayerValue; private set => orderInLayerValue = value; }

    public void SetOrderInLayerValue(int value)
    {
        if (orderInLayerValue != value)
        {
            orderInLayerValue = value;
            dirtyFlag = false;
            UpdateOrderInLayer();
        }
    }

#if UNITY_EDITOR
    private void OnValidate()
    {
        if (!Application.isPlaying)
        {
            if (!dirtyFlag)
            {
                UpdateOrderInLayer();
                UnityEditor.EditorUtility.SetDirty(this);
                dirtyFlag = true;
            }
        }
    }

    private void OnTransformChildrenChanged()
    {
        if (!Application.isPlaying)
        {
            dirtyFlag = false;
            OnValidate();
        }
    }
#endif

    private void UpdateOrderInLayer()
    {
        foreach (Transform child in transform)
        {
            if (child.TryGetComponent(out SpriteRenderer spriteRenderer))
            {
                spriteRenderer.sortingOrder = orderInLayerValue;
#if UNITY_EDITOR
                UnityEditor.EditorUtility.SetDirty(spriteRenderer);
#endif
            }
        }
    }
}
