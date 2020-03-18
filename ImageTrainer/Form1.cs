using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Text;
using System.Threading;

namespace ImageTrainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //define the image tags for use in the list of all tags to be populated from the service and then added to for checking against for new tags
        class imagetag
        {
            public string id;
            public string name;
            public string description;
            public string type;
            public int imagecount;
        }
        //Global list of image tags
        List<imagetag> imageTags = new List<imagetag>();

        //new image definition as required by the service when creating new images
        class imageDefinition
        {
            public string url;
            public string[] tagIds;
        }
        //list of images for the service which will be serialised for the body of the new image request
        List<imageDefinition> images = new List<imageDefinition>();

        //associated tag for our incoming image list
        class associatedTag
        {
            public string tag;
        }
        //class for our incoming image list to be deserialised
        class newImages
        {
            public string url;
            public List<associatedTag> tags;
        }

        private void GetTags()
        {
            //Clear the list ready to refresh
            imageTags.Clear();
            
            string host = textBoxAPIEndPoint.Text;
            string route = "customvision/v3.0/training/projects/" + textBoxProjectID.Text + "/tags";

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Set the method to GET
                request.Method = HttpMethod.Get;

                // Construct the full URI
                request.RequestUri = new Uri(host + route);

                // Add the authorization header
                request.Headers.Add("Training-Key", textBoxAPIKey.Text);

                // Send request, get response
                var response = client.SendAsync(request).Result;
                var jsonResponse = response.Content.ReadAsStringAsync().Result;

                // Deserializing json data to object  
                JavaScriptSerializer js = new JavaScriptSerializer();
                imageTags = JsonConvert.DeserializeObject<List<imagetag>>(jsonResponse);
                listBox1.Items.Clear();
                foreach (imagetag tag in imageTags)
                {
                    //populate the listbox to see the tags
                    listBox1.Items.Add(tag.name);
                }
            }
        }

        private void CreateTag(string name, string description)
        {
            //Create the tag
            string host = textBoxAPIEndPoint.Text;
            string route = "/customvision/v3.0/training/projects/" + textBoxProjectID.Text + "/tags?name=" + name + "&" + description;

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Set the method to GET
                request.Method = HttpMethod.Post;

                // Construct the full URI
                request.RequestUri = new Uri(host + route);

                // Add the authorization header
                request.Headers.Add("Training-Key", textBoxAPIKey.Text);

                // Send request, get response
                var response = client.SendAsync(request).Result;
                var jsonResponse = response.Content.ReadAsStringAsync().Result;

                // Deserializing json data to object  
                JavaScriptSerializer js = new JavaScriptSerializer();
                imagetag newTag = JsonConvert.DeserializeObject<imagetag>(jsonResponse);
                imageTags.Add(newTag);
                //populate the listbox to see the tags
                listBox1.Items.Add(newTag.name);
            }
        }

        private void RemoveTag (string tagID)
        {
            //Remove a tag
            string host = textBoxAPIEndPoint.Text;
            string route = "/customvision/v3.0/training/projects/" + textBoxProjectID.Text + "/tags/" + tagID;

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Set the method to DELETE
                request.Method = HttpMethod.Delete;

                // Construct the full URI
                request.RequestUri = new Uri(host + route);

                // Add the authorization header
                request.Headers.Add("Training-Key", textBoxAPIKey.Text);

                // Send request, get response
                var response = client.SendAsync(request).Result;
                var jsonResponse = response.Content.ReadAsStringAsync().Result;
            }
        }

        private void AddImages(string body)
        {
            //Create the tag
            string host = textBoxAPIEndPoint.Text;
            string route = "/customvision/v3.0/training/projects/" + textBoxProjectID.Text + "/images/urls";
            body = "{\n  \"images\": " + body + "}";
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Set the method to GET
                request.Method = HttpMethod.Post;

                // Construct the full URI
                request.RequestUri = new Uri(host + route);

                // Add the authorization header
                request.Headers.Add("Training-Key", textBoxAPIKey.Text);

                // Add the serialized JSON object to your request
                request.Content = new StringContent(body, Encoding.UTF8, "application/json");

                // Send request, get response
                var response = client.SendAsync(request).Result;
                var jsonResponse = response.Content.ReadAsStringAsync().Result;

                MessageBox.Show(jsonResponse);
            }
        }

        private void ButtonGetTags_Click(object sender, EventArgs e)
        {
            GetTags();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSelectedItemID.Text = imageTags.Find(x => x.name.Equals(listBox1.SelectedItem.ToString())).id;
        }

        private void ButtonAddTag_Click(object sender, EventArgs e)
        {
            if (imageTags.Exists(x => x.name.Equals(textBoxTagName.Text)))
            {
                //Check if the tag exists
                MessageBox.Show("Tag already exists", "Tag Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                CreateTag(textBoxTagName.Text, textBoxTagDescription.Text);
            }
        }

        private void ButtonLoadImages_Click(object sender, EventArgs e)
        {
            //Refresh Tags
            GetTags();
            // Deserializing json data to object  
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<newImages> newImages = JsonConvert.DeserializeObject<List<newImages>>(richTextBoxNewImagesJSON.Text);
            foreach (newImages image in newImages)
            {
                imageDefinition newImage = new imageDefinition();
                newImage.url = image.url;
               
                foreach (associatedTag associatedTag in image.tags)
                {
                    if (newImage.tagIds != null)
                    {
                        Array.Resize(ref newImage.tagIds, newImage.tagIds.Length+1);
                    } else
                    {
                        newImage.tagIds = new string[1];
                    }
                    newImage.tagIds[newImage.tagIds.Count()-1] = imageTags.Find(x => x.name.Equals(associatedTag.tag)).id;
                    if (!(imageTags.Exists(x => x.name.Equals(associatedTag.tag))))
                    {
                        CreateTag(associatedTag.tag, "");
                    }
                }
                //JavaScriptSerializer js = new JavaScriptSerializer();
                images.Add(newImage);
                newImage = null;
                if (images.Count >= 63)
                {
                    //call new image
                    AddImages(JsonConvert.SerializeObject(images));
                    //null images
                    images.Clear();
                }
            }
            if (images.Count > 0)
            {
                //call new image
                AddImages(JsonConvert.SerializeObject(images));
                //null images
                images.Clear();
            }
        }

        private void ButtonCleanTags_Click(object sender, EventArgs e)
        {
            GetTags();
            foreach (imagetag tag in imageTags)
            {
                if (tag.imagecount < 5)
                {
                    //delete tags with too few images
                    RemoveTag(tag.id);
                }
            }
            GetTags();
        }
    }
}
