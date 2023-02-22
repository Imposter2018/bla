using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private Camera cam; // ������
    [SerializeField] private GameObject interactionText; // ����� ��������������
    private void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward); // ��� �� ������ ������ ������������ ������
        if(Physics.Raycast(ray, out RaycastHit hit) && hit.transform.tag == "Object") // �������� �� ��������������� ���� � ����������� � ���������� ����
        {
            interactionText.SetActive(true); // ��������� ������
            if (Input.GetKeyDown(KeyCode.F)) // ��� ������� ������� F ��������������� ����
            {
                MANAGER.Instance.PlaySound(0);
            }
            if (Input.GetKeyDown(KeyCode.F)) // ��� ������� ������� � ���� ��������
            {

            }
        }
        else interactionText.SetActive(false); // ����������� ������
        Debug.DrawRay(cam.transform.position, cam.transform.forward * 100f, Color.red); // ��� ����������� ���� � ����������
    }
}
