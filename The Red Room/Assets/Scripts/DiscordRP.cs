using UnityEngine;
using DiscordPresence;

public class DiscordRP : MonoBehaviour
{

    public string detail;
    public string state;

    public void Button()
    {
        PresenceManager.UpdatePresence(detail: detail, state: state);
    }
}