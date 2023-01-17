using UnityEngine;
using UnityEngine.Video;

namespace Julee
{
    /// <summary>
    /// �ǲ� Unity �`�����������
    /// </summary>
    public class LearnDataType : MonoBehaviour
    {
        // �x�s��Ʀp���ּv���Ϥ��ץ�
        [Header("�x�s�������")]
        public AudioClip sound;    // �i�s�񭵼� mp3 ogg avi
        public VideoClip video;    // �s��v�� mp4 ogg wmv
        public Sprite picture;     // �i�s��Ϥ� png jpg psd
        public Material material;  // �i�s�����y
        public KeyCode key;        // �i�s��ƹ� ��L �n��

        // enum �C�| (�U�Կ��)
        public KeyCode keyJump = KeyCode.Space;
        public KeyCode keyFire = KeyCode.Mouse0;   // �ƹ�����

        [Header("�C��P�y��")]
        public Color color;                                         // �w�]�C�⬰�¦�z��
        public Color red = Color.red;                               // ���ج�
        public Color yellow = Color.yellow;                         // ���ض�
        public Color colorCustom1 = new Color(1, 0.5f, 0);          // �ۭq�C�� (R,G,B)
        public Color colorCustom2 = new Color(0, 0.5f, 1, 0.5f);    // �ۭq�C�� (R,G,B,A)

        // �G�� �T�� �|���V�q
        public Vector2 v2;
        public Vector3 v3;
        public Vector4 v4;

        public Vector3 v3Zero = Vector3.zero;  // 000
        public Vector3 v3One = Vector3.one;    // 111
        public Vector3 v3R = Vector3.right;    // 100 - X �k��
        public Vector3 v3U = Vector3.up;       // 010 - Y �W��
        public Vector3 v3F = Vector3.forward;  // 001 - Z �e��

        public Vector3 v3Custom = new Vector3(0.5f, 99.9f, -3.35f);
    }
}
