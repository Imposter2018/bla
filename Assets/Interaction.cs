using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private Camera cam; // Камера
    [SerializeField] private GameObject interactionText; // Текст взаимодействия
    private void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward); // Луч от начала камеры направленный вперед
        if(Physics.Raycast(ray, out RaycastHit hit) && hit.transform.tag == "Object") // Проверка на соприкосновение луча с коллайдером и совпадение тега
        {
            interactionText.SetActive(true); // Активация текста
            if (Input.GetKeyDown(KeyCode.F)) // При нажатии клавиши F воспроизводится звук
            {
                MANAGER.Instance.PlaySound(0);
            }
            if (Input.GetKeyDown(KeyCode.F)) // При нажатии клавиши Е идет действие
            {

            }
        }
        else interactionText.SetActive(false); // Диактивация текста
        Debug.DrawRay(cam.transform.position, cam.transform.forward * 100f, Color.red); // Для отображения луча в инспекторе
    }
}
