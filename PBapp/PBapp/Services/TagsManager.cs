using PBapp.Core;
using PBapp.Data;
using PBapp.MVVM.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PBapp.Services
{
    internal class TagsManager : ObservableObject
    {
        #region CheckedTags

        private ObservableCollection<string> _checkedTags = new();

        public ObservableCollection<string> CheckedTags { get => _checkedTags; set => Set(ref _checkedTags, value); }

        #endregion

        #region Tags

        private ObservableCollection<TagModel> _tags;

        public ObservableCollection<TagModel> Tags { get => _tags; set => Set(ref _tags, value); }

        #endregion

        #region TagsString

        private string? _tagsString;

        public string? TagsString { get => _tagsString; set => Set(ref _tagsString, value); }

        #endregion

        public const string DISCLAIMER = "Contains affiliate links . As a customer, you do not pay any more or less because of an affiliated link.\r\nA small percentage of the sale will go to the person who generated the link.";
        public const string ABBDISCLAIMER = "#DISCLAIMER";

        public TagsManager() 
        {
            Tags = GetData.GetListFromJson(Tags, GetData.TAGSPATH);
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
            if (check && tagName == ABBDISCLAIMER) AddToCheckedTags(DISCLAIMER);
            else if (check) AddToCheckedTags(tagName);
            else
            {
                if (tagName == ABBDISCLAIMER) RemoveFromCheckedTags(DISCLAIMER);
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
