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
		
        public MainScreen()
        {
            InitializeWidget();
			List<int> TopStories = GetTopStoryIDs();
			this.Label_1.Text = "Story Count: " + TopStories.Count;
        }
        
		public List<int> GetTopStoryIDs()
		{
			String topStoriesJson = Download(TOP_STORIES_URL);
			
			if(topStoriesJson == null)
				return null;
			
			List<int> topStories = JsonConvert.DeserializeObject<List<int>>(topStoriesJson);
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
