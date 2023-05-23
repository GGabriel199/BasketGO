using UnityEngine;

[System.Serializable, CreateAssetMenu(fileName = "New Skin", menuName = "Create New Skin")]
public class SSkinInfo : ScriptableObject
{
    public enum SkinIDs { standard, blue, White, red, dog, jabu, volley, golf1, football, pingpong, eightball, transparentblue, bowling, watermelon, tennis, wheel, amerfootball, bowlingpines, pinksweede, plastic }

    [SerializeField] private SkinIDs skinID;
    public SkinIDs _skinID { get { return skinID; } }

    [SerializeField] private Sprite skinSprite;
    public Sprite _skinSprite { get { return skinSprite; } }

    [SerializeField] private int skinPrice;
    public int _skinPrice { get { return skinPrice; } }
}