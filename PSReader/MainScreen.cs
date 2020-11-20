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
		
        public MainScreen()
        {
            InitializeWidget();
			List<int> TopStoryIDs = GetTopStoryIDs();
			TopStories = GetTopStories(TopStoryIDs, 20);
			
			// set the section titles and item counts
			StoryList.Sections = new ListSectionCollection {
			        new ListSection("Top Stories", 20)};
			
			// set the creator delegate
			
			StoryList.SetListItemCreator(() => new StoryListItem());
			// set the updater delegate
			StoryList.SetListItemUpdater((item) => { 
				StoryListItem currentItem = (StoryListItem)item;
				
				currentItem.ListItemIndex.Text = ""+(item.Index+1);
				currentItem.ListItemTitle.Text = TopStories[item.Index].title;
				currentItem.ListItemAuthor.Text = TopStories[item.Index].by;
				currentItem.ListItemTime.Text = ""+TopStories[item.Index].time;
			});
			
			StoryList.SelectItemChanged += (sender, e) =>
			    Console.WriteLine("selected index:{0}", e.Index);
			
			Status.Text = TopStories.Count + " stories fetched.";
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
