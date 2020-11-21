// AUTOMATICALLY GENERATED CODE

using System;
using System.Collections.Generic;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.HighLevel.UI;

namespace PSReader
{
    partial class MainScreen
    {
        Panel TitlePanel;
        Label TitleText;
        Label ClockText;
        Panel StatusPanel;
        Label Status;
        ListPanel StoryList;
        Label StoryTitle;
        ListPanel CommentList;
        Label StoryInfo;
        Panel NoStoryPanel;
        Label ContentLabel;

        private void InitializeWidget()
        {
            InitializeWidget(LayoutOrientation.Horizontal);
        }

        private void InitializeWidget(LayoutOrientation orientation)
        {
            TitlePanel = new Panel();
            TitlePanel.Name = "TitlePanel";
            TitleText = new Label();
            TitleText.Name = "TitleText";
            ClockText = new Label();
            ClockText.Name = "ClockText";
            StatusPanel = new Panel();
            StatusPanel.Name = "StatusPanel";
            Status = new Label();
            Status.Name = "Status";
            StoryList = new ListPanel();
            StoryList.Name = "StoryList";
            StoryTitle = new Label();
            StoryTitle.Name = "StoryTitle";
            CommentList = new ListPanel();
            CommentList.Name = "CommentList";
            StoryInfo = new Label();
            StoryInfo.Name = "StoryInfo";
            NoStoryPanel = new Panel();
            NoStoryPanel.Name = "NoStoryPanel";
            ContentLabel = new Label();
            ContentLabel.Name = "ContentLabel";

            // MainScreen
            this.RootWidget.AddChildLast(TitlePanel);
            this.RootWidget.AddChildLast(StatusPanel);
            this.RootWidget.AddChildLast(StoryList);
            this.RootWidget.AddChildLast(StoryTitle);
            this.RootWidget.AddChildLast(CommentList);
            this.RootWidget.AddChildLast(StoryInfo);
            this.RootWidget.AddChildLast(NoStoryPanel);

            // TitlePanel
            TitlePanel.BackgroundColor = new UIColor(255f / 255f, 102f / 255f, 0f / 255f, 255f / 255f);
            TitlePanel.Clip = true;
            TitlePanel.AddChildLast(TitleText);
            TitlePanel.AddChildLast(ClockText);

            // TitleText
            TitleText.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            TitleText.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            TitleText.LineBreak = LineBreak.Character;

            // ClockText
            ClockText.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            ClockText.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            ClockText.LineBreak = LineBreak.Character;
            ClockText.HorizontalAlignment = HorizontalAlignment.Right;

            // StatusPanel
            StatusPanel.BackgroundColor = new UIColor(255f / 255f, 102f / 255f, 0f / 255f, 255f / 255f);
            StatusPanel.Clip = true;
            StatusPanel.AddChildLast(Status);

            // Status
            Status.TextColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            Status.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            Status.LineBreak = LineBreak.Character;

            // StoryList
            StoryList.ScrollBarVisibility = ScrollBarVisibility.ScrollableVisible;

            // StoryTitle
            StoryTitle.TextColor = new UIColor(0f / 255f, 0f / 255f, 0f / 255f, 255f / 255f);
            StoryTitle.Font = new UIFont(FontAlias.System, 25, FontStyle.Bold);
            StoryTitle.LineBreak = LineBreak.Character;
            StoryTitle.VerticalAlignment = VerticalAlignment.Top;

            // CommentList
            CommentList.ScrollBarVisibility = ScrollBarVisibility.ScrollableVisible;

            // StoryInfo
            StoryInfo.TextColor = new UIColor(95f / 255f, 95f / 255f, 95f / 255f, 255f / 255f);
            StoryInfo.Font = new UIFont(FontAlias.System, 20, FontStyle.Regular);
            StoryInfo.LineBreak = LineBreak.Character;

            // NoStoryPanel
            NoStoryPanel.BackgroundColor = new UIColor(255f / 255f, 255f / 255f, 255f / 255f, 255f / 255f);
            NoStoryPanel.Clip = true;
            NoStoryPanel.AddChildLast(ContentLabel);

            // ContentLabel
            ContentLabel.TextColor = new UIColor(95f / 255f, 95f / 255f, 95f / 255f, 255f / 255f);
            ContentLabel.Font = new UIFont(FontAlias.System, 25, FontStyle.Regular);
            ContentLabel.LineBreak = LineBreak.Character;
            ContentLabel.HorizontalAlignment = HorizontalAlignment.Center;

            SetWidgetLayout(orientation);

            UpdateLanguage();
        }

