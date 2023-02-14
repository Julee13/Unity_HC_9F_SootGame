using UnityEngine;

namespace Julee
{
    /// <summary>
    /// �ǲ߫D�R�A API
    /// ���C���������骫��A�ҥH�ϥγo���� API �e�|���ݭn���@�Ӫ���
    /// </summary>
    public class LearnAPI : MonoBehaviour
    {
        public Transform Bear;  // ��������M�w�N�O API ������

        public Camera mainCamera;

        public Transform spiderGreen;

        private void Awake()
        {
            // �B�J 1. ���T�w���V�W�����骫��s�b
            // �B�J 2. �w�q�Ӫ������ (�M�w�������)
            // �B�J 3. �s���D�R�A�ݩʩΤ�k

            // �D�R�A�ݩ� Properties
            // 1. ���o�D�R�A�ݩ�
            // �y�k:
            // ���W��.�D�R�A�ݩ�
            print($"<color=#ff6633>Bear ���y��: { Bear.position }</color>");

            print($"<color=#ff6633>��v�����`��: { mainCamera.depth }</color>");

            // 2. ���o�D�R�A�ݩ�
            // �y�k:
            // ���W��.�D�R�A�ݩ� ���w ��
            spiderGreen.localScale = Vector3.one * 10;
        }
    }
}