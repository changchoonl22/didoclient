using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATermNCode.Ctnl
{
    [DefaultEvent("SearchButtonClicked")]
    public partial class CodeSearchControl : UserControl
    {
        public CodeSearchControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 사용자가 입력한 나이를 구함. 나이를 입력하지 않으면 null 이 지정됨
            String txtSearch = null;

            // 사용자가 입력한 생년월일의 범위를 구함. 역시 입력하지 않으면 null 이 지정됨.
            txtSearch = txb1.Text;

            // 바로 검색을 하는 것이 아니라 검색 버튼이 눌러졌다는 통지를 함. 실제 검색은 통지 받은 클래스가 수행.
            OnSearchButtonClicked(txtSearch);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //dddd
        }


        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;


        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        protected virtual void OnSearchButtonClicked
            (string txtSearch)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, new SearchButtonClickedEventArgs(txtSearch));
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public string txtSearch { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs
                (string txt)
            {
                txtSearch = txt;
            }
        #endregion
        }
    }
}
