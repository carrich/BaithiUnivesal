using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Universal_baithi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class trang1 : Page
    {
        public string tenfile;
        public string noidung;
        public trang1()
        {
            this.InitializeComponent();
        }

        private async System.Threading.Tasks.Task saveAsync(object sender, RoutedEventArgs e)
        {
            tenfile = Name.Text.ToString();
            noidung = Content.Text.ToString();
            StorageFolder folder = ApplicationData.Current.LocalFolder;
            StorageFile file = await folder.CreateFileAsync(tenfile, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, noidung);
        }
    }
}
