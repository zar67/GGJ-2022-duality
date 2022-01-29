using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] Transform m_playerStartingPosition = default;

    private CharacterController m_playerController;

    public void ResetLevel()
    {
        m_playerController.enabled = false;
        m_playerController.transform.position = m_playerStartingPosition.position;
        m_playerController.transform.rotation = m_playerStartingPosition.rotation;
        m_playerController.enabled = true;
    }

    private void Awake()
    {
        m_playerController = FindObjectOfType<CharacterController>();

        ResetLevel();
    }
}