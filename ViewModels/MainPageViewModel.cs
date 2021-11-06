using MvvmGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace MVVM_TextBox.ViewModels
{
    [ViewModel]
    public partial class MainPageViewModel
    {
        [Property] string _localPath = "";

        [Command]
        private async void SelectLocalPath()
        {
            var picker = new FolderPicker();
            picker.FileTypeFilter.Add("*");
            var folder = await picker.PickSingleFolderAsync();
            if (folder != null)
            {
                LocalPath = folder.Path;
            }
        }
    }
}
