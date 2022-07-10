using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    /*[SerializeField] private GameObject _line1;
    [SerializeField] private GameObject _line2;
    [SerializeField] private GameObject _line3;*/
    [SerializeField] List<Transform> _lineList = new List<Transform>();
    //[SerializeField] GameObject _line;
    private int lineCount = 0;
    private bool isLineChange = false;
    private Vector2 linePos;
    [SerializeField] GameObject bullet;

    [SerializeField] private UnityEvent OnBackMainCam;

    [SerializeField] float playerX;
    [SerializeField] float playerY;
    [SerializeField] float num = 0;

    private void Start()
    {
        transform.position = _lineList[1].transform.position;
        StartCoroutine(LineAdd());
    }

    IEnumerator LineAdd()
    {
        yield return new WaitForSeconds(30f);

        //CameraManager.Instance.BackMainCam();
        OnBackMainCam.Invoke();
        for (int i = 0; i < 2; i++)
        {
            GameObject line = Instantiate(_lineList[0].gameObject);
            line.transform.position = new Vector3(_lineList[_lineList.Count - 1].position.x + 10, 0);
            _lineList.Add(line.transform);
            yield return new WaitForSeconds(0.1f);
        }
        num = 1;

        /*GameObject line2 = Instantiate(_lineList[0].gameObject);
        line2.transform.position = new Vector3(_lineList[3].position.x + 10, 0);
        _lineList.Add(line2.transform);*/
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            isLineChange = true;
            lineCount--;
        }
     
        if (Input.GetKeyDown(KeyCode.D))
        {
            isLineChange = true;
            lineCount++;
            Debug.Log(lineCount);
        }

        if (isLineChange)
        {
            Debug.Log("플레이어 무브");
            lineCount = Mathf.Clamp(lineCount, 0, _lineList.Count - 1);
            linePos = new Vector2(_lineList[lineCount].position.x, transform.position.y);
            //transform.position = _lineList[lineCount].position;
            transform.position = linePos;
            isLineChange = false;
        }

        

        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(0, v, 0);

        transform.position += dir * 15 * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
        

        //if(transform.position == _lineList[0].transform.position)
        //{
        //    if (Input.GetKeyDown(KeyCode.A))
        //    {
        //        return;
        //    }
        //    if (Input.GetKeyDown(KeyCode.D))
        //    {
        //        transform.position = _lineList[1].transform.position;
        //    }
        //}  
        //else if(transform.position == _lineList[1].transform.position)
        //{
        //    if (Input.GetKeyDown(KeyCode.A))
        //    {
        //        transform.position = _lineList[0].transform.position;
        //    }
        //    if (Input.GetKeyDown(KeyCode.D))
        //    {
        //        transform.position = _lineList[2].transform.position;
        //    }
        //}
        //else
        //{
        //    if (Input.GetKeyDown(KeyCode.A))
        //    {
        //        transform.position = _lineList[1].transform.position;
        //    }
        //    if (Input.GetKeyDown(KeyCode.D))
        //    {
        //        return;
        //    }
        //}
    }

    private void LateUpdate()
    {
        if(num == 0)
        {
            playerY = 9.5f;
        }
        if(num == 1)
        {
            playerY = 19.3f;
        }

        float x = Mathf.Clamp(transform.position.x, transform.position.x, transform.position.x);
        float y = Mathf.Clamp(transform.position.y, -7f, playerY);
        
        Vector2 limit = new Vector2(x, y);
        transform.position = limit;
    }
}
