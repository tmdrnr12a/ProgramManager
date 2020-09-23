using ProgramManager.Manager;
using ProgramManager.Processor;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProgramManager.Forms
{
    public partial class ProgramForm : Form
    {
        #region " Variables "

        private enum E_COLUMNS { PR_ID, PR_NAME, PR_ICON, PR_PATH, PR_FILE }

        private int activeRowIndex = -1;

        #endregion " Variables End "

        #region " Create & Load & Shown "

        public ProgramForm()
        {
            InitializeComponent();

            this.Shown += ProgramForm_Shown;

            uiBtn_Add.Click += UiBtn_Add_Click;
            uiBtn_Delete.Click += UiBtn_Delete_Click;
            uiBtn_Save.Click += UiBtn_Save_Click;
        }

        private void ProgramForm_Shown(object sender, EventArgs e)
        {
            InitSheet(uiSpread_Program);
            SetData();
            SetSheetDesign(uiSheet_Program);
        }

        #endregion " Create & Load Shown End "

        #region "  Methods "

        private void InitSheet(FarPoint.Win.Spread.FpSpread spread)
        {
            FarPoint.Win.Spread.SheetView sheet = spread.Sheets[0];

            spread.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            spread.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;

            //spread.CellClick -= fpSpread2_CellClick;
            //spread.CellClick += fpSpread2_CellClick;

            sheet.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            sheet.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;

            sheet.Rows.Count = 0;
            sheet.Columns.Count = Enum.GetNames(typeof(E_COLUMNS)).Length;

            sheet.ColumnHeader.Rows[0].Height = 35;
            sheet.ColumnHeader.Cells[0, (int)E_COLUMNS.PR_ID].Value = "ID";
            sheet.Columns[(int)E_COLUMNS.PR_ID].Visible = false;
            sheet.ColumnHeader.Cells[0, (int)E_COLUMNS.PR_NAME].Value = "Name";
            sheet.Columns[(int)E_COLUMNS.PR_NAME].Width = 200;
            sheet.ColumnHeader.Cells[0, (int)E_COLUMNS.PR_ICON].Value = "Icon";
            sheet.Columns[(int)E_COLUMNS.PR_ICON].Width = 50;
            sheet.ColumnHeader.Cells[0, (int)E_COLUMNS.PR_PATH].Value = "FTP Path";
            sheet.Columns[(int)E_COLUMNS.PR_PATH].Width = 250;
            sheet.ColumnHeader.Cells[0, (int)E_COLUMNS.PR_FILE].Value = "File";
            sheet.Columns[(int)E_COLUMNS.PR_FILE].Width = 150;
        }

        private void SetData()
        {
            DataSet ds = DatabaseProcessor.Instance.GetAllProgramData();

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                int rowCnt = ds.Tables[0].Rows.Count;
                int colCnt = ds.Tables[0].Columns.Count;

                FarPoint.Win.Spread.SheetView sheet = uiSheet_Program;
                sheet.Rows.Count = rowCnt;

                FarPoint.Win.Spread.CellType.ImageCellType imagecell = new FarPoint.Win.Spread.CellType.ImageCellType()
                {
                    Style = FarPoint.Win.RenderStyle.StretchAndScale,
                    TransparencyColor = Color.Transparent
                };

                for (int row = 0; row < rowCnt; row++)
                {
                    for (int col = 0; col < colCnt; col++)
                    {
                        if (col == (int)E_COLUMNS.PR_ICON)
                        {
                            sheet.Cells[row, col].CellType = imagecell;

                            try
                            {
                                sheet.Cells[row, col].Value = Image.FromStream(new MemoryStream((byte[])ds.Tables[0].Rows[row][col]));
                            }
                            catch { }
                        }
                        else
                        {
                            sheet.Cells[row, col].Value = ds.Tables[0].Rows[row][col].ToString();
                        }
                    }
                }
            }
        }

        private void SetSheetDesign(FarPoint.Win.Spread.SheetView sheet)
        {
            for (int row = 0; row < uiSheet_Program.Rows.Count; row++)
            {
                sheet.Rows[row].Height = 35;
                sheet.Rows[row].BackColor = row % 2 == 1 ? Color.FromArgb(255, 235, 235, 235) : sheet.DefaultStyle.BackColor;
            }
        }

        #endregion "  Methods End "

        #region " Events "

        private void UiBtn_Add_Click(object sender, EventArgs e)
        {
            FarPoint.Win.Spread.FpSpread spread = uiSpread_Program;
            FarPoint.Win.Spread.SheetView sheet = spread.Sheets[0];

            sheet.Rows.Add(sheet.Rows.Count, 1);
            int lastRowNom = sheet.Rows.Count - 1;
            sheet.Rows[lastRowNom].Tag = true;

            SetSheetDesign(sheet);

            this.activeRowIndex = lastRowNom;
            sheet.SetActiveCell(lastRowNom, 0);
            spread.ShowRow(0, sheet.Rows.Count - 1, FarPoint.Win.Spread.VerticalPosition.Nearest);
            spread.ShowColumn(0, 1, FarPoint.Win.Spread.HorizontalPosition.Nearest);
        }

        private void UiBtn_Delete_Click(object sender, EventArgs e)
        {
            FarPoint.Win.Spread.SheetView sheet = uiSheet_Program;

            if (sheet.Rows.Count > 0)
            {
                int activeRow = sheet.ActiveRowIndex;

                // ADD 버튼으로 새로 추가하려한 User
                if (sheet.Cells[activeRow, 0].Value == null)
                {
                    sheet.Rows.Remove(activeRow, 1);
                    SetRowsColor(sheet);

                    if (sheet.Cells[sheet.ActiveRowIndex, 5].Value != null)
                        LoadCheckData(Sheet_User.Cells[Sheet_User.ActiveRowIndex, 5].Value.ToString());
                    return;
                }

                // DB에 있는 User 인데 id값을 입력하지 않은 경우
                if (Sheet_User.Cells[activeRow, 1].Value == null)
                {
                    MessageBox.Show("User ID does not exist.", "Failed to delete.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Sheet_User.Cells[activeRow, 1].Value.ToString() == "tmsuser")
                {
                    MessageBox.Show("Don't delete Administrator user", "Failed to delete.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Cursor = Cursors.WaitCursor;

                string id = Sheet_User.Cells[activeRow, 1].Value.ToString();

                string deleteStr = String.Format("[User ID : {0}] 确定要删除吗？", id);

                if (MessageBox.Show(deleteStr, "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string query = @"
DELETE FROM WIN_RCP_#DEPT.#DEPT_USER_INFO_TBL
WHERE USER_ID = '#USERID'
";
                        query = query.Replace("#DEPT", Function.DEPT.ToString());
                        query = query.Replace("#USERID", id);

                        int result = MysqlManager.Instance.ExecuteNonQuery(query.ToString());

                        // 삭제 성공
                        if (result == 1)
                        {
                            // 삭제된 유저 정보를 UI 에서 제거
                            Sheet_User.Rows.Remove(activeRow, 1);

                            // 현재 선택한 Row 가 맨 마지막 유저 정보이면
                            if (activeRow == Sheet_User.Rows.Count)
                                activeRow--;

                            LoadCheckData(Sheet_User.Cells[activeRow, 5].Value.ToString());
                            SetRowsColor(Sheet_User);
                        }
                    }
                    catch (Exception ex)
                    {
                        string trace = MethodBase.GetCurrentMethod().ReflectedType.Name + "." + MethodBase.GetCurrentMethod().Name + "()";
                        MessageBox.Show(ex.Message.ToString(), trace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("User Data to Delete dose not exist.", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UiBtn_Save_Click(object sender, EventArgs e)
        {

        }

        #endregion "Events End "
    }
}
