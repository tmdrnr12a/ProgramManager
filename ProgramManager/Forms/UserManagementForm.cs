using ProgramManager.Models;
using ProgramManager.Processor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramManager.Forms
{
    public partial class UserManagementForm : Form
    {
        #region " Variables "

        private enum E_USER { USER_SEQ, USER_ID, USER_PWD, USER_NAME, USER_TYPE, USER_PROGRAM }

        private enum E_AUTHORITY { Administrator, Member }

        private enum E_PROGRAM { PR_ID, PR_ICON, PR_NAME, CHECK }

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

            InitSheetUser(uiSpread_User);
            InitSheetProgram(uiSpread_Program);

            SetDataUser(uiSheet_User);
            SetDataProgram(uiSheet_Program);

            SetCheckedProgram(0);

            DesignSheet(uiSheet_User);
            DesignSheet(uiSheet_Program);
        }

        #endregion " Create & Load Shown End "

        #region "  Methods "

        private void InitForm()
        {
            uiBtn_Add.IMAGE_DEFAULT = Properties.Resources.AddDefault;
            uiBtn_Add.IMAGE_FOCUS = Properties.Resources.AddDefault;
            uiBtn_Add.IMAGE_CLICK = Properties.Resources.AddDefault;

            uiBtn_Delete.IMAGE_DEFAULT = Properties.Resources.DeleteDefault;
            uiBtn_Delete.IMAGE_FOCUS = Properties.Resources.DeleteDefault;
            uiBtn_Delete.IMAGE_CLICK = Properties.Resources.DeleteDefault;

            uiBtn_Save.IMAGE_DEFAULT = Properties.Resources.SaveDefault;
            uiBtn_Save.IMAGE_FOCUS = Properties.Resources.SaveDefault;
            uiBtn_Save.IMAGE_CLICK = Properties.Resources.SaveDefault;
        }

        private void InitSheetUser(FarPoint.Win.Spread.FpSpread spreadUser)
        {
            FarPoint.Win.Spread.FpSpread spread = spreadUser;
            spread.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            spread.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            spread.CellClick += SpreadUser_CellClick;

            FarPoint.Win.Spread.SheetView sheet = spread.Sheets[0];

            sheet.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            sheet.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;

            sheet.Rows.Count = 0;
            sheet.Columns.Count = Enum.GetNames(typeof(E_USER)).Length;

            sheet.ColumnHeader.Rows[0].Height = 35;
            sheet.ColumnHeader.Cells[0, (int)E_USER.USER_SEQ].Value = "SEQ";
            sheet.ColumnHeader.Cells[0, (int)E_USER.USER_ID].Value = "ID";
            sheet.ColumnHeader.Cells[0, (int)E_USER.USER_PWD].Value = "PASSOWRD";
            sheet.ColumnHeader.Cells[0, (int)E_USER.USER_NAME].Value = "NAME";
            sheet.ColumnHeader.Cells[0, (int)E_USER.USER_TYPE].Value = "TYPE";
            sheet.ColumnHeader.Cells[0, (int)E_USER.USER_PROGRAM].Value = "PROGRAM";

            sheet.Columns[(int)E_USER.USER_SEQ].Visible = false;
            sheet.Columns[(int)E_USER.USER_PROGRAM].Visible = false;

            sheet.Columns.Default.Width = 120;

            FarPoint.Win.Spread.CellType.ComboBoxCellType cbCellType = new FarPoint.Win.Spread.CellType.ComboBoxCellType()
            {
                Items = new string[] { E_AUTHORITY.Administrator.ToString(), E_AUTHORITY.Member.ToString() },
                Editable = false
            };
            sheet.Columns[(int)E_USER.USER_TYPE].CellType = cbCellType;
        }

        private void InitSheetProgram(FarPoint.Win.Spread.FpSpread spreadProgram)
        {
            FarPoint.Win.Spread.FpSpread spread = spreadProgram;
            spread.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            spread.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            spread.CellClick += SpreadProgram_CellClick;

            FarPoint.Win.Spread.SheetView sheet = spread.Sheets[0];

            sheet.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            sheet.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;

            sheet.Rows.Count = 0;
            sheet.Columns.Count = Enum.GetNames(typeof(E_PROGRAM)).Length;

            sheet.ColumnHeader.Rows[0].Height = 35;
            sheet.ColumnHeader.Cells[0, (int)E_PROGRAM.PR_ID].Value = "ID";
            sheet.ColumnHeader.Cells[0, (int)E_PROGRAM.PR_ICON].Value = "ICON";
            sheet.ColumnHeader.Cells[0, (int)E_PROGRAM.PR_NAME].Value = "NAME";
            sheet.ColumnHeader.Cells[0, (int)E_PROGRAM.CHECK].Value = "CHECK";

            sheet.Columns[(int)E_PROGRAM.PR_ICON].Width = 80;
            sheet.Columns[(int)E_PROGRAM.CHECK].Width = 80;

            sheet.Columns[(int)E_PROGRAM.PR_ID].Visible = false;

            sheet.Columns.Default.Width = 160;

            FarPoint.Win.Spread.CellType.ImageCellType imagecell = new FarPoint.Win.Spread.CellType.ImageCellType()
            {
                Style = FarPoint.Win.RenderStyle.StretchAndScale,
                TransparencyColor = Color.Transparent
            };
            sheet.Columns[(int)E_PROGRAM.PR_ICON].CellType = imagecell;

            FarPoint.Win.Spread.CellType.CheckBoxCellType cbCellType = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            sheet.ColumnHeader.Cells[0, (int)E_PROGRAM.CHECK].CellType = cbCellType;
            sheet.Columns[(int)E_PROGRAM.CHECK].CellType = cbCellType;
        }

        private void SetDataUser(FarPoint.Win.Spread.SheetView sheet)
        {
            DataSet ds = DatabaseProcessor.Instance.GetUserData();

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                sheet.Rows.Count = ds.Tables[0].Rows.Count;

                for (int row = 0; row < ds.Tables[0].Rows.Count; row++)
                {
                    for (int col = 0; col < ds.Tables[0].Columns.Count; col++)
                    {
                        sheet.Cells[row, col].Value = ds.Tables[0].Rows[row][col].ToString();
                    }
                }
            }
        }

        private void SetDataProgram(FarPoint.Win.Spread.SheetView sheet)
        {
            DataSet ds = DatabaseProcessor.Instance.GetProgramData();

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                sheet.Rows.Count = ds.Tables[0].Rows.Count;

                for (int row = 0; row < ds.Tables[0].Rows.Count; row++)
                {
                    for (int col = 0; col < ds.Tables[0].Columns.Count; col++)
                    {
                        if (col == (int)E_PROGRAM.PR_ICON)
                        {
                            byte[] bytes = (byte[])ds.Tables[0].Rows[row][col];
                            sheet.Cells[row, col].Value = Image.FromStream(new MemoryStream(bytes));
                        }
                        else
                        {
                            sheet.Cells[row, col].Value = ds.Tables[0].Rows[row][col].ToString();
                        }
                    }
                }
            }
        }

        private void DesignSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            for (int row = 0; row < sheet.Rows.Count; row++)
            {
                sheet.Rows[row].Height = 35;
                sheet.Rows[row].BackColor = (row % 2 == 1) ? Color.FromArgb(255, 235, 235, 235) : sheet.DefaultStyle.BackColor;
            }
        }

        private bool CheckEmptyData(FarPoint.Win.Spread.SheetView sheet)
        {
            for (int row = 0; row < sheet.Rows.Count; row++)
            {
                for (int col = 0; col < sheet.Columns.Count; col++)
                {
                    if (col == (int)E_USER.USER_SEQ || 
                        col == (int)E_USER.USER_PROGRAM)
                        continue;

                    if (sheet.Cells[row, col].Value == null)
                    {
                        string msg = $"Data of Cell({row},{col}) is empty.";
                        MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return false;
                    }
                }
            }

            return true;
        }

        private void SaveData()
        {
            List<User> userList = GetUserList();
            string currentTime = DatabaseProcessor.Instance.GetCurrentTime();

            if (DatabaseProcessor.Instance.InsertUserData(userList, currentTime) == true)
                DatabaseProcessor.Instance.DeleteAllUser(currentTime);
        }

        private List<User> GetUserList()
        {
            List<User> userList = new List<User>();

            for (int row = 0; row < uiSheet_User.Rows.Count; row++)
            {
                User user = new User()
                {
                    ID = (uiSheet_User.Cells[row, (int)E_USER.USER_ID].Value == null) ? "" : uiSheet_User.Cells[row, (int)E_USER.USER_ID].Value.ToString(),
                    PWD = (uiSheet_User.Cells[row, (int)E_USER.USER_PWD].Value == null) ? "" : uiSheet_User.Cells[row, (int)E_USER.USER_PWD].Value.ToString(),
                    NAME = (uiSheet_User.Cells[row, (int)E_USER.USER_NAME].Value == null) ? "" : uiSheet_User.Cells[row, (int)E_USER.USER_NAME].Value.ToString(),
                    TYPE = (uiSheet_User.Cells[row, (int)E_USER.USER_TYPE].Value == null) ? "" : uiSheet_User.Cells[row, (int)E_USER.USER_TYPE].Value.ToString(),
                    PROGRAM = (uiSheet_User.Cells[row, (int)E_USER.USER_PROGRAM].Value == null) ? "" : uiSheet_User.Cells[row, (int)E_USER.USER_PROGRAM].Value.ToString()
                };

                userList.Add(user);
            }

            return userList;
        }

        private void SetCheckedProgram(int activeRow)
        {
            if (uiSheet_User.Rows.Count == 0)
                return;

            string checkedPrograms = (uiSheet_User.Cells[activeRow, (int)E_USER.USER_PROGRAM].Value == null) ? "" : uiSheet_User.Cells[activeRow, (int)E_USER.USER_PROGRAM].Value.ToString();

            FarPoint.Win.Spread.SheetView sheet = uiSheet_Program;

            // Check Data 초기화
            sheet.ColumnHeader.Cells[0, (int)E_PROGRAM.CHECK].Value = false;
            for (int i = 0; i < sheet.Rows.Count; i++)
                sheet.Cells[i, (int)E_PROGRAM.CHECK].Value = false;

            // USER_PROGRAM 값이 ALL 이면
            if (checkedPrograms == "ALL")
            {
                sheet.ColumnHeader.Cells[0, (int)E_PROGRAM.CHECK].Value = true;

                for (int i = 0; i < sheet.RowCount; i++)
                    sheet.Cells[i, (int)E_PROGRAM.CHECK].Value = true;
            }

            // USER_PROGRAM 값이 ALL 이 아닌 경우
            else
            {
                sheet.ColumnHeader.Cells[0, (int)E_PROGRAM.CHECK].Value = false;

                for (int i = 0; i < sheet.Rows.Count; i++)
                {
                    string[] strArray = checkedPrograms.Split(',');

                    for (int k = 0; k < strArray.Length; k++)
                    {
                        if (sheet.Cells[i, (int)E_PROGRAM.PR_ID].Value.ToString() == strArray[k])
                            sheet.Cells[i, (int)E_PROGRAM.CHECK].Value = true;
                    }
                }
            }
        }

        private void GetCheckedPrograms()
        {
            if (uiSheet_User.Rows.Count == 0)
                return;

            string checkedPrograms = string.Empty;

            for (int row = 0; row < uiSheet_Program.Rows.Count; row++)
            {
                if ((bool)uiSheet_Program.Cells[row, (int)E_PROGRAM.CHECK].Value == true)
                    checkedPrograms += uiSheet_Program.Cells[row, (int)E_PROGRAM.PR_ID].Text + ",";
            }

            // 마지막 콤마(,)는 제거
            if (checkedPrograms.Length > 0)
                checkedPrograms = checkedPrograms.Substring(0, checkedPrograms.Length - 1);

            // 모든 프로그램이 선택되었으면, ALL 로 Return
            if (checkedPrograms.Split(',').Length == uiSheet_Program.Rows.Count)
                checkedPrograms = "ALL";

            uiSheet_User.Cells[uiSheet_User.ActiveRowIndex, (int)E_USER.USER_PROGRAM].Value = checkedPrograms;
        }

        private void SetAllCheckBox()
        {
            bool flag = !(bool)(uiSheet_Program.ColumnHeader.Cells[0, (int)E_PROGRAM.CHECK].Value);

            uiSheet_Program.ColumnHeader.Cells[0, (int)E_PROGRAM.CHECK].Value = flag;

            for (int i = 0; i < uiSheet_Program.RowCount; i++)
                uiSheet_Program.Cells[i, (int)E_PROGRAM.CHECK].Value = flag;
        }

        #endregion "  Methods End "

        #region " Events "

        private void UiBtn_Add_Click(object sender, EventArgs e)
        {
            FarPoint.Win.Spread.FpSpread spread = uiSpread_User;
            FarPoint.Win.Spread.SheetView sheet = spread.Sheets[0];

            sheet.Rows.Add(sheet.Rows.Count, 1);
            int lastRowNom = sheet.Rows.Count - 1;
            sheet.Rows[lastRowNom].Tag = true;

            DesignSheet(sheet);

            sheet.SetActiveCell(lastRowNom, 0);
            spread.ShowRow(0, sheet.Rows.Count - 1, FarPoint.Win.Spread.VerticalPosition.Nearest);
            spread.ShowColumn(0, 1, FarPoint.Win.Spread.HorizontalPosition.Nearest);
        }

        private void UiBtn_Delete_Click(object sender, EventArgs e)
        {
            FarPoint.Win.Spread.SheetView sheet = uiSheet_User;

            if (sheet.Rows.Count == 0)
                return;

            int activeRow = sheet.ActiveRowIndex;

            // ADD 버튼으로 새로 추가하려한 User
            if (sheet.Cells[activeRow, (int)E_USER.USER_SEQ].Value == null)
            {
                sheet.Rows.Remove(activeRow, 1);
                DesignSheet(sheet);

                return;
            }

            if (sheet.Cells[activeRow, (int)E_USER.USER_ID].Value == null ||
                sheet.Cells[activeRow, (int)E_USER.USER_NAME].Value == null)
            {
                string msg = $"[Row:{activeRow}]User id or User name to delete does not exist.";
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seq = sheet.Cells[activeRow, (int)E_USER.USER_SEQ].Value.ToString();
            string id = sheet.Cells[activeRow, (int)E_USER.USER_ID].Value.ToString();
            string name = sheet.Cells[activeRow, (int)E_USER.USER_NAME].Value.ToString();

            string deleteStr = $"Do you want to delete '{id}({name})' ?";

            if (MessageBox.Show(deleteStr, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool result = DatabaseProcessor.Instance.DeleteTargetUser(seq);

                if (result == false)
                    return;

                // 삭제된 유저 정보를 UI 에서 제거
                sheet.Rows.Remove(activeRow, 1);
                    
                DesignSheet(sheet);
            }
        }

        private void UiBtn_Save_Click(object sender, EventArgs e)
        {
            if (CheckEmptyData(uiSheet_User) == false)
                return;

            GetCheckedPrograms();

            SaveData();
        }

        private void SpreadUser_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.RowHeader == true || e.ColumnHeader == true)
                return;

            GetCheckedPrograms();

            SetCheckedProgram(e.Row);
        }

        private void SpreadProgram_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.ColumnHeader == true && e.Column == (int)E_PROGRAM.CHECK)
                SetAllCheckBox();
        }

        #endregion "Events End "
    }
}
