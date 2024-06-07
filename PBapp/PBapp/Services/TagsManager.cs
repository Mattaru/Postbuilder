using PBapp.Core;
using PBapp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace PBapp.Services
{
    internal class TagsManager : ObservableObject
    {
        #region CheckedTags

        private List<string> _checkedTags = new();

        public List<string> CheckedTags { get => _checkedTags; set => Set(ref _checkedTags, value); }

        #endregion

        #region TagsString

        private string? _tagsString;

        public string? TagsString { get => _tagsString; set => Set(ref _tagsString, value); }

        #endregion

        public TagsManager() 
        {
            CheckedTags.Add(string.Empty);
        }

        private void AddToCheckedTags(string tagName)
        {
            CheckedTags.Add(tagName);
        }
        private void RemoveFromCheckedTags(string tagName)
        { 
            CheckedTags.RemoveAt(CheckedTags.IndexOf(tagName));
        }
        public void AddToCheckedIfActive(string tagName, bool check)
        {
            if (check && tagName == Tags.ABBDISCLAIMER) AddToCheckedTags(Tags.DISCLAIMER);
            else if (check) AddToCheckedTags(tagName);
            else
            {
                if (tagName == Tags.ABBDISCLAIMER) RemoveFromCheckedTags(Tags.DISCLAIMER);
                else RemoveFromCheckedTags(tagName);
            }
        }

        public void MakeTagString()
        {
            foreach (var item in CheckedTags)
            {
                TagsString += " " + item;
            }
        }
    }
}
