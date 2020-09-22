using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramManager.Forms
{
    public partial class UserManagementForm : Form
    {
        #region " Variables "

        #endregion " Variables End "

        #region " Create & Load & Shown "

        public UserManagementForm()
        {
            InitializeComponent();

            this.Shown += UserManagementForm_Shown;

            uiBtn_Add.Click += UiBtn_Add_Click;
            uiBtn_Delete.Click += UiBtn_Delete_Click;

            uiBtn_Save.Click += UiBtn_Save_Click;
        }

        private void UserManagementForm_Shown(object sender, EventArgs e)
        {
            InitForm();

            InitSheet();
            SetData();
            DesignSheet();
        }

        #endregion " Create & Load Shown End "

        #region "  Methods "

        private void InitForm()
        {
            // 이미지 버튼 초기화
        }

        private void InitSheet()
        {
            InitSheetUser();
            InitSheetProgram();
        }

        private void InitSheetUser()
        {

        }

        private void InitSheetProgram()
        {

        }

        private void SetData()
        {
            SetDataUser();
            SetDataProgram();
        }

        private void SetDataUser()
        {
            DataSet ds = GetDataUser();
        }

        private DataSet GetDataUser()
        {
            DataSet ds = null;

            return ds;
        }

        private void SetDataProgram()
        {
            DataSet ds = GetDataProgram();
        }

        private DataSet GetDataProgram()
        {
            DataSet ds = null;

            return ds;
        }

        private void DesignSheet()
        {
            // Row 색상
        }

        private bool CheckData()
        {
            bool result = true;


            return result;
        }

        private bool SaveData()
        {
            bool result = true;

            return result;
        }
        
        #endregion "  Methods End "

        #region " Events "

        private void UiBtn_Add_Click(object sender, EventArgs e)
        {

        }

        private void UiBtn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void UiBtn_Save_Click(object sender, EventArgs e)
        {
            if (CheckData() == false)
                return;

            SaveData();
        }

        #endregion "Events End "


    }
}
