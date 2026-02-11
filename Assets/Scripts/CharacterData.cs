using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Scriptable Objects/CharacterData")]
public class CharacterData : ScriptableObject
{
    public string idleAnimationName;

    public string readyAnimationName;

    public string failAnimationName;

    public string failSoundName;
}
