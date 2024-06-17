using UnityEngine;

[ExecuteInEditMode]
public sealed class ParallaxLayer : MonoBehaviour
{
    [SerializeField] private float parallaxFactor;
    public float ParallaxFactor { get => parallaxFactor; private set => parallaxFactor = value; }

    public void Move(float delta)
    {
        Vector3 newPos = transform.localPosition;
        newPos.x -= delta * ParallaxFactor;

        transform.localPosition = newPos;
    }

    public void SetParallaxFactor(float parallaxFactor)
    {
        ParallaxFactor = parallaxFactor;
    }
}