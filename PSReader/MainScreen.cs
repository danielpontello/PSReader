using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;
using Newtonsoft.Json;

namespace PSReader
{	
    public partial class MainScreen : Scene
    {
		string TOP_STORIES_URL = "https://hacker-news.firebaseio.com/v0/topstories.json?print=pretty";
		string STORY_ID_URL = "https://hacker-news.firebaseio.com/v0/item/{0}.json?print=pretty";
		
		string text = "";
		
		List<HNStory> TopStories;
		List<HNComment> Comments;
		
        public MainScreen()
        {
            InitializeWidget();
			List<int> TopStoryIDs = GetTopStoryIDs();
			TopStories = GetTopStories(TopStoryIDs, 20);
			Comments = new List<HNComment>();
			
			// Story List
			StoryList.Sections = new ListSectionCollection {
			        new ListSection(" Top Stories", 20)};
			StoryList.SetListItemCreator(() => new StoryListItem());
			StoryList.SetListItemUpdater((item) => { 
				StoryListItem currentItem = (StoryListItem)item;
				
				currentItem.ListItemIndex.Text = ""+(item.Index+1);
				currentItem.ListItemTitle.Text = TopStories[item.Index].title;
				currentItem.ListItemAuthor.Text = TopStories[item.Index].by;
				currentItem.ListItemTime.Text = Utils.GetPrettyDate(Utils.UnixTimestampToDateTime(TopStories[item.Index].time));
			});
			
			StoryList.SelectItemChanged += HandleStoryListSelectItemChanged;
			
			// Comment List
			CommentList.Sections = new ListSectionCollection {
			        new ListSection(" Comments", 20)};
			CommentList.SetListItemCreator(() => new CommentListItem());
			CommentList.SetListItemUpdater((item) => {
				CommentListItem currentItem = (CommentListItem)item;
				if(item.Index < Comments.Count)
				{
					currentItem.CommentBy.Text = Comments[item.Index].by;
					currentItem.CommentTime.Text = Utils.GetPrettyDate(Utils.UnixTimestampToDateTime(Comments[item.Index].time));
					currentItem.CommentContent.Text = Utils.HTMLDecode(Comments[item.Index].text);
				}				
			});
			
			// Status Bar		
			Status.Text = TopStories.Count + " stories fetched.";
        }

        void HandleStoryListSelectItemChanged (object sender, ListPanelItemSelectChangedEventArgs e)
        {
			NoStoryPanel.Visible = true;
			ContentLabel.Text = "Loading Story...";
        	HNStory selectedStory = TopStories[e.Index];
			Console.WriteLine("story comments", selectedStory.kids.Count);
			
			
			Comments = GetComments(selectedStory.kids, 20);
			
			StoryTitle.Text = selectedStory.title;
			StoryInfo.Text = selectedStory.score + " points by " + selectedStory.by + " - " + Utils.GetPrettyDate(
				Utils.UnixTimestampToDateTime(TopStories[e.Index].time));
			NoStoryPanel.Visible = false;
        }
		
		public List<HNComment> GetComments(List<int> ids, int num)
		{
			List<HNComment> comments = new List<HNComment>();
			
			for(int i=0; i<Math.Min (num, ids.Count); i++)
			{
				String commentJson = Download(string.Format(STORY_ID_URL, ids[i]));
				
				if(commentJson == null)
					continue;
				
				HNComment comment = JsonConvert.DeserializeObject<HNComment>(commentJson);
				comments.Add(comment);
			}
			
			return comments;
		}
		
		public List<HNStory> GetTopStories(List<int> ids, int num)
		{
			List<HNStory> stories = new List<HNStory>();
			
			for(int i=0; i<num; i++)
			{
				String storyJson = Download(string.Format(STORY_ID_URL, ids[i]));
				
				if(storyJson == null)
					continue;
				
				HNStory story = JsonConvert.DeserializeObject<HNStory>(storyJson);
				stories.Add(story);
			}
			
			return stories;
		}
        
		public List<int> GetTopStoryIDs()
		{
			String topStoriesJson = Download(TOP_STORIES_URL);
			
			if(topStoriesJson == null)
				return null;
			
			List<int> topStories = JsonConvert.DeserializeObject<List<int>>(topStoriesJson);
			Console.Write ("Obtained " + topStories.Count + " stories.");
			return topStories;			
		}
		
		public string Download(string url)
		{
			String responseString = null;
			
			HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(url);
			HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
			
			if(response.StatusCode == HttpStatusCode.OK)
			{
				using(Stream stream = response.GetResponseStream())
				{
					StreamReader reader = new StreamReader(stream, Encoding.UTF8);
					responseString = reader.ReadToEnd();
				}
			}
			return responseString;
		}
    }
}
