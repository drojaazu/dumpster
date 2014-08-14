using System;
using System.Windows.Forms;

namespace Dumpster2
{
    public static class ChooseFile
    {
        public static string Open(string Title = "Select file...", string DefaultFilename = null, string StartDir = null, string Filter = null)
        
        {
            var SelectFile = new OpenFileDialog();
            SelectFile.CheckFileExists = true;
            SelectFile.AddExtension = true;
            if (!string.IsNullOrEmpty(Title)) SelectFile.Title = Title;
            if (!string.IsNullOrEmpty(Filter)) SelectFile.Filter = Filter;
            if (!string.IsNullOrEmpty(StartDir)) SelectFile.InitialDirectory = StartDir;
            if (!string.IsNullOrEmpty(DefaultFilename)) SelectFile.FileName = DefaultFilename;
            if (SelectFile.ShowDialog() != DialogResult.OK) return null;
            return SelectFile.FileName;
        }

        public static string Save(string Title = "Save file as...", string DefaultFilename = null, string StartDir = null, string Filter = null)
        {
            var SelectFile = new SaveFileDialog();
            //SelectFile.CheckFileExists = false;
            SelectFile.AddExtension = true;
            if (!string.IsNullOrEmpty(Title)) SelectFile.Title = Title;
            if (!string.IsNullOrEmpty(Filter)) SelectFile.Filter = Filter;
            if (!string.IsNullOrEmpty(StartDir)) SelectFile.InitialDirectory = StartDir;
            if (!string.IsNullOrEmpty(DefaultFilename)) SelectFile.FileName = DefaultFilename;
            if (SelectFile.ShowDialog() != DialogResult.OK) return null;
            return SelectFile.FileName;
        }

    }
}
