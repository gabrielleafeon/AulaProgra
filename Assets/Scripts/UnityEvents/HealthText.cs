using TMPro;
using UnityEngine;

namespace AulaUnityEvents
{
    public class HealthText : MonoBehaviour
    {
        [SerializeField] TMP_Text text;
        void Start()
        {
            text = GetComponent<TMP_Text>();
            Player player = FindAnyObjectByType<Player>();
            player.OnPlayerChangeHealth.AddListener(UpdateHealth);
            UpdateHealth(player.hp);
        }

        void Update()
        {
        
        }

        public void UpdateHealth(int hp)
        {
            text.text = $"HP: {hp.ToString("D2")}";
        }
    }
}
