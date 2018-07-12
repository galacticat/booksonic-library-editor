using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.Apis;
using Google.Apis.Customsearch.v1;
using Google.Apis.Services;
using Google.Apis.Customsearch.v1.Data;


namespace Booksonic_Editor
{
    public partial class imgSearch : Form
    {
        public imgSearch()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void imgSearch_Button_Click(object sender, EventArgs e)
        {
            const string apiKey = "AIzaSyAwHxAZ0CY90JnsxMv_qQuic5WuD1LFS08";
            const string cx = "007742719407662848944:mr06-sp0ujk";
            string query = imgSearch_text.Text;

            var customSearchService = new CustomsearchService(new BaseClientService.Initializer { ApiKey = apiKey });
            var listRequest = customSearchService.Cse.List(query);
            listRequest.Cx = cx;

            listRequest.Cx = cx;
            listRequest.Num = 1;
            //listRequest.Fields = "items(image(contextLink,thumbnailLink),link)";
            listRequest.SearchType = CseResource.ListRequest.SearchTypeEnum.Image;
            listRequest.Start = 1;

            var search = listRequest.Execute();

            foreach (var result in search.Items)
            {
                try

                {

                    this.imageList1.Images.Add(Image.FromFile(result.Link));

                }

                catch
                {

                    Console.WriteLine("This is not an image file");

                }

                this.listView1.View = View.LargeIcon;

                this.imageList1.ImageSize = new Size(32, 32);

                this.listView1.LargeImageList = this.imageList1;

                for (int j = 0; j < this.imageList1.Images.Count; j++)

                {

                    ListViewItem item = new ListViewItem();

                    item.ImageIndex = j;

                    this.listView1.Items.Add(item);

                }

                Console.WriteLine(string.Format("Title: {0}", result.Title));
                Console.WriteLine(string.Format("Link: {0}", result.Link));
                this.Refresh();
            }
        }
    }
}
