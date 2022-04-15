using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace asp_getfiles
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\");
            DirectoryInfo ParentDirectory = new DirectoryInfo(@"C:\AMD\");
            DirectoryInfo ParentDirectory2 = new DirectoryInfo(@"C:\WINDOWS\");
            DirectoryInfo ParentDirectory3 = new DirectoryInfo(@"C:\Strawberry\");
            DirectoryInfo ParentDirectory4 = new DirectoryInfo(@"C:\Users\");
            DirectoryInfo ParentDirectory5 = new DirectoryInfo(@"C:\ADE\");
            FileInfo[] files = directoryInfo.GetFiles();
            FileInfo[] subfiles2 = ParentDirectory2.GetFiles();
            FileInfo[] subfiles3 = ParentDirectory3.GetFiles();
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            DirectoryInfo[] subdirectories = ParentDirectory.GetDirectories();
            DirectoryInfo[] subdirect2 = ParentDirectory2.GetDirectories();
            DirectoryInfo[] subdirect3 = ParentDirectory3.GetDirectories();
            DirectoryInfo[] subdirect4 = ParentDirectory4.GetDirectories();
            DirectoryInfo[] subdirect5 = ParentDirectory5.GetDirectories();


            foreach (var directory in directories)
            {
                
                ListBox1.Items.Add("Folder: " + directory.FullName + " " + directory.Parent);
                
            }
            
            
            foreach (var file in files)
                {

                    ListBox1.Items.Add("File: " + file.DirectoryName + file);

                }
            
            foreach (var subdirectory in subdirectories)
            {

                ListBox1.Items.Add("Sub-Folder1: " + subdirectory.Parent + "/ " + subdirectory.ToString());

            }
            foreach (var subdirectory in subdirect2)
            {

                ListBox1.Items.Add("Sub-Folder2: " + subdirectory.FullName + subdirectory.Parent + "/ " + subdirectory.ToString());

            }

            foreach (var subdirectory in subdirect3)
            {

                ListBox1.Items.Add("Sub-Folder3: " + subdirectory.FullName + subdirectory.Parent + "/ " + subdirectory.ToString());

            }

            foreach (var subdirectory in subdirect4)
            {

                ListBox1.Items.Add("Sub-Folder4: " + subdirectory.FullName + subdirectory.Parent + "/ " + subdirectory.ToString());

            }

            foreach (var subdirectory in subdirect5)
            {

                ListBox1.Items.Add("Sub-Folder5: " + subdirectory.FullName + subdirectory.Parent + "/ " + subdirectory.ToString());

            }
            
            foreach (var subfile in subfiles2)
            {

                ListBox1.Items.Add("Sub-File: " + subfile.DirectoryName + subfile);
            }

            foreach (var subfile in subfiles3)
                {

                    ListBox1.Items.Add("Sub-File: " + subfile.DirectoryName + subfile);

                }

            
        }
    }
}