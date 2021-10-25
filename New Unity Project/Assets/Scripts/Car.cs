//�����ѲŸ�  ���|�Q����
//�\�� 2021.10.21
//�}�o�� �L�� 2021.10.21
using UnityEngine;  //�ޥ�Unity   Engine API

// class ���O(�Ź�)  �W�٭n���ɦW�ۦP�A�j�p�g�]�n�ۦP
public class Car : MonoBehaviour
{
    #region ���y�k�P�|�j������
    // �{����� Field�A�x�s���
    // �y�k:
    // �׹��� ������� ���W�� ���w �w�]�� �����Ÿ�
    // �`�Υ|�j�������(�|�e�{�Ŧ�r��:int     
    // 1. ���   �S���p���I�����t��� int     �w�]�� 0
    // 2. �B�I�� ���p���I�����t���   float   �w�]�� 0
    // 3. �r��   ��r��T string            �w�]�� ��
    // 4. ���L�� �O�P�_ true.false bool     �w�]�� false
    // �׹���
    // �p�H �ȭ������O�s�� unity ����� private (�w�])
    // ���} �Ҧ����O�i�s�� unity �|��� public
    // ����ݩ� Attritube
    // �y�k:
    // [�ݩʦW��(��)]�C������b���e�ΤW�@��
    // 1. ���D header (�r��)
    // 2. ���� Tooltip (�r��)
    // 3. �d�� Range (�B�I�ơA�B�I��)
    [Header("�T���� cc ��")][Range(1000, 5000)]
    public int cc = 2000;
    [Tooltip("�o�O�T�������q�A�d��O 3 ~ 20"), Range(3, 20)]
    public float weigh = 3.5f;
    public string brand = "BMW";
    public bool hasSkyWindow = true;
    #endregion

    #region �C�����`�θ������
    // �C�� Color
    public Color color1;
    public Color colorRed = Color.red;
    public Color colorCustom = new Color(0, 0, 1);
    public Color colorCustomAlpga = new Color(0, 1, 0, 0.3f);
    // �y�� Vector
    // Vector 2 ~ 4
    public Vector2 v2;
    public Vector2 v20ne = Vector2.one;
    public Vector2 v2up = Vector2.up;
    public Vector2 v2Custom = new Vector2(7, 9);
    // ���� KeyCode
    public KeyCode kc;
    public KeyCode kcW = KeyCode.W;
    public KeyCode kcML = KeyCode.Mouse0;

    // �C������ Game0bject �������w�w�]��
    public GameObject carBox;
    public GameObject car0il;
    // ���� Component
    public Transform trabox;
    public SpriteRenderer sprBox;
    public Camera cam;
    #endregion

    #region �s������� Set Get
    // �{���J�f : �ƥ�
    // �}�l�ƥ� : ����C���ɰ���@���A��l�]�w
    private void Start()
    {
        print("���o�A�U�w :D");

        // ���o Get ����� *�w�]�ȥH�ݩʭ��O���D (Inspector)
        // �y�k:
        // ���W��
        print("CC ��:"+ cc);
        print(weigh);

        // �s�� Set �����
        // �y�k:
        // ���W�� ���w �� ;
        brand = "BMW";
        cc = 3500;
        hasSkyWindow = true;
    }
    #endregion
}
