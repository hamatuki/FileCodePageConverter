namespace FileCodePageConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 変換実行ボタンをクリックしたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExec_Click(object sender, EventArgs e)
        {
            // 変換前フォルダパス取得

            // 変換後フォルダパス取得

            // 変換ループ
            //     変換前フォルダの内容を取得
            //         フォルダの取得
            //         ファイルの取得

        }

        /// <summary>
        /// 対象フォルダ内ファイルのコードページ変更
        /// </summary>
        /// <param name="targetFolder"></param>
        private void FileCodePageConvertInTargetFolder(string targetFolder)
        {
        }

        /// <summary>
        /// ファイルのコードページを確認する
        /// </summary>
        /// <param name="filePath"></param>
        private void CheckCodePageOfFile(string filePath)
        {
        }
    }
}