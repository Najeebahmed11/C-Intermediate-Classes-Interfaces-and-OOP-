using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Asynch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //button click is handler

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            
            // DownloadHtmlAsynch("https://github.com/Najeebahmed11/C-Intermediate-Classes-Interfaces-and-OOP-/commits/master");
            var getHtml=  GetHtmlAsync("https://mail.google.com/mail/u/0/#inbox");
            MessageBox.Show("waiting for task to complete");
            var html = await getHtml;
            MessageBox.Show(html.Substring(0, 10));

        }
      
        //task is an object that encapsulate the state of asynch opperation
        //if your method return a string than use generic version
        public async Task<string> GetHtmlAsync(string url)
        {
            var webclient = new WebClient();
            return await webclient.DownloadStringTaskAsync(url);
        }
        public async Task DownloadHtmlAsynch (string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);
            using (var stramwriter = new StreamWriter("D:\\internship\\Day9\\result.html"))
            {
                await stramwriter.WriteAsync(html);

            }
        }
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            using (var stramwriter = new StreamWriter("D:\\internship\\result.html"))
            {
                stramwriter.Write(html);

            }
        }
    }
}
