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
		
        public MainScreen()
        {
            InitializeWidget();
			List<int> TopStoryIDs = GetTopStoryIDs();
			List<HNStory> TopStories = GetTopStories(TopStoryIDs, 20);
			
			foreach(HNStory story in TopStories)
			{
				text += story.title + "\n";
			}
			this.Label_1.Text = text;
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