        private LayoutOrientation _currentLayoutOrientation;
        public void SetWidgetLayout(LayoutOrientation orientation)
        {
            switch (orientation)
            {
                case LayoutOrientation.Vertical:
                    this.DesignWidth = 544;
                    this.DesignHeight = 960;

                    TitlePanel.SetPosition(0, 0);
                    TitlePanel.SetSize(100, 100);
                    TitlePanel.Anchors = Anchors.None;
                    TitlePanel.Visible = true;

                    TitleText.SetPosition(12, 0);
                    TitleText.SetSize(214, 36);
                    TitleText.Anchors = Anchors.None;
                    TitleText.Visible = true;

                    ClockText.SetPosition(12, 0);
                    ClockText.SetSize(214, 36);
                    ClockText.Anchors = Anchors.None;
                    ClockText.Visible = true;

                    StatusPanel.SetPosition(0, 0);
                    StatusPanel.SetSize(100, 100);
                    StatusPanel.Anchors = Anchors.None;
                    StatusPanel.Visible = true;

                    Status.SetPosition(12, 0);
                    Status.SetSize(214, 36);
                    Status.Anchors = Anchors.None;
                    Status.Visible = true;

                    StoryList.SetPosition(0, 40);
                    StoryList.SetSize(854, 400);
                    StoryList.Anchors = Anchors.None;
                    StoryList.Visible = true;

                    StoryTitle.SetPosition(505, 141);
                    StoryTitle.SetSize(214, 36);
                    StoryTitle.Anchors = Anchors.None;
                    StoryTitle.Visible = true;

                    CommentList.SetPosition(68, 27);
                    CommentList.SetSize(854, 400);
                    CommentList.Anchors = Anchors.None;
                    CommentList.Visible = true;

                    StoryInfo.SetPosition(488, 86);
                    StoryInfo.SetSize(214, 36);
                    StoryInfo.Anchors = Anchors.None;
                    StoryInfo.Visible = true;

                    NoStoryPanel.SetPosition(558, 128);
                    NoStoryPanel.SetSize(100, 100);
                    NoStoryPanel.Anchors = Anchors.None;
                    NoStoryPanel.Visible = true;

                    ContentLabel.SetPosition(0, 0);
                    ContentLabel.SetSize(214, 36);
                    ContentLabel.Anchors = Anchors.None;
                    ContentLabel.Visible = true;

                    break;

                default:
                    this.DesignWidth = 960;
                    this.DesignHeight = 544;

                    TitlePanel.SetPosition(0, 0);
                    TitlePanel.SetSize(960, 40);
                    TitlePanel.Anchors = Anchors.None;
                    TitlePanel.Visible = true;

                    TitleText.SetPosition(8, 0);
                    TitleText.SetSize(214, 40);
                    TitleText.Anchors = Anchors.None;
                    TitleText.Visible = true;

                    ClockText.SetPosition(735, 0);
                    ClockText.SetSize(214, 40);
                    ClockText.Anchors = Anchors.None;
                    ClockText.Visible = true;

                    StatusPanel.SetPosition(0, 504);
                    StatusPanel.SetSize(960, 40);
                    StatusPanel.Anchors = Anchors.None;
                    StatusPanel.Visible = true;

                    Status.SetPosition(8, 0);
                    Status.SetSize(214, 40);
                    Status.Anchors = Anchors.None;
                    Status.Visible = true;

                    StoryList.SetPosition(0, 40);
                    StoryList.SetSize(479, 464);
                    StoryList.Anchors = Anchors.None;
                    StoryList.Visible = true;

                    StoryTitle.SetPosition(488, 51);
                    StoryTitle.SetSize(461, 27);
                    StoryTitle.Anchors = Anchors.None;
                    StoryTitle.Visible = true;

                    CommentList.SetPosition(488, 107);
                    CommentList.SetSize(461, 395);
                    CommentList.Anchors = Anchors.None;
                    CommentList.Visible = true;

                    StoryInfo.SetPosition(488, 78);
                    StoryInfo.SetSize(461, 20);
                    StoryInfo.Anchors = Anchors.None;
                    StoryInfo.Visible = true;

                    NoStoryPanel.SetPosition(479, 40);
                    NoStoryPanel.SetSize(481, 464);
                    NoStoryPanel.Anchors = Anchors.None;
                    NoStoryPanel.Visible = true;

                    ContentLabel.SetPosition(0, 0);
                    ContentLabel.SetSize(481, 464);
                    ContentLabel.Anchors = Anchors.None;
                    ContentLabel.Visible = true;

                    break;
            }
            _currentLayoutOrientation = orientation;
        }

        public void UpdateLanguage()
        {
            TitleText.Text = "Hacker News";

            ClockText.Text = "01:33";

            Status.Text = "Done";

            StoryTitle.Text = "label";

            StoryInfo.Text = "Test Text";

            ContentLabel.Text = "No story selected.";
        }

        private void onShowing(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

        private void onShown(object sender, EventArgs e)
        {
            switch (_currentLayoutOrientation)
            {
                case LayoutOrientation.Vertical:
                    break;

                default:
                    break;
            }
        }

    }
}
