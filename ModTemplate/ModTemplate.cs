using OWML.Common;
using OWML.ModHelper;
using UnityEngine.InputSystem;

namespace ModTemplate
{
    public class ModTemplate : ModBehaviour
    {
        private void Awake()
        {
            // You won't be able to access OWML's mod helper in Awake.
            // So you probably don't want to do anything here.
            // Use Start() instead.
        }

        private void Update()
        {
            if (Keyboard.current.uKey.wasPressedThisFrame)
            {
                FindObjectOfType<DeathManager>()?.KillPlayer(deathType: DeathType.Meditation);
            }
        }
    }
}
