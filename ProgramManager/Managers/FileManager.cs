using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ProgramManager.Managers
{
    class FileManager
    {
        public static String FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private static String _fileName = String.Empty;

        /// <summary>
        /// 파일 내 특정 key 에 해당하는 value 를 읽어서 반환하는 메서드
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="def"></param>
        /// <param name="retval"></param>
        /// <param name="size"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(String section, String key, String def, StringBuilder retval, int size, String filePath);

        /// <summary>
        /// 파일 내 특정 key 에 해당하는 value 에 값을 저장하는 메서드
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(String section, String key, String val, String filePath);

        /// <summary>
        /// GetPrivateProfileString() 메서드를 호출하는 메서드
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="defValue"></param>
        /// <returns></returns>
        public static String GetValueString(String section, String key, String defValue)
        {
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString(section, key, defValue, temp, 255, _fileName);
            return temp.ToString();
        }

        /// <summary>
        /// WritePrivateProfileString() 메서드를 호출하는 메서드
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static long SetValue(String Section, String Key, String Value)
        {
            long result = WritePrivateProfileString(Section, Key, Value, _fileName);
            return result;
        }

        /// <summary>
        /// 사용하지 않는 메서드
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="defValue"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static String GetValueString(String section, String key, String defValue, String filePath)
        {
            StringBuilder temp = new StringBuilder(255);
            GetPrivateProfileString(section, key, defValue, temp, 255, filePath);
            return temp.ToString();
        }

        /// <summary>
        /// 사용하지 않는 메서드
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static long SetValue(String Section, String Key, String Value, String filePath)
        {
            long result = WritePrivateProfileString(Section, Key, Value, filePath);
            return result;
        }

    }
}
